using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class viewrecords : Form
    {
        public viewrecords()
        {
            InitializeComponent();
            void loaddata()
            {
                for (int i = 0; i < 500; i++)
                {
                    Thread.Sleep(10);
                }
            }
            using (progressbar frm = new progressbar(loaddata))
            {
                frm.ShowDialog(this);
            }

            SqlConnection ConnectionSql;
            string connectionStr = Properties.Settings.Default.ConectionData;
            ConnectionSql = new SqlConnection(connectionStr);
            try
            {
                ConnectionSql.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT Name,MobileNumber,Patient.EmailAddress,Height,Weight,Eyesight,HomeAddress,disability,surgery,accident,geneticdisorder,disease,situation FROM Patient join symptoms on Patient.EmailAddress=symptoms.emailaddress", connectionStr);
                ad.Fill(dt);
                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

    }
}