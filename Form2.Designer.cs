
namespace Yahoo
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.mobilenumber = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Code_comboBox = new System.Windows.Forms.ComboBox();
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Doctor_btn = new System.Windows.Forms.RadioButton();
            this.Patient_btn = new System.Windows.Forms.RadioButton();
            this.Mail_tail = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(561, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(521, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create new email address";
            // 
            // Firstname
            // 
            this.Firstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Firstname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Firstname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Firstname.Location = new System.Drawing.Point(493, 134);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(138, 29);
            this.Firstname.TabIndex = 2;
            this.Firstname.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // Lastname
            // 
            this.Lastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lastname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lastname.Location = new System.Drawing.Point(641, 134);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(142, 29);
            this.Lastname.TabIndex = 3;
            this.Lastname.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ControlText;
            this.username.Location = new System.Drawing.Point(493, 189);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(197, 29);
            this.username.TabIndex = 4;
            this.username.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ControlText;
            this.password.Location = new System.Drawing.Point(493, 239);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(290, 29);
            this.password.TabIndex = 5;
            this.password.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // mobilenumber
            // 
            this.mobilenumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mobilenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobilenumber.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilenumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mobilenumber.Location = new System.Drawing.Point(568, 287);
            this.mobilenumber.Name = "mobilenumber";
            this.mobilenumber.Size = new System.Drawing.Size(215, 29);
            this.mobilenumber.TabIndex = 7;
            this.mobilenumber.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // Day
            // 
            this.Day.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Day.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Day.Location = new System.Drawing.Point(599, 338);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(76, 29);
            this.Day.TabIndex = 9;
            this.Day.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // year
            // 
            this.year.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.year.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.ForeColor = System.Drawing.SystemColors.ControlText;
            this.year.Location = new System.Drawing.Point(682, 338);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(101, 29);
            this.year.TabIndex = 10;
            this.year.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // Gender
            // 
            this.Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Gender.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Gender.Location = new System.Drawing.Point(493, 392);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(290, 29);
            this.Gender.TabIndex = 11;
            this.Gender.Validating += new System.ComponentModel.CancelEventHandler(this.Generalvalidation);
            // 
            // Code_comboBox
            // 
            this.Code_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Code_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Code_comboBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code_comboBox.FormattingEnabled = true;
            this.Code_comboBox.Items.AddRange(new object[] {
            "+92",
            "+93",
            "+300",
            "+100",
            "+101",
            "+443",
            "+55",
            "+90",
            "+27",
            "+311",
            "+344",
            "+337",
            "+300",
            "+17",
            "+19",
            "+12"});
            this.Code_comboBox.Location = new System.Drawing.Point(493, 285);
            this.Code_comboBox.Name = "Code_comboBox";
            this.Code_comboBox.Size = new System.Drawing.Size(69, 31);
            this.Code_comboBox.TabIndex = 12;
            this.Code_comboBox.TabStop = false;
            // 
            // month_comboBox
            // 
            this.month_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.month_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.month_comboBox.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_comboBox.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.month_comboBox.Location = new System.Drawing.Point(493, 336);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(100, 31);
            this.month_comboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(492, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "By clicking \"Continue\". you agree to the Terms \r\n                        and Priv" +
    "acy Policy ";
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Continue.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.White;
            this.Continue.Location = new System.Drawing.Point(493, 538);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(290, 40);
            this.Continue.TabIndex = 16;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(492, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Already Have An Account? ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(693, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sign in";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(490, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "First name";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(638, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Last name";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(493, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email address";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(492, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Password";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(568, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phone mobile number";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(603, 319);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Day";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(693, 319);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Year";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(493, 378);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Gender (optional)";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(490, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Country code";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(492, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Month";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1220, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(839, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(435, 676);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Doctor_btn
            // 
            this.Doctor_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Doctor_btn.AutoSize = true;
            this.Doctor_btn.BackColor = System.Drawing.Color.Maroon;
            this.Doctor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctor_btn.ForeColor = System.Drawing.Color.White;
            this.Doctor_btn.Location = new System.Drawing.Point(496, 440);
            this.Doctor_btn.Name = "Doctor_btn";
            this.Doctor_btn.Size = new System.Drawing.Size(75, 24);
            this.Doctor_btn.TabIndex = 23;
            this.Doctor_btn.TabStop = true;
            this.Doctor_btn.Text = "Doctor";
            this.Doctor_btn.UseVisualStyleBackColor = false;
            // 
            // Patient_btn
            // 
            this.Patient_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Patient_btn.AutoSize = true;
            this.Patient_btn.BackColor = System.Drawing.Color.Maroon;
            this.Patient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_btn.ForeColor = System.Drawing.Color.White;
            this.Patient_btn.Location = new System.Drawing.Point(704, 440);
            this.Patient_btn.Name = "Patient_btn";
            this.Patient_btn.Size = new System.Drawing.Size(77, 24);
            this.Patient_btn.TabIndex = 23;
            this.Patient_btn.TabStop = true;
            this.Patient_btn.Text = "Patient";
            this.Patient_btn.UseVisualStyleBackColor = false;
            // 
            // Mail_tail
            // 
            this.Mail_tail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mail_tail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Mail_tail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_tail.FormattingEnabled = true;
            this.Mail_tail.Items.AddRange(new object[] {
            "@Yahoo.com",
            "@gmail.com",
            "@hotmail.com"});
            this.Mail_tail.Location = new System.Drawing.Point(696, 189);
            this.Mail_tail.Name = "Mail_tail";
            this.Mail_tail.Size = new System.Drawing.Size(85, 31);
            this.Mail_tail.TabIndex = 12;
            this.Mail_tail.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(693, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Email Prefix";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1273, 674);
            this.Controls.Add(this.Patient_btn);
            this.Controls.Add(this.Doctor_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.month_comboBox);
            this.Controls.Add(this.Mail_tail);
            this.Controls.Add(this.Code_comboBox);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.mobilenumber);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox mobilenumber;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.ComboBox Code_comboBox;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton Doctor_btn;
        private System.Windows.Forms.RadioButton Patient_btn;
        private System.Windows.Forms.ComboBox Mail_tail;
        private System.Windows.Forms.Label label3;
    }
}