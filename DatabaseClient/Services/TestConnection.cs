﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabaseClient.Services
{
    class TestConnection
    {
        public TestConnection()
        {
            Connect();
        }

        private void Connect()
        {
            try
            {
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConString))
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
                Console.WriteLine("duppa błąd połączenia");
            }
            }
        }
    }


