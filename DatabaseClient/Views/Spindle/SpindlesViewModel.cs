﻿using DatabaseClient.EntityData;
using DatabaseClient.Messages;
using GalaSoft.MvvmLight.Messaging;
using Support;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows;
using System.Windows.Threading;

namespace DatabaseClient
{
    public class SpindlesViewModel : CrudVMBase
    {
        private SpindleVM selectedSpindle;
        public SpindleVM SelectedSpindle
        {
            get
            {
                return selectedSpindle;
            }
            set
            {
                selectedSpindle = value;
                selectedEntity = value;
                RaisePropertyChanged();
            }
        }

        private SpindleVM editVM;
        public SpindleVM EditVM
        {
            get
            {
                return editVM;
            }
            set
            {
                editVM = value;
                editEntity = editVM.TheEntity;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<SpindleVM> Spindles { get; set; }
        public SpindlesViewModel()
            : base()
        {

        }

        protected override void EditCurrent()
        {
            EditVM = SelectedSpindle;
            IsInEditMode = true;
        }

        protected override void InsertNew()
        {
            EditVM = new SpindleVM();
            IsInEditMode = true;
        }

        protected override void CommitUpdates()
        {
            if (EditVM == null || EditVM.TheEntity == null)
            {
                if (db.ChangeTracker.HasChanges())
                {
                    UpdateDB();
                }
                return;
            }
            if (EditVM.TheEntity.IsValid())
            {
                if (EditVM.IsNew)
                {
                    Console.Out.WriteLine(EditVM.TheEntity.id);
                    EditVM.IsNew = false;
                    Spindles.Add(EditVM);
                    db.spindle.Add(EditVM.TheEntity);
                    UpdateDB();
                }
                else if (db.ChangeTracker.HasChanges())
                {
                    UpdateDB();
                }
                else
                {
                    ShowUserMessage("Brak zmian do zapisania");
                }
            }
            else
            {
                ShowUserMessage("Problem z wprowadzonymi danymi");
            }
        }

        private async void UpdateDB()
        {
            try
            {
                await db.SaveChangesAsync();
                ShowUserMessage("Baza danych zaktualizowana");
            }
            catch (Exception e)
            {
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    ErrorMessage = e.InnerException.GetBaseException().ToString();
                }
                ShowUserMessage("Wystąpił problem z aktualizacją bazy danych");
            }
            ReFocusRow();
        }

        protected override void DeleteCurrent()
        {
            int NumDocs = NumberOfAssignedDocuments();
            if (NumDocs > 0)
            {
                ShowUserMessage(string.Format("Nie można usunąć. Powiązane z {0} świadectwami:", NumDocs));
            }
            else
            {
                db.spindle.Remove(SelectedSpindle.TheEntity);
                Spindles.Remove(SelectedSpindle);
                RaisePropertyChanged("Spindles");
                CommitUpdates();
                selectedEntity = null;
            }
        }

        protected override void Quit()
        {
                ReFocusRow();
        }

        protected void ReFocusRow(bool withReload = true)
        {
            SelectedSpindle = null;
            IsInEditMode = false;
        }

        private int NumberOfAssignedDocuments()
        {
            var count = (from row in db.document_spindle
                         where row.id_spindle == SelectedSpindle.TheEntity.id
                         select row).Count();
            return count;
        }
        protected async override void GetData()
        {
            ThrobberVisible = Visibility.Visible;

            ObservableCollection<SpindleVM> _spindles = new ObservableCollection<SpindleVM>();
            var spindles = await (from s in db.spindle
                                   orderby s.model
                                  where s.scrapping_date == null
                                   select s).ToListAsync();

            foreach (spindle spin in spindles)
            {
                _spindles.Add(new SpindleVM { IsNew = false, TheEntity = spin });
            }
            Spindles = _spindles;
            RaisePropertyChanged("Spindles");
            ThrobberVisible = Visibility.Collapsed;
        }
    }
}
