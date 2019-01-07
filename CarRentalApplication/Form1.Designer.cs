namespace CarRentalApplication
{
    partial class Form1
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
            System.Windows.Forms.Label carIDLabel;
            System.Windows.Forms.Label registration_NumberLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label engine_SizeLabel;
            System.Windows.Forms.Label colourLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label sold_InsuranceLabel;
            System.Windows.Forms.Label areaLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label license_NoLabel;
            System.Windows.Forms.Label issue_DateLabel;
            System.Windows.Forms.Label issued_byLabel;
            System.Windows.Forms.Label class_IDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label daily_RateLabel;
            System.Windows.Forms.Label days_RentedLabel;
            System.Windows.Forms.Label discount_RateLabel;
            System.Windows.Forms.Label total_CostLabel;
            System.Windows.Forms.Label customerLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label lastnameLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label miles_beforeLabel;
            System.Windows.Forms.Label mile_AfterLabel;
            System.Windows.Forms.Label styleLabel;
            System.Windows.Forms.Label registered_YearLabel;
            System.Windows.Forms.Label customer_IDLabel;
            System.Windows.Forms.Label number_of_DaysLabel;
            System.Windows.Forms.Label invoice_IDLabel;
            System.Windows.Forms.Label air_ConditionLabel;
            System.Windows.Forms.Label automaticLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.automaticCheckBox = new System.Windows.Forms.CheckBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet = new CarRentalApplication.myDatabaseDataSet();
            this.air_ConditionCheckBox = new System.Windows.Forms.CheckBox();
            this.daily_RateTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.class_IDTextBox = new System.Windows.Forms.TextBox();
            this.registered_YearTextBox = new System.Windows.Forms.TextBox();
            this.styleTextBox = new System.Windows.Forms.TextBox();
            this.mile_AfterTextBox = new System.Windows.Forms.TextBox();
            this.miles_beforeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_CostTextBox = new System.Windows.Forms.TextBox();
            this.discount_RateTextBox = new System.Windows.Forms.TextBox();
            this.days_RentedTextBox = new System.Windows.Forms.TextBox();
            this.invoice_IDTextBox = new System.Windows.Forms.TextBox();
            this.customer_IDTextBox = new System.Windows.Forms.TextBox();
            this.number_of_DaysTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.license_NoTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.issued_byTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.issue_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.carIDTextBox = new System.Windows.Forms.TextBox();
            this.registration_NumberTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.tableTableAdapter = new CarRentalApplication.myDatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new CarRentalApplication.myDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.engine_SizeTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.sold_InsuranceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtReceipt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            carIDLabel = new System.Windows.Forms.Label();
            registration_NumberLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            engine_SizeLabel = new System.Windows.Forms.Label();
            colourLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            sold_InsuranceLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            license_NoLabel = new System.Windows.Forms.Label();
            issue_DateLabel = new System.Windows.Forms.Label();
            issued_byLabel = new System.Windows.Forms.Label();
            class_IDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            daily_RateLabel = new System.Windows.Forms.Label();
            days_RentedLabel = new System.Windows.Forms.Label();
            discount_RateLabel = new System.Windows.Forms.Label();
            total_CostLabel = new System.Windows.Forms.Label();
            customerLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            lastnameLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            miles_beforeLabel = new System.Windows.Forms.Label();
            mile_AfterLabel = new System.Windows.Forms.Label();
            styleLabel = new System.Windows.Forms.Label();
            registered_YearLabel = new System.Windows.Forms.Label();
            customer_IDLabel = new System.Windows.Forms.Label();
            number_of_DaysLabel = new System.Windows.Forms.Label();
            invoice_IDLabel = new System.Windows.Forms.Label();
            air_ConditionLabel = new System.Windows.Forms.Label();
            automaticLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // carIDLabel
            // 
            carIDLabel.AutoSize = true;
            carIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            carIDLabel.Location = new System.Drawing.Point(6, 16);
            carIDLabel.Name = "carIDLabel";
            carIDLabel.Size = new System.Drawing.Size(59, 20);
            carIDLabel.TabIndex = 0;
            carIDLabel.Text = "Car ID:";
            // 
            // registration_NumberLabel
            // 
            registration_NumberLabel.AutoSize = true;
            registration_NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            registration_NumberLabel.Location = new System.Drawing.Point(6, 42);
            registration_NumberLabel.Name = "registration_NumberLabel";
            registration_NumberLabel.Size = new System.Drawing.Size(159, 20);
            registration_NumberLabel.TabIndex = 2;
            registration_NumberLabel.Text = "Registration Number:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            makeLabel.Location = new System.Drawing.Point(6, 68);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(52, 20);
            makeLabel.TabIndex = 4;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modelLabel.Location = new System.Drawing.Point(6, 94);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(56, 20);
            modelLabel.TabIndex = 6;
            modelLabel.Text = "Model:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(6, 120);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(48, 20);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price:";
            // 
            // engine_SizeLabel
            // 
            engine_SizeLabel.AutoSize = true;
            engine_SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            engine_SizeLabel.Location = new System.Drawing.Point(6, 23);
            engine_SizeLabel.Name = "engine_SizeLabel";
            engine_SizeLabel.Size = new System.Drawing.Size(98, 20);
            engine_SizeLabel.TabIndex = 10;
            engine_SizeLabel.Text = "Engine Size:";
            // 
            // colourLabel
            // 
            colourLabel.AutoSize = true;
            colourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            colourLabel.Location = new System.Drawing.Point(6, 49);
            colourLabel.Name = "colourLabel";
            colourLabel.Size = new System.Drawing.Size(59, 20);
            colourLabel.TabIndex = 12;
            colourLabel.Text = "Colour:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            yearLabel.Location = new System.Drawing.Point(6, 75);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(47, 20);
            yearLabel.TabIndex = 14;
            yearLabel.Text = "Year:";
            // 
            // sold_InsuranceLabel
            // 
            sold_InsuranceLabel.AutoSize = true;
            sold_InsuranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sold_InsuranceLabel.Location = new System.Drawing.Point(6, 101);
            sold_InsuranceLabel.Name = "sold_InsuranceLabel";
            sold_InsuranceLabel.Size = new System.Drawing.Size(120, 20);
            sold_InsuranceLabel.TabIndex = 16;
            sold_InsuranceLabel.Text = "Sold Insurance:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            areaLabel.Location = new System.Drawing.Point(338, 15);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(47, 20);
            areaLabel.TabIndex = 18;
            areaLabel.Text = "Area:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            postcodeLabel.Location = new System.Drawing.Point(338, 41);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(80, 20);
            postcodeLabel.TabIndex = 20;
            postcodeLabel.Text = "Postcode:";
            // 
            // license_NoLabel
            // 
            license_NoLabel.AutoSize = true;
            license_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            license_NoLabel.Location = new System.Drawing.Point(338, 67);
            license_NoLabel.Name = "license_NoLabel";
            license_NoLabel.Size = new System.Drawing.Size(92, 20);
            license_NoLabel.TabIndex = 22;
            license_NoLabel.Text = "License No:";
            // 
            // issue_DateLabel
            // 
            issue_DateLabel.AutoSize = true;
            issue_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issue_DateLabel.Location = new System.Drawing.Point(338, 94);
            issue_DateLabel.Name = "issue_DateLabel";
            issue_DateLabel.Size = new System.Drawing.Size(91, 20);
            issue_DateLabel.TabIndex = 24;
            issue_DateLabel.Text = "Issue Date:";
            // 
            // issued_byLabel
            // 
            issued_byLabel.AutoSize = true;
            issued_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issued_byLabel.Location = new System.Drawing.Point(338, 119);
            issued_byLabel.Name = "issued_byLabel";
            issued_byLabel.Size = new System.Drawing.Size(81, 20);
            issued_byLabel.TabIndex = 26;
            issued_byLabel.Text = "Issued by:";
            // 
            // class_IDLabel
            // 
            class_IDLabel.AutoSize = true;
            class_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            class_IDLabel.Location = new System.Drawing.Point(338, 68);
            class_IDLabel.Name = "class_IDLabel";
            class_IDLabel.Size = new System.Drawing.Size(73, 20);
            class_IDLabel.TabIndex = 32;
            class_IDLabel.Text = "Class ID:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(338, 94);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 34;
            descriptionLabel.Text = "Description:";
            // 
            // daily_RateLabel
            // 
            daily_RateLabel.AutoSize = true;
            daily_RateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daily_RateLabel.Location = new System.Drawing.Point(338, 120);
            daily_RateLabel.Name = "daily_RateLabel";
            daily_RateLabel.Size = new System.Drawing.Size(86, 20);
            daily_RateLabel.TabIndex = 36;
            daily_RateLabel.Text = "Daily Rate:";
            // 
            // days_RentedLabel
            // 
            days_RentedLabel.AutoSize = true;
            days_RentedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            days_RentedLabel.Location = new System.Drawing.Point(338, 30);
            days_RentedLabel.Name = "days_RentedLabel";
            days_RentedLabel.Size = new System.Drawing.Size(106, 20);
            days_RentedLabel.TabIndex = 38;
            days_RentedLabel.Text = "Days Rented:";
            // 
            // discount_RateLabel
            // 
            discount_RateLabel.AutoSize = true;
            discount_RateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            discount_RateLabel.Location = new System.Drawing.Point(338, 56);
            discount_RateLabel.Name = "discount_RateLabel";
            discount_RateLabel.Size = new System.Drawing.Size(115, 20);
            discount_RateLabel.TabIndex = 40;
            discount_RateLabel.Text = "Discount Rate:";
            // 
            // total_CostLabel
            // 
            total_CostLabel.AutoSize = true;
            total_CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_CostLabel.Location = new System.Drawing.Point(338, 82);
            total_CostLabel.Name = "total_CostLabel";
            total_CostLabel.Size = new System.Drawing.Size(85, 20);
            total_CostLabel.TabIndex = 42;
            total_CostLabel.Text = "Total Cost:";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerLabel.Location = new System.Drawing.Point(6, 24);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new System.Drawing.Size(82, 20);
            customerLabel.TabIndex = 44;
            customerLabel.Text = "Customer:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(6, 50);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 20);
            titleLabel.TabIndex = 46;
            titleLabel.Text = "Title:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstnameLabel.Location = new System.Drawing.Point(6, 76);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(84, 20);
            firstnameLabel.TabIndex = 48;
            firstnameLabel.Text = "Firstname:";
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastnameLabel.Location = new System.Drawing.Point(6, 102);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new System.Drawing.Size(84, 20);
            lastnameLabel.TabIndex = 50;
            lastnameLabel.Text = "Lastname:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            streetLabel.Location = new System.Drawing.Point(6, 128);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(57, 20);
            streetLabel.TabIndex = 52;
            streetLabel.Text = "Street:";
            // 
            // miles_beforeLabel
            // 
            miles_beforeLabel.AutoSize = true;
            miles_beforeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            miles_beforeLabel.Location = new System.Drawing.Point(6, 30);
            miles_beforeLabel.Name = "miles_beforeLabel";
            miles_beforeLabel.Size = new System.Drawing.Size(99, 20);
            miles_beforeLabel.TabIndex = 54;
            miles_beforeLabel.Text = "Miles before:";
            // 
            // mile_AfterLabel
            // 
            mile_AfterLabel.AutoSize = true;
            mile_AfterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mile_AfterLabel.Location = new System.Drawing.Point(6, 56);
            mile_AfterLabel.Name = "mile_AfterLabel";
            mile_AfterLabel.Size = new System.Drawing.Size(80, 20);
            mile_AfterLabel.TabIndex = 56;
            mile_AfterLabel.Text = "Mile After:";
            // 
            // styleLabel
            // 
            styleLabel.AutoSize = true;
            styleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            styleLabel.Location = new System.Drawing.Point(6, 82);
            styleLabel.Name = "styleLabel";
            styleLabel.Size = new System.Drawing.Size(48, 20);
            styleLabel.TabIndex = 58;
            styleLabel.Text = "Style:";
            // 
            // registered_YearLabel
            // 
            registered_YearLabel.AutoSize = true;
            registered_YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            registered_YearLabel.Location = new System.Drawing.Point(6, 108);
            registered_YearLabel.Name = "registered_YearLabel";
            registered_YearLabel.Size = new System.Drawing.Size(129, 20);
            registered_YearLabel.TabIndex = 60;
            registered_YearLabel.Text = "Registered Year:";
            // 
            // customer_IDLabel
            // 
            customer_IDLabel.AutoSize = true;
            customer_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customer_IDLabel.Location = new System.Drawing.Point(6, 33);
            customer_IDLabel.Name = "customer_IDLabel";
            customer_IDLabel.Size = new System.Drawing.Size(103, 20);
            customer_IDLabel.TabIndex = 62;
            customer_IDLabel.Text = "Customer ID:";
            // 
            // number_of_DaysLabel
            // 
            number_of_DaysLabel.AutoSize = true;
            number_of_DaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            number_of_DaysLabel.Location = new System.Drawing.Point(6, 59);
            number_of_DaysLabel.Name = "number_of_DaysLabel";
            number_of_DaysLabel.Size = new System.Drawing.Size(127, 20);
            number_of_DaysLabel.TabIndex = 64;
            number_of_DaysLabel.Text = "Number of Days:";
            // 
            // invoice_IDLabel
            // 
            invoice_IDLabel.AutoSize = true;
            invoice_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoice_IDLabel.Location = new System.Drawing.Point(6, 85);
            invoice_IDLabel.Name = "invoice_IDLabel";
            invoice_IDLabel.Size = new System.Drawing.Size(84, 20);
            invoice_IDLabel.TabIndex = 66;
            invoice_IDLabel.Text = "Invoice ID:";
            // 
            // air_ConditionLabel
            // 
            air_ConditionLabel.AutoSize = true;
            air_ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            air_ConditionLabel.Location = new System.Drawing.Point(338, 16);
            air_ConditionLabel.Name = "air_ConditionLabel";
            air_ConditionLabel.Size = new System.Drawing.Size(103, 20);
            air_ConditionLabel.TabIndex = 61;
            air_ConditionLabel.Text = "Air Condition:";
            // 
            // automaticLabel
            // 
            automaticLabel.AutoSize = true;
            automaticLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            automaticLabel.ForeColor = System.Drawing.Color.Maroon;
            automaticLabel.Location = new System.Drawing.Point(338, 43);
            automaticLabel.Name = "automaticLabel";
            automaticLabel.Size = new System.Drawing.Size(85, 20);
            automaticLabel.TabIndex = 62;
            automaticLabel.Text = "Automatic:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(automaticLabel);
            this.groupBox1.Controls.Add(this.automaticCheckBox);
            this.groupBox1.Controls.Add(air_ConditionLabel);
            this.groupBox1.Controls.Add(this.air_ConditionCheckBox);
            this.groupBox1.Controls.Add(this.daily_RateTextBox);
            this.groupBox1.Controls.Add(daily_RateLabel);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(descriptionLabel);
            this.groupBox1.Controls.Add(this.class_IDTextBox);
            this.groupBox1.Controls.Add(miles_beforeLabel);
            this.groupBox1.Controls.Add(this.registered_YearTextBox);
            this.groupBox1.Controls.Add(class_IDLabel);
            this.groupBox1.Controls.Add(registered_YearLabel);
            this.groupBox1.Controls.Add(this.styleTextBox);
            this.groupBox1.Controls.Add(styleLabel);
            this.groupBox1.Controls.Add(this.mile_AfterTextBox);
            this.groupBox1.Controls.Add(this.miles_beforeTextBox);
            this.groupBox1.Controls.Add(mile_AfterLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 157);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // automaticCheckBox
            // 
            this.automaticCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Automatic", true));
            this.automaticCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automaticCheckBox.Location = new System.Drawing.Point(450, 38);
            this.automaticCheckBox.Name = "automaticCheckBox";
            this.automaticCheckBox.Size = new System.Drawing.Size(104, 24);
            this.automaticCheckBox.TabIndex = 63;
            this.automaticCheckBox.Text = "checkBox1";
            this.automaticCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "myDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // air_ConditionCheckBox
            // 
            this.air_ConditionCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tableBindingSource, "Air Condition", true));
            this.air_ConditionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.air_ConditionCheckBox.Location = new System.Drawing.Point(450, 11);
            this.air_ConditionCheckBox.Name = "air_ConditionCheckBox";
            this.air_ConditionCheckBox.Size = new System.Drawing.Size(104, 24);
            this.air_ConditionCheckBox.TabIndex = 62;
            this.air_ConditionCheckBox.Text = "checkBox1";
            this.air_ConditionCheckBox.UseVisualStyleBackColor = true;
            // 
            // daily_RateTextBox
            // 
            this.daily_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Daily Rate", true));
            this.daily_RateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daily_RateTextBox.Location = new System.Drawing.Point(450, 117);
            this.daily_RateTextBox.Name = "daily_RateTextBox";
            this.daily_RateTextBox.Size = new System.Drawing.Size(200, 26);
            this.daily_RateTextBox.TabIndex = 37;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(450, 91);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 26);
            this.descriptionTextBox.TabIndex = 35;
            // 
            // class_IDTextBox
            // 
            this.class_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Class ID", true));
            this.class_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_IDTextBox.Location = new System.Drawing.Point(450, 65);
            this.class_IDTextBox.Name = "class_IDTextBox";
            this.class_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.class_IDTextBox.TabIndex = 33;
            // 
            // registered_YearTextBox
            // 
            this.registered_YearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Registered Year", true));
            this.registered_YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registered_YearTextBox.Location = new System.Drawing.Point(132, 102);
            this.registered_YearTextBox.Name = "registered_YearTextBox";
            this.registered_YearTextBox.Size = new System.Drawing.Size(200, 26);
            this.registered_YearTextBox.TabIndex = 61;
            // 
            // styleTextBox
            // 
            this.styleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Style", true));
            this.styleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styleTextBox.Location = new System.Drawing.Point(132, 76);
            this.styleTextBox.Name = "styleTextBox";
            this.styleTextBox.Size = new System.Drawing.Size(200, 26);
            this.styleTextBox.TabIndex = 59;
            // 
            // mile_AfterTextBox
            // 
            this.mile_AfterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Mile After", true));
            this.mile_AfterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mile_AfterTextBox.Location = new System.Drawing.Point(132, 50);
            this.mile_AfterTextBox.Name = "mile_AfterTextBox";
            this.mile_AfterTextBox.Size = new System.Drawing.Size(200, 26);
            this.mile_AfterTextBox.TabIndex = 57;
            // 
            // miles_beforeTextBox
            // 
            this.miles_beforeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Miles before", true));
            this.miles_beforeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miles_beforeTextBox.Location = new System.Drawing.Point(132, 24);
            this.miles_beforeTextBox.Name = "miles_beforeTextBox";
            this.miles_beforeTextBox.Size = new System.Drawing.Size(200, 26);
            this.miles_beforeTextBox.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(days_RentedLabel);
            this.groupBox2.Controls.Add(this.total_CostTextBox);
            this.groupBox2.Controls.Add(total_CostLabel);
            this.groupBox2.Controls.Add(this.discount_RateTextBox);
            this.groupBox2.Controls.Add(discount_RateLabel);
            this.groupBox2.Controls.Add(this.days_RentedTextBox);
            this.groupBox2.Controls.Add(customer_IDLabel);
            this.groupBox2.Controls.Add(this.invoice_IDTextBox);
            this.groupBox2.Controls.Add(this.customer_IDTextBox);
            this.groupBox2.Controls.Add(invoice_IDLabel);
            this.groupBox2.Controls.Add(number_of_DaysLabel);
            this.groupBox2.Controls.Add(this.number_of_DaysTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 481);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // total_CostTextBox
            // 
            this.total_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Total Cost", true));
            this.total_CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_CostTextBox.Location = new System.Drawing.Point(450, 79);
            this.total_CostTextBox.Name = "total_CostTextBox";
            this.total_CostTextBox.Size = new System.Drawing.Size(200, 26);
            this.total_CostTextBox.TabIndex = 43;
            // 
            // discount_RateTextBox
            // 
            this.discount_RateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Discount Rate", true));
            this.discount_RateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_RateTextBox.Location = new System.Drawing.Point(450, 53);
            this.discount_RateTextBox.Name = "discount_RateTextBox";
            this.discount_RateTextBox.Size = new System.Drawing.Size(200, 26);
            this.discount_RateTextBox.TabIndex = 41;
            // 
            // days_RentedTextBox
            // 
            this.days_RentedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Days Rented", true));
            this.days_RentedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_RentedTextBox.Location = new System.Drawing.Point(450, 27);
            this.days_RentedTextBox.Name = "days_RentedTextBox";
            this.days_RentedTextBox.Size = new System.Drawing.Size(200, 26);
            this.days_RentedTextBox.TabIndex = 39;
            // 
            // invoice_IDTextBox
            // 
            this.invoice_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Invoice ID", true));
            this.invoice_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_IDTextBox.Location = new System.Drawing.Point(132, 82);
            this.invoice_IDTextBox.Name = "invoice_IDTextBox";
            this.invoice_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.invoice_IDTextBox.TabIndex = 67;
            // 
            // customer_IDTextBox
            // 
            this.customer_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Customer ID", true));
            this.customer_IDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_IDTextBox.Location = new System.Drawing.Point(132, 30);
            this.customer_IDTextBox.Name = "customer_IDTextBox";
            this.customer_IDTextBox.Size = new System.Drawing.Size(200, 26);
            this.customer_IDTextBox.TabIndex = 63;
            // 
            // number_of_DaysTextBox
            // 
            this.number_of_DaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Number of Days", true));
            this.number_of_DaysTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_of_DaysTextBox.Location = new System.Drawing.Point(132, 56);
            this.number_of_DaysTextBox.Name = "number_of_DaysTextBox";
            this.number_of_DaysTextBox.Size = new System.Drawing.Size(200, 26);
            this.number_of_DaysTextBox.TabIndex = 65;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(areaLabel);
            this.groupBox3.Controls.Add(this.areaTextBox);
            this.groupBox3.Controls.Add(postcodeLabel);
            this.groupBox3.Controls.Add(this.postcodeTextBox);
            this.groupBox3.Controls.Add(license_NoLabel);
            this.groupBox3.Controls.Add(this.license_NoTextBox);
            this.groupBox3.Controls.Add(customerLabel);
            this.groupBox3.Controls.Add(this.streetTextBox);
            this.groupBox3.Controls.Add(issue_DateLabel);
            this.groupBox3.Controls.Add(streetLabel);
            this.groupBox3.Controls.Add(this.issued_byTextBox);
            this.groupBox3.Controls.Add(this.lastnameTextBox);
            this.groupBox3.Controls.Add(this.issue_DateDateTimePicker);
            this.groupBox3.Controls.Add(lastnameLabel);
            this.groupBox3.Controls.Add(issued_byLabel);
            this.groupBox3.Controls.Add(this.firstnameTextBox);
            this.groupBox3.Controls.Add(this.customerTextBox);
            this.groupBox3.Controls.Add(firstnameLabel);
            this.groupBox3.Controls.Add(titleLabel);
            this.groupBox3.Controls.Add(this.titleTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 151);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Area", true));
            this.areaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaTextBox.Location = new System.Drawing.Point(450, 12);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(200, 26);
            this.areaTextBox.TabIndex = 19;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Postcode", true));
            this.postcodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postcodeTextBox.Location = new System.Drawing.Point(450, 38);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(200, 26);
            this.postcodeTextBox.TabIndex = 21;
            // 
            // license_NoTextBox
            // 
            this.license_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "License No", true));
            this.license_NoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.license_NoTextBox.Location = new System.Drawing.Point(450, 64);
            this.license_NoTextBox.Name = "license_NoTextBox";
            this.license_NoTextBox.Size = new System.Drawing.Size(200, 26);
            this.license_NoTextBox.TabIndex = 23;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextBox.Location = new System.Drawing.Point(132, 116);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 26);
            this.streetTextBox.TabIndex = 53;
            // 
            // issued_byTextBox
            // 
            this.issued_byTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Issued by", true));
            this.issued_byTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_byTextBox.Location = new System.Drawing.Point(450, 116);
            this.issued_byTextBox.Name = "issued_byTextBox";
            this.issued_byTextBox.Size = new System.Drawing.Size(200, 26);
            this.issued_byTextBox.TabIndex = 27;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Lastname", true));
            this.lastnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameTextBox.Location = new System.Drawing.Point(132, 90);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(200, 26);
            this.lastnameTextBox.TabIndex = 51;
            // 
            // issue_DateDateTimePicker
            // 
            this.issue_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tableBindingSource, "Issue Date", true));
            this.issue_DateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_DateDateTimePicker.Location = new System.Drawing.Point(450, 90);
            this.issue_DateDateTimePicker.Name = "issue_DateDateTimePicker";
            this.issue_DateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.issue_DateDateTimePicker.TabIndex = 25;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Firstname", true));
            this.firstnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnameTextBox.Location = new System.Drawing.Point(132, 64);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(200, 26);
            this.firstnameTextBox.TabIndex = 49;
            // 
            // customerTextBox
            // 
            this.customerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Customer", true));
            this.customerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerTextBox.Location = new System.Drawing.Point(132, 12);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(200, 26);
            this.customerTextBox.TabIndex = 45;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(132, 38);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 26);
            this.titleTextBox.TabIndex = 47;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(carIDLabel);
            this.groupBox4.Controls.Add(this.carIDTextBox);
            this.groupBox4.Controls.Add(registration_NumberLabel);
            this.groupBox4.Controls.Add(this.registration_NumberTextBox);
            this.groupBox4.Controls.Add(makeLabel);
            this.groupBox4.Controls.Add(this.makeTextBox);
            this.groupBox4.Controls.Add(modelLabel);
            this.groupBox4.Controls.Add(this.modelTextBox);
            this.groupBox4.Controls.Add(priceLabel);
            this.groupBox4.Controls.Add(this.priceTextBox);
            this.groupBox4.Location = new System.Drawing.Point(279, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 148);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // carIDTextBox
            // 
            this.carIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "CarID", true));
            this.carIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carIDTextBox.Location = new System.Drawing.Point(183, 13);
            this.carIDTextBox.Name = "carIDTextBox";
            this.carIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.carIDTextBox.TabIndex = 1;
            // 
            // registration_NumberTextBox
            // 
            this.registration_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Registration Number", true));
            this.registration_NumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_NumberTextBox.Location = new System.Drawing.Point(183, 39);
            this.registration_NumberTextBox.Name = "registration_NumberTextBox";
            this.registration_NumberTextBox.Size = new System.Drawing.Size(200, 26);
            this.registration_NumberTextBox.TabIndex = 3;
            // 
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Make", true));
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeTextBox.Location = new System.Drawing.Point(183, 65);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 26);
            this.makeTextBox.TabIndex = 5;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Model", true));
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(183, 91);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 26);
            this.modelTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(183, 117);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 26);
            this.priceTextBox.TabIndex = 9;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarRentalApplication.myDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1333, 25);
            this.tableBindingNavigator.TabIndex = 5;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // engine_SizeTextBox
            // 
            this.engine_SizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Engine Size", true));
            this.engine_SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engine_SizeTextBox.Location = new System.Drawing.Point(127, 17);
            this.engine_SizeTextBox.Name = "engine_SizeTextBox";
            this.engine_SizeTextBox.Size = new System.Drawing.Size(200, 26);
            this.engine_SizeTextBox.TabIndex = 11;
            // 
            // colourTextBox
            // 
            this.colourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Colour", true));
            this.colourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colourTextBox.Location = new System.Drawing.Point(127, 43);
            this.colourTextBox.Name = "colourTextBox";
            this.colourTextBox.Size = new System.Drawing.Size(200, 26);
            this.colourTextBox.TabIndex = 13;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Year", true));
            this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearTextBox.Location = new System.Drawing.Point(127, 69);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(200, 26);
            this.yearTextBox.TabIndex = 15;
            // 
            // sold_InsuranceTextBox
            // 
            this.sold_InsuranceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Sold Insurance", true));
            this.sold_InsuranceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_InsuranceTextBox.Location = new System.Drawing.Point(127, 95);
            this.sold_InsuranceTextBox.Name = "sold_InsuranceTextBox";
            this.sold_InsuranceTextBox.Size = new System.Drawing.Size(200, 26);
            this.sold_InsuranceTextBox.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(engine_SizeLabel);
            this.groupBox5.Controls.Add(this.sold_InsuranceTextBox);
            this.groupBox5.Controls.Add(sold_InsuranceLabel);
            this.groupBox5.Controls.Add(this.yearTextBox);
            this.groupBox5.Controls.Add(yearLabel);
            this.groupBox5.Controls.Add(this.colourTextBox);
            this.groupBox5.Controls.Add(colourLabel);
            this.groupBox5.Controls.Add(this.engine_SizeTextBox);
            this.groupBox5.Location = new System.Drawing.Point(689, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(337, 148);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(689, 229);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 361);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.txtReceipt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reciept";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtReceipt
            // 
            this.txtReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceipt.Location = new System.Drawing.Point(0, 0);
            this.txtReceipt.Multiline = true;
            this.txtReceipt.Name = "txtReceipt";
            this.txtReceipt.Size = new System.Drawing.Size(636, 339);
            this.txtReceipt.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Database";
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(3, 6);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(646, 382);
            this.tableDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CarID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Registration Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Registration Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn3.HeaderText = "Make";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn4.HeaderText = "Model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn5.HeaderText = "Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Engine Size";
            this.dataGridViewTextBoxColumn6.HeaderText = "Engine Size";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Colour";
            this.dataGridViewTextBoxColumn7.HeaderText = "Colour";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn8.HeaderText = "Year";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sold Insurance";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sold Insurance";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn10.HeaderText = "Area";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Postcode";
            this.dataGridViewTextBoxColumn11.HeaderText = "Postcode";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "License No";
            this.dataGridViewTextBoxColumn12.HeaderText = "License No";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Issue Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Issue Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Issued by";
            this.dataGridViewTextBoxColumn14.HeaderText = "Issued by";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Air Condition";
            this.dataGridViewTextBoxColumn15.HeaderText = "Air Condition";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Automatic";
            this.dataGridViewTextBoxColumn16.HeaderText = "Automatic";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Class ID";
            this.dataGridViewTextBoxColumn17.HeaderText = "Class ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn18.HeaderText = "Description";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Daily Rate";
            this.dataGridViewTextBoxColumn19.HeaderText = "Daily Rate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Days Rented";
            this.dataGridViewTextBoxColumn20.HeaderText = "Days Rented";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Discount Rate";
            this.dataGridViewTextBoxColumn21.HeaderText = "Discount Rate";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Total Cost";
            this.dataGridViewTextBoxColumn22.HeaderText = "Total Cost";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn23.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn24.HeaderText = "Title";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn25.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "Lastname";
            this.dataGridViewTextBoxColumn26.HeaderText = "Lastname";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn27.HeaderText = "Street";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "Miles before";
            this.dataGridViewTextBoxColumn28.HeaderText = "Miles before";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Mile After";
            this.dataGridViewTextBoxColumn29.HeaderText = "Mile After";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Style";
            this.dataGridViewTextBoxColumn30.HeaderText = "Style";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "Registered Year";
            this.dataGridViewTextBoxColumn31.HeaderText = "Registered Year";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "Customer ID";
            this.dataGridViewTextBoxColumn32.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "Number of Days";
            this.dataGridViewTextBoxColumn33.HeaderText = "Number of Days";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "Invoice ID";
            this.dataGridViewTextBoxColumn34.HeaderText = "Invoice ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(6, 20);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 38);
            this.btnTotal.TabIndex = 8;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(87, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(184, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(87, 77);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 37);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(6, 76);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 37);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(184, 75);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 38);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(6, 128);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 37);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(87, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 37);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(203, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLast);
            this.groupBox6.Controls.Add(this.btnTotal);
            this.groupBox6.Controls.Add(this.btnReset);
            this.groupBox6.Controls.Add(this.btnAdd);
            this.groupBox6.Controls.Add(this.btnExit);
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Controls.Add(this.btnPrevious);
            this.groupBox6.Controls.Add(this.btnFirst);
            this.groupBox6.Controls.Add(this.btnNext);
            this.groupBox6.Location = new System.Drawing.Point(1032, 28);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(287, 195);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(816, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Print Receipt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1333, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tableBindingNavigator);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private myDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private myDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private myDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox daily_RateTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox class_IDTextBox;
        private System.Windows.Forms.TextBox registered_YearTextBox;
        private System.Windows.Forms.TextBox styleTextBox;
        private System.Windows.Forms.TextBox mile_AfterTextBox;
        private System.Windows.Forms.TextBox miles_beforeTextBox;
        private System.Windows.Forms.TextBox total_CostTextBox;
        private System.Windows.Forms.TextBox discount_RateTextBox;
        private System.Windows.Forms.TextBox days_RentedTextBox;
        private System.Windows.Forms.TextBox invoice_IDTextBox;
        private System.Windows.Forms.TextBox customer_IDTextBox;
        private System.Windows.Forms.TextBox number_of_DaysTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox license_NoTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox issued_byTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.DateTimePicker issue_DateDateTimePicker;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox carIDTextBox;
        private System.Windows.Forms.TextBox registration_NumberTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox engine_SizeTextBox;
        private System.Windows.Forms.TextBox colourTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox sold_InsuranceTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox automaticCheckBox;
        private System.Windows.Forms.CheckBox air_ConditionCheckBox;
        private System.Windows.Forms.TextBox txtReceipt;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

