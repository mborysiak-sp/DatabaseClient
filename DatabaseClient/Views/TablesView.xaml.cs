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
            FillDataGridWrzeciono();
            FillDataGridWytaczadlo();
            FillDataGridDokument();
        }
        private void FillDataGridWytaczadlo()
        {
            string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            string CmdString = string.Empty;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                CmdString = "SELECT * FROM wytaczadlo_z_lozyskiem";
                SqlCommand cmd = new SqlCommand(CmdString, con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Wytaczadlo");
                sda.Fill(dt);
                gridWytaczadlo.ItemsSource = dt.DefaultView;
            }
        }
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
                sda.Fill(dt);
                gridWrzeciono.ItemsSource = dt.DefaultView;
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
                sda.Fill(dt);
                gridDokument.ItemsSource = dt.DefaultView;
            }
        }
    }
}
