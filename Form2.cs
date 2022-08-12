using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class Form2 : Form
    {
        public string fname;
        public string lname;
        public int dayy;
        public string monthh;
        public int yearr;
        private string pass;
        public string Usernamee;
        public string code;
        public string mobilenum="123456789";
        public string genderr;
        public string choice;
        public string mailtaill;
        SqlConnection ConnectionSql;
      
      
        public Form2()
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

            string connectionStr = Properties.Settings.Default.ConectionData;
            ConnectionSql = new SqlConnection(connectionStr);
            try
            {
                if (ConnectionSql.State != System.Data.ConnectionState.Open)
                {
                    ConnectionSql.Open();
                    //MessageBox.Show("Welcome to Yahoo Registration Form!", "Yahoo Registration");
                }
                else
                {
                    MessageBox.Show("Welcome To Smart Health !", "Smart Health");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }


        private void Continue_Click(object sender, EventArgs e)
        {
            ErrorProvider err1 = new ErrorProvider();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // fname = Firstname.Text;
                if (fname == "")
                {
                  var dialoge=  MessageBox.Show("Error! First Name cannot be Empty" + " " + Firstname.Text, "First Name ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    err1.SetError(Firstname, "Empty");
                    if(dialoge==DialogResult.OK)
                    {
                        Firstname.Focus();
                        err1.Clear();
                    }
                    return;
                   
                }
                if (lname == "")
                {
                    var dialoge = MessageBox.Show("Error! Last Name cannot be Empty" + " " + Lastname.Text, "Last Name ", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    err1.SetError(Lastname, "Empty");
                    if (dialoge == DialogResult.OK)
                    {
                        Lastname.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (Usernamee == "")
                {
                    var dialoge = MessageBox.Show("Error! Email Address cannot be Empty" + " " + username.Text, "Email Address ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(username, "Empty");
                    username.Focus();
                    if (dialoge == DialogResult.OK)
                    {
                        username.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (mailtaill == "")
                {
                    var dialoge =  MessageBox.Show("Email Prefix cannot be Empty" + " " + username.Text, "Email Prefix ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(Mail_tail, "Empty");
                    
                    if (dialoge == DialogResult.OK)
                    {
                        Mail_tail.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (pass == "" || (pass.Length < 6))
                {
                  var dialoge=  MessageBox.Show("Error! Password cannot be Empty or less than 6 characters" + " " + password.Text, "Password ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    err1.SetError(password, "Empty");
                    if (dialoge == DialogResult.OK)
                    {
                        password.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if(code== "")
                {
                  var dialoge=  MessageBox.Show("Error! Country Code cannot be Empty" + " " + Code_comboBox.Text, "Country Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(Code_comboBox, "Empty");
                    if (dialoge == DialogResult.OK)
                    {
                        Code_comboBox.Focus();
                        err1.Clear();
                    }
                   
                    return;
                }
                if (mobilenum == "" || mobilenum.Length != 10)
                {
                 var   dialoge= MessageBox.Show("Error! Mobile Number cannot be less than 10 digits" + " " + mobilenumber.Text, "Mobile Phone Number ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(mobilenumber, "Empty");
                    if (dialoge == DialogResult.OK)
                    {
                        mobilenumber.Focus();
                        err1.Clear();
                    }
                    
                    return;
                }
                if (monthh == "")
                {
                    var dialoge = MessageBox.Show("Error! Please Select Month" + " " + month_comboBox.Text, "Month", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(month_comboBox, "Empty");
                   
                    if (dialoge == DialogResult.OK)
                    {
                        month_comboBox.Focus();
                        err1.Clear();           
                    }
                    return;
                }
                try
                {
                    dayy = int.Parse(Day.Text);
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Day is wrong");
                }
                try
                {
                    yearr = int.Parse(year.Text);

                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "year is wrong");
                }
                if (dayy==0)
                {
                    var dialoge = MessageBox.Show("Error! Day cannot be Empty" + " " + Day.Text.ToString(), "Day", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(Day, "Empty");

                    if (dialoge == DialogResult.OK)
                    {
                        Day.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if(dayy<1 || dayy>31)
                {
                    var dialoge = MessageBox.Show("Error! Please enter correct day" + " " + Day.Text.ToString(), "Day", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(Day, "Empty");

                    if (dialoge == DialogResult.OK)
                    {
                        Day.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (yearr == 0)
                {

                    var dialoge = MessageBox.Show("Error! Year cannot be Empty" + " " + year.Text.ToString(), "Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(year, "Empty");

                    if (dialoge == DialogResult.OK)
                    {
                        year.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (yearr < 1 || yearr > DateTime.Now.Year)
                {
                    var dialoge = MessageBox.Show("Error! Please Enter The correct year" + " " + year.Text.ToString(), "Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    err1.SetError(year, "Empty");

                    if (dialoge == DialogResult.OK)
                    {
                        year.Focus();
                        err1.Clear();
                    }
                    return;
                }
                if (Doctor_btn.Checked == false && Patient_btn.Checked == false)
                {
                    MessageBox.Show("Please select any one From Doctor or Patient", "Choose Doctor / Patient",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    err1.SetError(Doctor_btn, "Select");
                    err1.SetError(Patient_btn, "Select");
                    return;
                }

                if (choice== "")
                {
                    MessageBox.Show("Your choice of Doctor or Patient is Empty", "Select Any One",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
              
                else
                {
                    Mysqlfunction(fname, lname, Usernamee, pass, code, mobilenum, monthh, dayy, yearr,choice,mailtaill);

                }
                

              //  MessageBox.Show(fname+" "+ lname+" "+Usernamee+" "+pass+" "+code+" "+monthh +" " + dayy);
            }


        }//continue click  

        private void Mysqlfunction(string fname, string lname, string usernamee, string pass, string code, string mobilenum, string monthh, int dayy, int yearr, string cHoice, string MAiltail)
        {
            try
            {
            string EmailAddres = usernamee+MAiltail;
            string PhoneNumber = code + mobilenum;
            string dateofbirth = dayy + "/" + monthh + "/" + yearr;
            string genderrr = Gender.Text;
            string query = String.Format("Insert into Yahooo (FirstName, LastName, EmailAddress, PassWord,MobileNumber,DateOfBirth,GenderOPT,Choice)"
                                                    + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                                fname, lname, EmailAddres, pass,PhoneNumber,dateofbirth,genderrr,cHoice);
          
                using (SqlCommand command = new SqlCommand(query, ConnectionSql))
                {
                    int numberOfAffectedRows = command.ExecuteNonQuery();

                  var diag=  MessageBox.Show("Successfuly Registered! \n Your Email Address is"+" "+ EmailAddres, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    if (diag == DialogResult.OK)
                    {
                        Form1 For1 = new Form1();
                        For1.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Generalvalidation(object sender, CancelEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            fname =  Firstname.Text.ToUpper();
            lname = Lastname.Text.ToUpper();
            Usernamee = username.Text;
            pass = password.Text;
            mobilenum = mobilenumber.Text.Replace(" ", "");
            code = Code_comboBox.Text;
            monthh = month_comboBox.Text;
            mailtaill = Mail_tail.Text;
           
            // dayy = int.Parse(Day.Text);
            // yearr = Convert.ToInt32(year.Text);


            if (fname.ToCharArray().Any(char.IsDigit))
            {
               var dialogue= MessageBox.Show("Error! First Name must not contains any number" + " " + Firstname.Text, "First Name ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                err.SetError(Firstname,"Error");
                if (dialogue == DialogResult.OK)
                {
                    Firstname.Focus();
                    err.Clear();
                }
                
                return;
            }
            if (fname.ToCharArray().Any(char.IsWhiteSpace))
            {
                var dialogue = MessageBox.Show("Error! First Name must not contains any Whitespaces" + " " + Firstname.Text, "First Name ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(Firstname, "Error");
                if (dialogue == DialogResult.OK)
                {
                    Firstname.Focus();
                    err.Clear();
                }
                return;
            }
            if (fname.ToCharArray().Any(char.IsPunctuation) || fname.ToCharArray().Any(char.IsSeparator) || fname.ToCharArray().Any(char.IsSymbol))
            {
                var dialogue = MessageBox.Show("First Name must not contain any Punctuation, Separators or Symbols " + "\n" + Firstname.Text, "First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(Firstname, "Error");
                if (dialogue == DialogResult.OK)
                {
                    Firstname.Focus();
                    err.Clear();
                }
                return;
            }
            if (lname.ToCharArray().Any(char.IsDigit))
            {
                var dialogue = MessageBox.Show("Error! Last Name must not contain any number" + " " + Lastname.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(Lastname, "string only");
                if (dialogue == DialogResult.OK)
                {
                    Lastname.Focus();
                    err.Clear();
                }
              
                return;
            }
            if (lname.ToCharArray().Any(char.IsWhiteSpace))
            {
                var dialogue = MessageBox.Show("Error! Last Name must not contain any Whitespaces" + " " + Lastname.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(Lastname, "Whitespaces");
                if (dialogue == DialogResult.OK)
                {
                    Lastname.Focus();
                    err.Clear();
                }
                return;
            }

            if (lname.ToCharArray().Any(char.IsPunctuation) || lname.ToCharArray().Any(char.IsSeparator) || lname.ToCharArray().Any(char.IsSymbol))
            {
              var dialogue=  MessageBox.Show("Last Name must not contain any Punctuation, Separators or Symbols " + "\n" + Lastname.Text, "Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(Lastname, "symbols");
                if (dialogue == DialogResult.OK)
                {
                    Lastname.Focus();
                    err.Clear();
                }
                return;
            }

            if (Usernamee.Length>30)
            {
                var diag= MessageBox.Show("Error Email Address cannot be that large" +" "+username.Text, "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(username, "Error");
                if (diag == DialogResult.OK)
                {
                    username.Focus();
                    err.Clear();
                }
                return;
            }
            if( Usernamee.Contains("@yahoo.com")|| Usernamee.Contains("@gmail.com")|| Usernamee.Contains("@.com") || Usernamee.Contains("@") || Usernamee.Contains(".com"))
            {
                var diag = MessageBox.Show("Do not Include '@.com'  " + " " + username.Text, "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(username, "Error");
                if (diag == DialogResult.OK)
                {
                    username.Focus();
                    err.Clear();
                }
                return;          
            }

            if (Usernamee.ToCharArray().Any(char.IsWhiteSpace))
            {
                var diag = MessageBox.Show("Error Email contain Empty spaces" + " " + username.Text, "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(username, "Error");
                if (diag == DialogResult.OK)
                {
                    username.Focus();
                    err.Clear();
                }
                return;
            }
            if (Usernamee.ToCharArray().Any(char.IsPunctuation) || Usernamee.ToCharArray().Any(char.IsSeparator) || Usernamee.ToCharArray().Any(char.IsSymbol))
            {
              
                var diag = MessageBox.Show("Email must not contain any Punctuation, Separators or Symbols "+ username.Text, "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(username, "Error");
                if (diag == DialogResult.OK)
                {
                    username.Focus();
                    err.Clear();
                }
                return;
            }


            if ( mobilenum.ToCharArray().Any(char.IsLetter)|| mobilenum.ToCharArray().Any(char.IsWhiteSpace)|| mobilenum.ToCharArray().Any(char.IsPunctuation)|| mobilenum.ToCharArray().Any(char.IsSeparator)|| mobilenum.ToCharArray().Any(char.IsSymbol))
            {
                
                var diag = MessageBox.Show("Phone number is Wrong\nPjone Number cannot contain any Punctuation, Separators or Symbols " + mobilenumber.Text, "Mobile Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err.SetError(mobilenumber, "Error");
                if (diag == DialogResult.OK)
                {
                    mobilenumber.Focus();
                    err.Clear();
                }
             
                return;
            }
            if(Doctor_btn.Checked==true)
            {
                choice = Doctor_btn.Text;
                return;
            }
            if (Patient_btn.Checked == true)
            {
                choice = Patient_btn.Text;
                return;
            }
          

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionSql.Close();
            Application.ExitThread();
           // Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (ConnectionSql.State != System.Data.ConnectionState.Closed)
            {
                ConnectionSql.Close();
                MessageBox.Show("Are You sure Do You Want To Exit!", "Smart Health Registration", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Form1 For1 = new Form1();
                For1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Are You sure Do You Want To Exit!", "Smart Health",MessageBoxButtons.OK,MessageBoxIcon.Question);
                Form1 For1 = new Form1();
                For1.Show();
                this.Close();
            }
        }

       
    }
}
