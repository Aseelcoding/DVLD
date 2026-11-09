namespace PL.UsersControls
{
    partial class ucPersonEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.radbtnFemale = new System.Windows.Forms.RadioButton();
            this.radbtnMale = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbLinkRemoveImage = new System.Windows.Forms.LinkLabel();
            this.lbLinkSetImage = new System.Windows.Forms.LinkLabel();
            this.picPerson = new System.Windows.Forms.PictureBox();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThirdName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labTitle, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1036, 123);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labTitle.ForeColor = System.Drawing.Color.Maroon;
            this.labTitle.Location = new System.Drawing.Point(480, 43);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(76, 36);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.radbtnFemale);
            this.panel1.Controls.Add(this.radbtnMale);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbCountry);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbLinkRemoveImage);
            this.panel1.Controls.Add(this.lbLinkSetImage);
            this.panel1.Controls.Add(this.picPerson);
            this.panel1.Controls.Add(this.dateDateOfBirth);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtNationalNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtThirdName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSecondName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 401);
            this.panel1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::PL.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(521, 322);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 34);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::PL.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(651, 322);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(180, 215);
            this.txtAddress.MaxLength = 500;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(580, 100);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Tag = "Address";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::PL.Properties.Resources.Address_32;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(14, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "Address:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(180, 171);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 25);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Tag = "Email";
            this.txtEmail.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Image = global::PL.Properties.Resources.Email_32;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(14, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Email:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radbtnFemale
            // 
            this.radbtnFemale.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnFemale.Image = global::PL.Properties.Resources.Woman_32;
            this.radbtnFemale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radbtnFemale.Location = new System.Drawing.Point(271, 118);
            this.radbtnFemale.Name = "radbtnFemale";
            this.radbtnFemale.Size = new System.Drawing.Size(123, 47);
            this.radbtnFemale.TabIndex = 25;
            this.radbtnFemale.Text = "Female";
            this.radbtnFemale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radbtnFemale.UseVisualStyleBackColor = true;
            this.radbtnFemale.CheckedChanged += new System.EventHandler(this.radbtnFemale_CheckedChanged);
            // 
            // radbtnMale
            // 
            this.radbtnMale.Checked = true;
            this.radbtnMale.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMale.Image = global::PL.Properties.Resources.Man_32;
            this.radbtnMale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radbtnMale.Location = new System.Drawing.Point(159, 118);
            this.radbtnMale.Name = "radbtnMale";
            this.radbtnMale.Size = new System.Drawing.Size(106, 47);
            this.radbtnMale.TabIndex = 24;
            this.radbtnMale.TabStop = true;
            this.radbtnMale.Text = "Male";
            this.radbtnMale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radbtnMale.UseVisualStyleBackColor = true;
            this.radbtnMale.CheckedChanged += new System.EventHandler(this.radbtnMale_CheckedChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Image = global::PL.Properties.Resources.Gender_32;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Location = new System.Drawing.Point(14, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 23);
            this.label13.TabIndex = 23;
            this.label13.Text = "Gender:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(580, 168);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(180, 31);
            this.cmbCountry.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = global::PL.Properties.Resources.Country_32;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(410, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 23);
            this.label12.TabIndex = 21;
            this.label12.Text = "Country";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(580, 129);
            this.txtPhone.Mask = "000000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 27);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.Tag = "Phone";
            this.txtPhone.ValidatingType = typeof(int);
            this.txtPhone.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Image = global::PL.Properties.Resources.Phone_32;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Location = new System.Drawing.Point(410, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Phone";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLinkRemoveImage
            // 
            this.lbLinkRemoveImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkRemoveImage.Location = new System.Drawing.Point(826, 356);
            this.lbLinkRemoveImage.Name = "lbLinkRemoveImage";
            this.lbLinkRemoveImage.Size = new System.Drawing.Size(108, 28);
            this.lbLinkRemoveImage.TabIndex = 18;
            this.lbLinkRemoveImage.TabStop = true;
            this.lbLinkRemoveImage.Text = "Remove";
            this.lbLinkRemoveImage.Visible = false;
            this.lbLinkRemoveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkRemoveImage_LinkClicked);
            // 
            // lbLinkSetImage
            // 
            this.lbLinkSetImage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinkSetImage.Location = new System.Drawing.Point(823, 318);
            this.lbLinkSetImage.Name = "lbLinkSetImage";
            this.lbLinkSetImage.Size = new System.Drawing.Size(111, 38);
            this.lbLinkSetImage.TabIndex = 17;
            this.lbLinkSetImage.TabStop = true;
            this.lbLinkSetImage.Text = "Set Image";
            this.lbLinkSetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLinkSetImage_LinkClicked);
            // 
            // picPerson
            // 
            this.picPerson.Location = new System.Drawing.Point(780, 64);
            this.picPerson.Name = "picPerson";
            this.picPerson.Size = new System.Drawing.Size(180, 251);
            this.picPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPerson.TabIndex = 16;
            this.picPerson.TabStop = false;
            this.picPerson.Tag = "ImagePath";
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDateOfBirth.Location = new System.Drawing.Point(580, 76);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(180, 30);
            this.dateDateOfBirth.TabIndex = 5;
            this.dateDateOfBirth.Tag = "DateOfBirth";
            this.dateDateOfBirth.Value = new System.DateTime(2026, 11, 4, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::PL.Properties.Resources.Calendar_32;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(380, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date Of Birth:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtNationalNo.Location = new System.Drawing.Point(180, 80);
            this.txtNationalNo.MaxLength = 20;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(180, 27);
            this.txtNationalNo.TabIndex = 4;
            this.txtNationalNo.Tag = "NationalNo";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::PL.Properties.Resources.Number_32;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(10, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "National No:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(775, 33);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(180, 27);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Tag = "LastName";
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtLastName.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(848, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Last";
            // 
            // txtThirdName
            // 
            this.txtThirdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdName.Location = new System.Drawing.Point(578, 33);
            this.txtThirdName.MaxLength = 20;
            this.txtThirdName.Name = "txtThirdName";
            this.txtThirdName.Size = new System.Drawing.Size(180, 27);
            this.txtThirdName.TabIndex = 2;
            this.txtThirdName.Tag = "ThirdName";
            this.txtThirdName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtThirdName.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Third";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(382, 33);
            this.txtSecondName.MaxLength = 20;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(180, 27);
            this.txtSecondName.TabIndex = 1;
            this.txtSecondName.Tag = "SecondName";
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtSecondName.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(443, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Second";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(180, 33);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "FirstName";
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtFirstName.Leave += new System.EventHandler(this.LeaveField);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "First";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PL.Properties.Resources.Person_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Image = global::PL.Properties.Resources.Number_32;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(123, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "N/A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucPersonEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "ucPersonEditor";
            this.Size = new System.Drawing.Size(1036, 598);
            this.Load += new System.EventHandler(this.ucPersonEditor_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThirdName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lbLinkRemoveImage;
        private System.Windows.Forms.LinkLabel lbLinkSetImage;
        private System.Windows.Forms.PictureBox picPerson;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radbtnMale;
        private System.Windows.Forms.RadioButton radbtnFemale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
