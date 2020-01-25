namespace MyShedule
{
    partial class AddEventView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAddEvent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.cbStatus = new MaterialSkin.Controls.MaterialCheckBox();
            this.rbRecurringYearly = new System.Windows.Forms.RadioButton();
            this.txtContact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAppointment = new System.Windows.Forms.RadioButton();
            this.rb = new System.Windows.Forms.RadioButton();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.txtLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cBCC = new System.Windows.Forms.ComboBox();
            this.rbRecurringMonthly = new System.Windows.Forms.RadioButton();
            this.rbOneOff = new System.Windows.Forms.RadioButton();
            this.dtpEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpEventStart = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEventName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MyShedule.Database1DataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.materialLabel9);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddEvent);
            this.groupBox1.Controls.Add(this.materialLabel8);
            this.groupBox1.Controls.Add(this.materialLabel12);
            this.groupBox1.Controls.Add(this.materialLabel11);
            this.groupBox1.Controls.Add(this.materialLabel6);
            this.groupBox1.Controls.Add(this.materialLabel7);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.panelInputs);
            this.groupBox1.Location = new System.Drawing.Point(33, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 526);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Data";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(38, 401);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(52, 19);
            this.materialLabel9.TabIndex = 39;
            this.materialLabel9.Text = "Status";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(41, 323);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 38;
            this.materialLabel1.Text = "Location";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Depth = 0;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(431, 22);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Primary = true;
            this.btnDelete.Size = new System.Drawing.Size(30, 36);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.AutoSize = true;
            this.btnAddEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddEvent.Depth = 0;
            this.btnAddEvent.Icon = null;
            this.btnAddEvent.Location = new System.Drawing.Point(205, 467);
            this.btnAddEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Primary = true;
            this.btnAddEvent.Size = new System.Drawing.Size(48, 36);
            this.btnAddEvent.TabIndex = 27;
            this.btnAddEvent.Text = "ADD";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(38, 215);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(82, 19);
            this.materialLabel8.TabIndex = 25;
            this.materialLabel8.Text = "Event Type";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(37, 104);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(82, 19);
            this.materialLabel12.TabIndex = 12;
            this.materialLabel12.Text = "Event Start";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(37, 362);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(72, 19);
            this.materialLabel11.TabIndex = 8;
            this.materialLabel11.Text = "Reminder";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(37, 289);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(86, 19);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "Description";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(37, 252);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(62, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Contact";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(37, 178);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(126, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Event Color Code";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(37, 141);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(75, 19);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Event End";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(37, 67);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(88, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Event Mode";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(37, 30);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(90, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Event Name";
            // 
            // panelInputs
            // 
            this.panelInputs.Controls.Add(this.cbStatus);
            this.panelInputs.Controls.Add(this.rbRecurringYearly);
            this.panelInputs.Controls.Add(this.txtContact);
            this.panelInputs.Controls.Add(this.btnAddReminder);
            this.panelInputs.Controls.Add(this.panel1);
            this.panelInputs.Controls.Add(this.dtpReminder);
            this.panelInputs.Controls.Add(this.txtLocation);
            this.panelInputs.Controls.Add(this.cBCC);
            this.panelInputs.Controls.Add(this.rbRecurringMonthly);
            this.panelInputs.Controls.Add(this.rbOneOff);
            this.panelInputs.Controls.Add(this.dtpEventEnd);
            this.panelInputs.Controls.Add(this.dtpEventStart);
            this.panelInputs.Controls.Add(this.txtDescription);
            this.panelInputs.Controls.Add(this.txtEventName);
            this.panelInputs.Location = new System.Drawing.Point(168, 23);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(241, 426);
            this.panelInputs.TabIndex = 37;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Depth = 0;
            this.cbStatus.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbStatus.Location = new System.Drawing.Point(15, 372);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cbStatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Ripple = true;
            this.cbStatus.Size = new System.Drawing.Size(62, 30);
            this.cbStatus.TabIndex = 39;
            this.cbStatus.Text = "Done";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // rbRecurringYearly
            // 
            this.rbRecurringYearly.AutoSize = true;
            this.rbRecurringYearly.Location = new System.Drawing.Point(97, 57);
            this.rbRecurringYearly.Name = "rbRecurringYearly";
            this.rbRecurringYearly.Size = new System.Drawing.Size(103, 17);
            this.rbRecurringYearly.TabIndex = 42;
            this.rbRecurringYearly.Text = "Recurring-Yearly";
            this.rbRecurringYearly.UseVisualStyleBackColor = true;
            // 
            // txtContact
            // 
            this.txtContact.Depth = 0;
            this.txtContact.Hint = "";
            this.txtContact.Location = new System.Drawing.Point(10, 226);
            this.txtContact.MaxLength = 32767;
            this.txtContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.Size = new System.Drawing.Size(221, 23);
            this.txtContact.TabIndex = 41;
            this.txtContact.TabStop = false;
            this.txtContact.UseSystemPasswordChar = false;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(19, 338);
            this.btnAddReminder.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(27, 20);
            this.btnAddReminder.TabIndex = 40;
            this.btnAddReminder.Text = "+";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAppointment);
            this.panel1.Controls.Add(this.rb);
            this.panel1.Location = new System.Drawing.Point(12, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 37);
            this.panel1.TabIndex = 36;
            // 
            // rbAppointment
            // 
            this.rbAppointment.AutoSize = true;
            this.rbAppointment.Location = new System.Drawing.Point(136, 10);
            this.rbAppointment.Name = "rbAppointment";
            this.rbAppointment.Size = new System.Drawing.Size(84, 17);
            this.rbAppointment.TabIndex = 35;
            this.rbAppointment.Text = "Appointment";
            this.rbAppointment.UseVisualStyleBackColor = true;
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Checked = true;
            this.rb.Location = new System.Drawing.Point(1, 10);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(49, 17);
            this.rb.TabIndex = 34;
            this.rb.TabStop = true;
            this.rb.Text = "Task";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // dtpReminder
            // 
            this.dtpReminder.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpReminder.Enabled = false;
            this.dtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReminder.Location = new System.Drawing.Point(54, 338);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(167, 20);
            this.dtpReminder.TabIndex = 39;
            this.dtpReminder.Enter += new System.EventHandler(this.dtpReminder_Enter);
            // 
            // txtLocation
            // 
            this.txtLocation.Depth = 0;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(11, 299);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(221, 23);
            this.txtLocation.TabIndex = 39;
            this.txtLocation.TabStop = false;
            this.txtLocation.UseSystemPasswordChar = false;
            // 
            // cBCC
            // 
            this.cBCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBCC.FormattingEnabled = true;
            this.cBCC.Items.AddRange(new object[] {
            "Default",
            "Red",
            "Blue",
            "White",
            "Yellow"});
            this.cBCC.Location = new System.Drawing.Point(11, 153);
            this.cBCC.Name = "cBCC";
            this.cBCC.Size = new System.Drawing.Size(221, 21);
            this.cBCC.TabIndex = 34;
            // 
            // rbRecurringMonthly
            // 
            this.rbRecurringMonthly.AutoSize = true;
            this.rbRecurringMonthly.Location = new System.Drawing.Point(97, 34);
            this.rbRecurringMonthly.Name = "rbRecurringMonthly";
            this.rbRecurringMonthly.Size = new System.Drawing.Size(111, 17);
            this.rbRecurringMonthly.TabIndex = 33;
            this.rbRecurringMonthly.Text = "Recurring-Monthly";
            this.rbRecurringMonthly.UseVisualStyleBackColor = true;
            // 
            // rbOneOff
            // 
            this.rbOneOff.AutoSize = true;
            this.rbOneOff.Checked = true;
            this.rbOneOff.Location = new System.Drawing.Point(11, 46);
            this.rbOneOff.Name = "rbOneOff";
            this.rbOneOff.Size = new System.Drawing.Size(60, 17);
            this.rbOneOff.TabIndex = 32;
            this.rbOneOff.TabStop = true;
            this.rbOneOff.Text = "One-off";
            this.rbOneOff.UseVisualStyleBackColor = true;
            // 
            // dtpEventEnd
            // 
            this.dtpEventEnd.CustomFormat = "dd/MM/yyyy HH:mm:ss ";
            this.dtpEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventEnd.Location = new System.Drawing.Point(11, 117);
            this.dtpEventEnd.Name = "dtpEventEnd";
            this.dtpEventEnd.Size = new System.Drawing.Size(221, 20);
            this.dtpEventEnd.TabIndex = 31;
            this.dtpEventEnd.Enter += new System.EventHandler(this.dtpEventEnd_Enter);
            // 
            // dtpEventStart
            // 
            this.dtpEventStart.CustomFormat = "dd/MM/yyyy HH:mm:ss ";
            this.dtpEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventStart.Location = new System.Drawing.Point(11, 80);
            this.dtpEventStart.Name = "dtpEventStart";
            this.dtpEventStart.Size = new System.Drawing.Size(221, 20);
            this.dtpEventStart.TabIndex = 30;
            this.dtpEventStart.ValueChanged += new System.EventHandler(this.dtpEventStart_ValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Depth = 0;
            this.txtDescription.Hint = "";
            this.txtDescription.Location = new System.Drawing.Point(11, 263);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(221, 23);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.TabStop = false;
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // txtEventName
            // 
            this.txtEventName.Depth = 0;
            this.txtEventName.Hint = "";
            this.txtEventName.Location = new System.Drawing.Point(11, 7);
            this.txtEventName.MaxLength = 32767;
            this.txtEventName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.PasswordChar = '\0';
            this.txtEventName.SelectedText = "";
            this.txtEventName.SelectionLength = 0;
            this.txtEventName.SelectionStart = 0;
            this.txtEventName.Size = new System.Drawing.Size(221, 23);
            this.txtEventName.TabIndex = 13;
            this.txtEventName.TabStop = false;
            this.txtEventName.UseSystemPasswordChar = false;
            this.txtEventName.Click += new System.EventHandler(this.txtEventName_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.database1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(-6, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 590);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BackgroundImage = global::MyShedule.Properties.Resources.RegisterTop;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(-3, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 102);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "EVENT";
            // 
            // AddEventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 750);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEventView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Schedule";
            this.Load += new System.EventHandler(this.AddEventView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEventName;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btnDelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddEvent;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Database1DataSet database1DataSet;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.RadioButton rbRecurringMonthly;
        private System.Windows.Forms.RadioButton rbOneOff;
        private System.Windows.Forms.DateTimePicker dtpEventEnd;
        private System.Windows.Forms.DateTimePicker dtpEventStart;
        private System.Windows.Forms.ComboBox cBCC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAppointment;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.Panel panelInputs;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocation;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Button btnAddReminder;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContact;
        private System.Windows.Forms.RadioButton rbRecurringYearly;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialCheckBox cbStatus;
    }
}