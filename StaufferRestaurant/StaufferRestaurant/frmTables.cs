using System;
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
        
        public frmTables()
        {
            InitializeComponent();
        }

        private static frmTables frmTablesInstance = new frmTables();
        static internal frmTables Instance
        {
            get
            {
                if (frmTablesInstance == null)
                {
                    frmTablesInstance = new frmTables();
                }
                return frmTablesInstance;
            }
        }
        private void frmTables_Load(object sender, EventArgs e)
        {
            fillListBox();
        }

        private void fillListBox()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
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
                lstTableList.Items.Add(dr.GetInt32(0) + " - " + dr.GetInt32(1) + " - " + dr.GetInt32(2));
            }
            lstTableList.EndUpdate();
            dr.Close();
            conn.Close();


        }
    }
}
