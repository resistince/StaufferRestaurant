﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace StaufferRestaurant
{
    public partial class frmTables : Form
    {
        private static frmTables frmTablesInstance;

        
        public frmTables()
        {
            InitializeComponent();
        }

        private void frmTables_Load(object sender, EventArgs e)
        {
            fillListBox();
        }

        private void fillListBox()
        {
            try
            {

               // String connectionString = "Data Source=TRAVIS-PC\\SQLEXPRESS;Initial Catalog=StaufferRestaurant;Integrated Security=True;Pooling=False";
                String connectionString = Properties.Settings.Default.StaufferRestaurantConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter da = new SqlDataAdapter();

                String commandString = "SELECT TableID, SeatingCapacity, CurrentCapacity from tblTables";
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;
                conn.Open();
                cmd.CommandText = commandString;
                cmd.Connection = conn;
                dr = cmd.ExecuteReader();
                lstTableList.Items.Clear();
                lstTableList.BeginUpdate();
                while (dr.Read())
                {
                    if (dr.GetInt32(2) >= dr.GetInt32(1))
                    {
                        lstTableList.Items.Add(dr.GetInt32(0) + "      FULL");
                    }
                    else
                    {
                        lstTableList.Items.Add(dr.GetInt32(0));
                    }
                }
                lstTableList.EndUpdate();
                dr.Close();
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void frmTables_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmTablesInstance = null;
        }
    }
}
