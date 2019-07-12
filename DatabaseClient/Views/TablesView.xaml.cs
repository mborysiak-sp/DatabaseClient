﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using System.Windows.Shapes;

namespace DatabaseClient.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Tables.xaml
    /// </summary>
    public partial class TablesView : UserControl
    {
        public TablesView()
        {
            InitializeComponent();
            //FillDataGridWrzeciono();
            FillDataGridWytaczadlo();
            //FillDataGridDokument();
        }
        private void FillDataGridWytaczadlo()
        {
            string ConString = string.Empty;
            try
            {
                ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                try
                {
                    con.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                    CmdString = "SELECT * FROM wytaczadlo_z_lozyskiem";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Wytaczadlo");
                    sda.Fill(dt);
                    gridWytaczadlo.ItemsSource = dt.DefaultView;


            }
        }
        /*
        private void FillDataGridWrzeciono()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT id_wrzeciono AS 'ID', typ, nr_seryjny AS 'numer seryjny' FROM wrzeciono";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Wrzeciono");
                try
                {
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                try
                {
                    gridWrzeciono.ItemsSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                }   
            }
        }
        private void FillDataGridDokument()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM wszystkie_dokumenty";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Dokument");
                try
                {
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                try
                {
                    gridWrzeciono.ItemsSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            */
        }
    }

