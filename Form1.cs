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
    public partial class Form1 : Form
    {
        SqlConnection ConnectionSql;
       // SqlCommand command;
      
    public   string email;
     public string passwoord;
        public Form1()
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

            // this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.Show();
            string connectionStr = Properties.Settings.Default.ConectionData;
            ConnectionSql = new SqlConnection(connectionStr);
            try
            {
                ConnectionSql.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
          
           
                email = Email_Login.Text;
                passwoord = Password_Login.Text;
            if (email != "" && passwoord != "")
            {
               FunctionforEmail(email);
               FunctionPassword(passwoord);
            }
            if (FunctionforEmail(email) == true && FunctionPassword(passwoord) == true)
            {
                MessageBox.Show("Login Successful" +" "+"\nWelcome To your Yahoo mail account","Yahoo");
                ConnectionSql.Close();
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
                
                
            }
            if (FunctionforEmail(email) == false && FunctionPassword(passwoord) == false)
            {
                MessageBox.Show("Login Failed" + " " + "\nYou Have Entered Wrong Email and Password", "Smart Health",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if(FunctionforEmail(email)==false)
            {
                MessageBox.Show("Login Failed" + " " + "\nYou Have Entered Wrong Email", "Smart Health", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(FunctionPassword(passwoord)==false)
            {
                MessageBox.Show("Login Failed" + " " + "\nYou Have Entered Wrong Pasword", "Smart Health", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private bool FunctionforEmail(string email)
        {
            SqlCommand cmd = new SqlCommand("select * from Yahooo where EmailAddress = '" + Email_Login.Text + "' OR MobileNumber = '" + Email_Login.Text +"'", ConnectionSql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da.Fill(ds1);
            int i = ds1.Tables[0].Rows.Count;
            if (i > 0)
            {
                //MessageBox.Show("Login successful");
                email_label2.Visible = false;
                pass_lablche.Visible = false;
                return true;
                
            }
            else
            {
                email_label2.Visible = true;
                
              //  MessageBox.Show("Email is not Registered");
                return false;
            }
        }
        private bool FunctionPassword(string passwoord)
        {
            SqlCommand cmd = new SqlCommand("select * from Yahooo where PassWord = '" + passwoord + "'", ConnectionSql);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds2 = new DataSet();
            da1.Fill(ds2);
            int i = ds2.Tables[0].Rows.Count;
            if (i > 0)
            {
               // MessageBox.Show("Login successful");
                email_label2.Visible = false;
                pass_lablche.Visible = false;
                return true;
            }
            else
            {

                pass_lablche.Visible = true;
               // MessageBox.Show("Password is not found");
                return false;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

            ConnectionSql.Close();
            Form2 F1 = new Form2();
            F1.Show();
            this.Hide();
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Are you sure do you want to Exit!", "Exit",MessageBoxButtons.OK,MessageBoxIcon.Question);
            ConnectionSql.Close();
           // Application.Exit();
            Application.ExitThread();
        }
    }
}
