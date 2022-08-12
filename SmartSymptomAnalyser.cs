using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahoo
{
    public partial class SmartSymptomAnalyser : Form
    {
        string Fname, Lname, Name, Mobilenum, Email, Heig, Weig, Eyesig, Homeaddres;
        string disability, surgery, accident, geneticdisorder, disease, situation;

      

        string date;
        SqlConnection ConnectionSql;

      

        SqlCommand cmd;
        public SmartSymptomAnalyser()
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

            date = ("Time: "+DateTime.Now.Hour+"."+DateTime.Now.Second+"\nDate: "+DateTime.Now.Day+"-"+DateTime.Now.Month+"-"+DateTime.Now.Year).ToString();
           
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



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void save_info_btn_Click(object sender, EventArgs e)
        {
            ErrorProvider err1 = new ErrorProvider();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (Fname == "")
                {
                    var diag = MessageBox.Show("First Name is Required" + " " + Firstname_txt.Text, "First Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Firstname_txt, "Error");
                    Firstname_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }

                if (Lname == "")
                {
                    var diag = MessageBox.Show("Last Name is Required" + " " + Lastname_txt.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Lastname_txt, "Error");
                    Lastname_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (Mobilenum == "")
                {
                    var diag = MessageBox.Show("Mobile Number is Required" + " " + Phonenumber_txt.Text, "Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Phonenumber_txt, "Error");
                    Phonenumber_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }

                if (Mobilenum.Length < 11)
                {
                    var diag = MessageBox.Show("Mobile Number is Wrong" + " " + Phonenumber_txt.Text, "Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Phonenumber_txt, "Error");
                    Phonenumber_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }

                if (Email == "")
                {
                    var diag = MessageBox.Show("Username is Required" + " " + EmailAddress_txt.Text, "User Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(EmailAddress_txt, "Error");
                    EmailAddress_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                 //if ( Convert.ToInt32(Heig) > 213.36)
                 //   {
                 //       var diag = MessageBox.Show("Your BMI Height is not Correct" + " " + Height_txt.Text, "Height", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 //       err1.SetError(Height_txt, "Error");
                 //       Height_txt.Focus();
                 //       if (diag == DialogResult.OK)
                 //       {
                 //           err1.Clear();
                 //       }
                 //       return;
                 //   }

                 //   if ( Convert.ToInt32(Weig) > 300)
                 //   {
                 //       var diag = MessageBox.Show("Your BMI Weight is not Correct" + " " + Weight_txt.Text, "Weight", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 //       err1.SetError(Weight_txt, "Error");
                 //       Weight_txt.Focus();
                 //       if (diag == DialogResult.OK)
                 //       {
                 //           err1.Clear();
                 //       }
                 //       return;
                 //   }

                 //   if ( Convert.ToInt32(Eyesig) > 6)
                 //   {
                 //       var diag = MessageBox.Show("Your Eyesight is not Correct" + " " + Eyesight_txt.Text, "Eyesight", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                 //       err1.SetError(Eyesight_txt, "Error");
                 //       Eyesight_txt.Focus();
                 //       if (diag == DialogResult.OK)
                 //       {
                 //           err1.Clear();
                 //       }
                 //       return;
                 //   }

                if (Homeaddres.Length > 150)
                {
                    var diag = MessageBox.Show("Home Address Can not be more than 150 characters" + " " + Homeaddress_txt.Text, "Home Address", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Homeaddress_txt, "Error");
                    Homeaddress_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }

                else
                    {
                     // MessageBox.Show(Fname + "" + Lname + "" + Email + "" + Mobilenum + "\n" + Heig + "" + Weig + "" + Eyesig + "\n" + Homeaddres);
                      MyInsertFunction(Fname, Lname, Name, Mobilenum, Email, Heig, Weig, Eyesig, Homeaddres,date);
                    }
               

            }
        }

        private void MyInsertFunction(string fname, string lname, string name, string mobilenum, string email, string heig, string weig, string eyesig, string homeaddres, string DATE)
        {
            Name = fname + " " + lname;
           
            string query = String.Format("Insert into Patient (Name, MobileNumber, EmailAddress, Height,Weight,Eyesight,HomeAddress,Date)"
                                                     + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                                 Name, mobilenum, email, heig + "" + "Cms", weig + "" + "Kgs", eyesig,homeaddres,DATE);
            try
            {
                using (SqlCommand command = new SqlCommand(query, ConnectionSql))
                {
                    int numberOfAffectedRows = command.ExecuteNonQuery();

                  var di=  MessageBox.Show("Your Personal Information Has Been Saved Successfuly!" + "\n Number of Rows Affected: "+numberOfAffectedRows + Name, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                  
                    
                }
        }
            catch (SqlException ex)
            {
              //  MessageBox.Show(ex.Message);
                if (ex.Number == 2627) // <-- but this will
                {
                    try
                    {

                        cmd = new SqlCommand("update Patient set Name=@name, MobileNumber=@num, EmailAddress=@email, Height=@height, Weight=@weight,Eyesight=@eyesight,HomeAddress=@home,Date=@date where EmailAddress=@email", ConnectionSql);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@num", mobilenum);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@height", heig);
                        cmd.Parameters.AddWithValue("@weight", weig);
                        cmd.Parameters.AddWithValue("@eyesight", eyesig);
                        cmd.Parameters.AddWithValue("@home", homeaddres);
                        cmd.Parameters.AddWithValue("@date", DATE);


                        using (cmd)
                        {
                            int numberOfAffectedRows = cmd.ExecuteNonQuery();
                            if (numberOfAffectedRows != 0)
                            {
                                var dialoge = MessageBox.Show(" Updated Successfuly! \nNumber of affected rows : " +
                                numberOfAffectedRows +
                                 " Row Affected", "Message", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(" Updating Failed! \nNumber of affected rows : " +
                                numberOfAffectedRows +
                                 " Row Affected", "Message", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);

                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }

            }
}

        private void Generalvalidation(object sender, CancelEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            Fname = Firstname_txt.Text;
            Lname = Lastname_txt.Text;
            Email = EmailAddress_txt.Text;
            Mobilenum = Phonenumber_txt.Text;
            Heig = Height_txt.Text;
            Weig = Weight_txt.Text;
            Eyesig = Eyesight_txt.Text;
            Homeaddres = Homeaddress_txt.Text;

            if (Fname.ToCharArray().Any(char.IsDigit))
            {
              var diag=  MessageBox.Show("First Name Cannot be Number" + " " + Firstname_txt.Text, "First Name ",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                err.SetError(Firstname_txt, "Error");
                Firstname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Fname.ToCharArray().Any(char.IsWhiteSpace))
            {
                var diag = MessageBox.Show("First Name Cannot Have Whitespaces" + " " + Firstname_txt.Text, "First Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Firstname_txt, "Error");
                Firstname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Fname.ToCharArray().Any(char.IsPunctuation) || Fname.ToCharArray().Any(char.IsSeparator) || Fname.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("First Name Cannot be Punctutation/ Separator/ Symbol" + " " + Firstname_txt.Text, "First Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Firstname_txt, "Error");
                Firstname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }
            if (Lname.ToCharArray().Any(char.IsDigit))
            {
                var diag = MessageBox.Show("Last Name Cannot be Number" + " " + Lastname_txt.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Lastname_txt, "Error");
                Lastname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Lname.ToCharArray().Any(char.IsWhiteSpace))
            {
                var diag = MessageBox.Show("Last Name Cannot Have Whitespaces" + " " + Lastname_txt.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Lastname_txt, "Error");
                Lastname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Lname.ToCharArray().Any(char.IsPunctuation) || Lname.ToCharArray().Any(char.IsSeparator) || Lname.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Last Name Cannot be Punctutation/ Separator/ Symbol" + " " + Lastname_txt.Text, "Last Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Lastname_txt, "Error");
                Lastname_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }
            if (Mobilenum.ToCharArray().Any(char.IsLetter))
            {
                var diag = MessageBox.Show("Mobile Number Cannot be Letters" + " " + Phonenumber_txt.Text, "Mobile Number ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Phonenumber_txt, "Error");
                Phonenumber_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Mobilenum.ToCharArray().Any(char.IsWhiteSpace))
            {
                var diag = MessageBox.Show("Mobile Number  Cannot Have Whitespaces" + " " + Phonenumber_txt.Text, "Mobile Number  ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Phonenumber_txt, "Error");
                Phonenumber_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Mobilenum.ToCharArray().Any(char.IsPunctuation) || Mobilenum.ToCharArray().Any(char.IsSeparator) || Mobilenum.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Mobile Number Cannot be Punctutation/ Separator/ Symbol" + " " + Phonenumber_txt.Text, "Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Phonenumber_txt, "Error");
                Phonenumber_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }


            if (Email.Length > 30)
            {
                var diag = MessageBox.Show("Email Cannot be That Large must be less than 30 characters" + " " + EmailAddress_txt.Text, "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(EmailAddress_txt, "Error");
                EmailAddress_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }
            if (Email.ToCharArray().Any(char.IsPunctuation) || Email.ToCharArray().Any(char.IsSeparator) || Email.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("User Name Cannot be Punctutation/ Separator/ Symbol" + " " + EmailAddress_txt.Text, "User Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(EmailAddress_txt, "Error");
                EmailAddress_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Email.ToCharArray().Any(char.IsWhiteSpace))
            {
                var diag = MessageBox.Show("Username Cannot Have Whitespaces" + " " + EmailAddress_txt.Text, "User Name ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(EmailAddress_txt, "Error");
                EmailAddress_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Heig.ToCharArray().Any(char.IsLetter))
            {
                var diag = MessageBox.Show("Height Cannot be Letters" + " " + Height_txt.Text, "Height", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Height_txt, "Error");
                Height_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Heig.ToCharArray().Any(char.IsPunctuation) || Heig.ToCharArray().Any(char.IsSeparator) || Heig.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Heigh Cannot be Punctutation/ Separator/ Symbol" + " " + Height_txt.Text, "Heigh", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Height_txt, "Error");
                Height_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Weig.ToCharArray().Any(char.IsLetter))
            {
                var diag = MessageBox.Show("Weight Cannot be Letters" + " " + Weight_txt.Text, "Weight", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Weight_txt, "Error");
                Weight_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Weig.ToCharArray().Any(char.IsPunctuation) || Weig.ToCharArray().Any(char.IsSeparator) || Weig.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Weight Cannot be Punctutation/ Separator/ Symbol" + " " + Weight_txt.Text, "Weigh", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Weight_txt, "Error");
                Weight_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Eyesig.ToCharArray().Any(char.IsLetter))
            {
                var diag = MessageBox.Show("Eyesight Cannot be Letters" + " " + Eyesight_txt.Text, "Eyesight", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Eyesight_txt, "Error");
                Eyesight_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

            if (Eyesig.ToCharArray().Any(char.IsPunctuation) || Eyesig.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Eyesight Cannot be Punctutation/ Symbol"+ " " + Eyesight_txt.Text, "Eyesight", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(Eyesight_txt, "Error");
                Eyesight_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }
            //here it ends
        }


        private void Save_symptoms_btn_Click(object sender, EventArgs e)
        {
            ErrorProvider err1 = new ErrorProvider();
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (disability == "")
                {
                    var diag = MessageBox.Show("Disability is Required" + " " + Disability_combox.Text, "Disability ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Disability_combox, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (surgery == "")
                {
                    var diag = MessageBox.Show("Surgery is Required" + " " + surgery_combox.Text, "Surgery ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(surgery_combox, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (accident == "")
                {
                    var diag = MessageBox.Show("Accident is Required" + " " + Accident_combox.Text, "Accident ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Accident_combox, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (geneticdisorder == "")
                {
                    var diag = MessageBox.Show("Genetic Disorder is Required" + " " + Genetic_combox.Text, "Genetic Disorder ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Genetic_combox, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (disease == "")
                {
                    var diag = MessageBox.Show("Symptoms are Required" + " " + Dieases_combox.Text, "Symptoms ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(Dieases_combox, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (situation == "")
                {
                    var diag = MessageBox.Show("Situation is Required" + " " + situation_txt.Text, "Situation ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(situation_txt, "Error");
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (situation.Length > 500)
                {
                    var diag = MessageBox.Show("Situation should not be more than 500 words" + " " + situation_txt.Text, "Situation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(situation_txt, "Error");
                    situation_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                if (Email == "")
                {
                    var diag = MessageBox.Show("Username is Required" + " " + EmailAddress_txt.Text, "User Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    err1.SetError(EmailAddress_txt, "Error");
                    EmailAddress_txt.Focus();
                    if (diag == DialogResult.OK)
                    {
                        err1.Clear();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show(disability + "\n" + surgery + "\n" + accident + "\n" + geneticdisorder + "\n" + disease + "\n" + situation + "\n");
                    MysymptomsFunction(Email, disability, surgery, accident, geneticdisorder, disease, situation);
                }
            }

        }// save btn ends here

        private void MysymptomsFunction(string emaill, string disabilityy, string surgeryy, string accidentt, string geneticdisorderr, string diseasee, string situationn)
        {
           
            string query = String.Format("Insert into symptoms (emailaddress, disability, surgery, accident,geneticdisorder,disease,situation)"
                                                     + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                                                 emaill, disabilityy, surgeryy, accidentt, geneticdisorderr, diseasee, situationn);
            try
            {
                using (SqlCommand command = new SqlCommand(query, ConnectionSql))
                {
                    int numberOfAffectedRows = command.ExecuteNonQuery();

                  var diag= MessageBox.Show("Your Symptoms Are Saved Successfuly!" + "\n Number of Rows Affected: " + numberOfAffectedRows + "\n" + Name, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                   if(diag==DialogResult.OK)
                    {
                      disability_lbl.Text = disability;
                      checkBox1.Checked = true;
                      surgery_lbl.Text = surgery;
                      checkBox2.Checked = true;
                      accident_lbl.Text = accident;
                      checkBox3.Checked = true;
                      disorder_lbl.Text = geneticdisorder;
                      checkBox4.Checked = true;
                      situation_lbl.Text = disease;
                      checkBox5.Checked = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void newvalidations(object sender, CancelEventArgs e)
        {
            ErrorProvider err = new ErrorProvider();
            disability = Disability_combox.Text;
            surgery = surgery_combox.Text;
            accident = Accident_combox.Text;
            geneticdisorder = Genetic_combox.Text;
            disease = Dieases_combox.Text;
            situation = situation_txt.Text;
            if (situation.ToCharArray().Any(char.IsPunctuation) || situation.ToCharArray().Any(char.IsSymbol))
            {
                var diag = MessageBox.Show("Situation Cannot have Punctutation/ Symbol" + " " + situation_txt.Text, "Situation ", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                err.SetError(situation_txt, "Error");
                situation_txt.Focus();
                if (diag == DialogResult.OK)
                {
                    err.Clear();
                }
                return;
            }

        }


        private void Show_btn_Click(object sender, EventArgs e)
        {
            ErrorProvider err1 = new ErrorProvider();
            string mri, xrays, health, test, possible, consult;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if(disability_lbl.Text=="No" && surgery_lbl.Text=="No" && accident_lbl.Text=="No" && disorder_lbl.Text=="No" && situation_lbl.Text== "No")
                {
                    mri = "NO";
                    xrays = "NO";
                    test ="Blood Test";
                    health = "Good";
                    possible = "No Disease";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }

                //if (disability_lbl.Text == "Hearing" && surgery_lbl.Text == "Brain surgery" && accident_lbl.Text == "Yes" && disorder_lbl.Text == "Single-gene disorders" && situation_lbl.Text == "Fever, sweating,shaking chills,Shortness of breath")
                //{
                //    mri = "Yes";
                //    xrays = "NO";
                //    test = "Autopsy,Biopsy";
                //    health = "Fine";
                //    possible = "Pneumonia";
                //    consult = "No";
                //    Mri_lbl.Text = mri;
                //    xray_lbl.Text = xrays;
                //    test_lbl.Text = test;
                //    health_lbl.Text = health;
                //    possibledis_lbl.Text = possible;
                //    doctor_lbl.Text = consult;
                //}

                //if ((disability_lbl.Text == "Thinking" || surgery_lbl.Text == "Heart surgery" || accident_lbl.Text == "Yes" || disorder_lbl.Text == "Complex disorders") && situation_lbl.Text == "Weakness,Stomach pain,Headache,Loss of appetite")
                //{
                //    mri = "YES";
                //    xrays = "YES";
                //    test = "cardiac catheterization";
                //    health = "BAD";
                //    possible = "Typhoid";
                //    consult = "YES";
                //    Mri_lbl.Text = mri;
                //    xray_lbl.Text = xrays;
                //    test_lbl.Text = test;
                //    health_lbl.Text = health;
                //    possibledis_lbl.Text = possible;
                //    doctor_lbl.Text = consult;
                //}


                //if (((disability_lbl.Text == "Vision" || disability_lbl.Text == "Hearing" || disability_lbl.Text == "Thinking" || disability_lbl.Text == "Learning" || disability_lbl.Text == "Movement" || disability_lbl.Text == "Mental health")
                //              || (surgery_lbl.Text == "Heart surgery" || surgery_lbl.Text == "Angiography" || surgery_lbl.Text == "Kidney transplant" || surgery_lbl.Text == "Lungs surgery" || surgery_lbl.Text == "Chemotherapy" || surgery_lbl.Text == "No")
                //              || (accident_lbl.Text == "Yes" || accident_lbl.Text == "No") &&
                //              (disorder_lbl.Text == "Complex disorders" || disorder_lbl.Text == "Single-gene disorders" || disorder_lbl.Text == "Chromosomal disorders"))
                //              || situation_lbl.Text == "Headaches,Nosebleed,Chest pain,Irregular heartbeat")
                //{
                //    mri = "YES";
                //    xrays = "Fine";
                //    test = "Blood tests, Autopsy";
                //    health = "Bad";
                //    possible = "Hypertension";
                //    consult = "NO";
                //    Mri_lbl.Text = mri;
                //    xray_lbl.Text = xrays;
                //    test_lbl.Text = test;
                //    health_lbl.Text = health;
                //    possibledis_lbl.Text = possible;
                //    doctor_lbl.Text = consult;
                //}

                if ((disability_lbl.Text == "No" || surgery_lbl.Text == "No" || accident_lbl.Text == "No" || disorder_lbl.Text == "No") && situation_lbl.Text == "Fever, sweating,shaking chills,Shortness of breath")
                {
                    mri = "NO";
                    xrays = "NO";
                    test = "Blood Test";
                    health = "Good";
                    possible = "Pneumonia";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }

                if ((disability_lbl.Text == "Vision" || surgery_lbl.Text == "Brain surgery" || accident_lbl.Text == "Yes" || disorder_lbl.Text == "Single-gene disorders") && situation_lbl.Text == "Fever, sweating,shaking chills,Shortness of breath")
                {
                    mri = "Yes";
                    xrays = "NO";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Pneumonia";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Hearing" || surgery_lbl.Text == "Heart surgery" || accident_lbl.Text == "No" || disorder_lbl.Text == "Chromosomal disorders") && situation_lbl.Text == "Abdominal cramps,Abdominal pain,Fever, Nausea")
                {
                    mri = "Yes";
                    xrays = "NO";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Diarrhea";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Thinking" || surgery_lbl.Text == "Angiography" || accident_lbl.Text == "No" || disorder_lbl.Text == "Complex disorders") && situation_lbl.Text == "Frequent urination,Extreme hunger,Unexplained weight loss")
                {
                    mri = "Yes";
                    xrays = "NO";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Diabetes";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Learning" || surgery_lbl.Text == "Kidney transplant" || accident_lbl.Text == "Yes" || disorder_lbl.Text == "No") && situation_lbl.Text == "Headaches, Nosebleed,Chest pain, Irregular heartbeat")
                {
                    mri = "Yes";
                    xrays = "Yes";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Hypertension";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Movement" || surgery_lbl.Text == "Lungs Surgery" || accident_lbl.Text == "Yes" || disorder_lbl.Text == "No" ) && situation_lbl.Text == "Fever,dry cough,tiredness,loss of speech or movement")
                {
                    mri = "Yes";
                    xrays = "Yes";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Corona";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Mental health" || surgery_lbl.Text == "Chemotherapy" || accident_lbl.Text == "No" || disorder_lbl.Text == "No") && situation_lbl.Text == "Joint pain,tenderness,inflammation in and around the joints")
                {
                    mri = "Yes";
                    xrays = "No";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Athritis";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;
                }
                if ((disability_lbl.Text == "Communicating" || surgery_lbl.Text == "Angiography" || accident_lbl.Text == "No" || disorder_lbl.Text == "No" ) && situation_lbl.Text == "Chills,Abdominal pain,Flu-like symptoms,Change in skin color")
                {
                    mri = "Yes";
                    xrays = "No";
                    test = "Autopsy,Biopsy";
                    health = "Fine";
                    possible = "Jaundice";
                    consult = "No";
                    Mri_lbl.Text = mri;
                    xray_lbl.Text = xrays;
                    test_lbl.Text = test;
                    health_lbl.Text = health;
                    possibledis_lbl.Text = possible;
                    doctor_lbl.Text = consult;

                    
                }


            }
        }


        private void Save_to_file_Click(object sender, EventArgs e)
        {


            //TextWriter txt = new StreamWriter("C:\\Users\\mushh\\source\\repos\\Yahoo\\demo.txt");
            //txt.Write("Mri: "+Mri_lbl.Text+"\nXrays: "+xray_lbl+);
            //txt.Close();
            try
            {
                if (Email != "")
                {


                    if (!File.Exists(possibledis_lbl.Text + ".txt"))
                    {
                        MessageBox.Show(Email + ".txt File is Creating!", "File Handling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.Create(Email + ".txt").Close();
                        using (StreamWriter sw = File.AppendText(Email + ".txt"))
                        {
                            sw.WriteLine("Mri: " + Mri_lbl.Text + "\nXrays: " + xray_lbl.Text + "\nTests: " + test_lbl.Text
                                           + "\nHealth Status: " + health_lbl.Text + "\nPossible Disease: " + possibledis_lbl.Text
                                           + "\nDoctor Consultation: " + doctor_lbl.Text); // Write text to .txt file
                        }
                    }
                    else // If file already exists
                    {
                        MessageBox.Show("File Already Exists!", "File Handling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.WriteAllText(Email + ".txt", String.Empty); // Clear file
                        using (StreamWriter sw = File.AppendText(Email + ".txt"))
                        {

                            sw.WriteLine("Mri: " + Mri_lbl.Text + "\nXrays: " + xray_lbl.Text + "\nTests: " + test_lbl.Text
                                           + "\nHealth Status: " + health_lbl.Text + "\nPossible Disease: " + possibledis_lbl.Text
                                           + "\nDoctor Consultation: " + doctor_lbl.Text); // Write text to .txt file
                        }
                    }

                }
                else
                {
                    var diag = MessageBox.Show("Username is Required" + " " + EmailAddress_txt.Text, "User Name", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    EmailAddress_txt.Focus();
                     return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        


        }




    }//Programm brackets
}//Programm brackets
