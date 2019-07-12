﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatabaseClient.Views
{
    /// <summary>
    /// Logika interakcji dla klasy AddDocument.xaml
    /// </summary>
    public partial class AddDocumentView : UserControl
    {
        public AddDocumentView()
        {
            InitializeComponent();
        }

        private void AddDocument(object sender, RoutedEventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            int idDetail = -1;
            string sql = string.Empty;
            string sql2 = string.Empty;
            if (comboboxDetail.Text == "wytaczadlo")
            {
                sql = "SELECT id_wytaczadlo FROM wytaczadlo WHERE typ = @type AND nr_rysunku = @number";
                sql2 = "INSERT INTO dokument_wytaczadlo (data_wystawienia, termin, id_wytaczadlo) VALUES (GETDATE(), @termin, @idDetail)";
            }

            else if (comboboxDetail.Text == "wrzeciono")
            {
                sql = "SELECT id_wrzeciono FROM wrzeciono WHERE typ = @type AND nr_seryjny = @number";
                sql2 = "INSERT INTO dokument_wrzeciono (data_wystawienia, termin, id_wrzeciono) VALUES (GETDATE(), @termin, @idDetail)";
            }
            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("type", textboxAddDocumentType.Text);
                    cmd.Parameters.AddWithValue("number", textboxAddDocumentNumber.Text);
                    try
                    {
                        idDetail = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                using (SqlCommand cmd = new SqlCommand(sql2, con))
                {
                    cmd.Parameters.AddWithValue("termin", textboxAddDocumentDue.Text);
                    cmd.Parameters.AddWithValue("idDetail", idDetail);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                MessageBox.Show("Wprowadzono wytaczadło");
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

            }
        }
    }
}
