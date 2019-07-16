﻿
using DatabaseClient.EntityData;
using DatabaseClient.Messages;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;


namespace Support
{
    public class CrudVMBase : NotifyUIBase
    {
        protected BoringSpindlesEntities db = new BoringSpindlesEntities();

        protected void HandleCommand(CommandMessage action)
        {
            if (isCurrentView)
            {
                switch (action.Command)
                {
                    case CommandType.Insert:
                        break;
                    case CommandType.Edit:
                        break;
                    case CommandType.Delete:
                        DeleteCurrent();
                        break;
                    case CommandType.Commit:
                        CommitUpdates();
                        break;
                    case CommandType.Refresh:
                        RefreshData();
                        break;
                    default:
                        break;
                }
            }
        }
        private Visibility throbberVisible = Visibility.Visible;
        public Visibility ThrobberVisible
        {
            get { return throbberVisible; }
            set
            {
                throbberVisible = value;
                RaisePropertyChanged();
            }
        }
        private string errorMessage;

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                errorMessage = value;
                RaisePropertyChanged();
            }
        }

        protected virtual void CommitUpdates() { }
        protected virtual void DeleteCurrent() { }
        protected virtual void RefreshData()
        {
            GetData();
            Messenger.Default.Send<UserMessage>(new UserMessage { Message = "Data Refreshed" });
        }

        protected virtual void GetData() { }
        protected CrudVMBase()
        {
            GetData();
            Messenger.Default.Register<CommandMessage>(this, (action) => HandleCommand(action));
            Messenger.Default.Register<NavigateMessage>(this, (action) => CurrentUserControl(action));
        }
        protected bool isCurrentView = false;
        private void CurrentUserControl(NavigateMessage nm)
        {
            if (this.GetType() == nm.ViewModelType)
                isCurrentView = true;
            else
                isCurrentView = false;
        }
    }
}
