namespace Trojan_Travels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            btnSupplierDelete = new Button();
            txtEditSupplierId = new TextBox();
            btnEditSupplier = new Button();
            label5 = new Label();
            btnAddSupplier = new Button();
            txtSupplierName = new TextBox();
            label4 = new Label();
            btnEditPackage = new Button();
            btnAddSupplierProduct = new Button();
            groupBox3 = new GroupBox();
            btnPackageDelete = new Button();
            txtProductSupplierId = new TextBox();
            btnAddPackage = new Button();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtPackageCommission = new TextBox();
            label6 = new Label();
            txtPackageBasePrice = new TextBox();
            label7 = new Label();
            txtPackageDescription = new TextBox();
            label8 = new Label();
            txtPackageName = new TextBox();
            label2 = new Label();
            btnEditSupplierProduct = new Button();
            groupBox4 = new GroupBox();
            btnSPDelete = new Button();
            txtPSProductSupplierId = new TextBox();
            label3 = new Label();
            txtPSSupplierId = new TextBox();
            label9 = new Label();
            txtPSProductId = new TextBox();
            label10 = new Label();
            dataGVPS = new DataGridView();
            dataGVSupplier = new DataGridView();
            dataGVProduct = new DataGridView();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox1 = new GroupBox();
            btnProductDelete = new Button();
            txtEditProductId = new TextBox();
            label19 = new Label();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            label11 = new Label();
            btnMgPackages = new Button();
            btnMgPS = new Button();
            btnMgSuppliers = new Button();
            btnManageProducts = new Button();
            dataGVPackage = new DataGridView();
            btnRefresh = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(btnSupplierDelete);
            groupBox2.Controls.Add(txtEditSupplierId);
            groupBox2.Controls.Add(btnEditSupplier);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnAddSupplier);
            groupBox2.Controls.Add(txtSupplierName);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(325, 719);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(675, 198);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Suppliers";
            // 
            // btnSupplierDelete
            // 
            btnSupplierDelete.Location = new Point(572, 144);
            btnSupplierDelete.Name = "btnSupplierDelete";
            btnSupplierDelete.Size = new Size(84, 40);
            btnSupplierDelete.TabIndex = 27;
            btnSupplierDelete.Text = "Delete";
            btnSupplierDelete.UseVisualStyleBackColor = true;
            btnSupplierDelete.Click += btnSupplierDelete_Click;
            // 
            // txtEditSupplierId
            // 
            txtEditSupplierId.Location = new Point(354, 44);
            txtEditSupplierId.Name = "txtEditSupplierId";
            txtEditSupplierId.ReadOnly = true;
            txtEditSupplierId.Size = new Size(302, 34);
            txtEditSupplierId.TabIndex = 26;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(464, 146);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(81, 37);
            btnEditSupplier.TabIndex = 23;
            btnEditSupplier.Text = "Edit";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 44);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 25;
            label5.Text = "Supplier Id";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(354, 146);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(81, 37);
            btnAddSupplier.TabIndex = 21;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(354, 93);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(302, 34);
            txtSupplierName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 93);
            label4.Name = "label4";
            label4.Size = new Size(142, 28);
            label4.TabIndex = 4;
            label4.Text = "Supplier Name";
            // 
            // btnEditPackage
            // 
            btnEditPackage.Location = new Point(464, 321);
            btnEditPackage.Name = "btnEditPackage";
            btnEditPackage.Size = new Size(81, 37);
            btnEditPackage.TabIndex = 21;
            btnEditPackage.Text = "Edit";
            btnEditPackage.UseVisualStyleBackColor = true;
            btnEditPackage.Click += btnEditPackage_Click;
            // 
            // btnAddSupplierProduct
            // 
            btnAddSupplierProduct.Location = new Point(354, 175);
            btnAddSupplierProduct.Name = "btnAddSupplierProduct";
            btnAddSupplierProduct.Size = new Size(81, 37);
            btnAddSupplierProduct.TabIndex = 25;
            btnAddSupplierProduct.Text = "Add";
            btnAddSupplierProduct.UseVisualStyleBackColor = true;
            btnAddSupplierProduct.Click += btnAddSupplierProduct_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Desktop;
            groupBox3.Controls.Add(btnPackageDelete);
            groupBox3.Controls.Add(txtProductSupplierId);
            groupBox3.Controls.Add(btnEditPackage);
            groupBox3.Controls.Add(btnAddPackage);
            groupBox3.Controls.Add(dateTimePickerEndDate);
            groupBox3.Controls.Add(dateTimePickerStartDate);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtPackageCommission);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtPackageBasePrice);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtPackageDescription);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtPackageName);
            groupBox3.Controls.Add(label2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(325, 33);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(675, 368);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Packages";
            // 
            // btnPackageDelete
            // 
            btnPackageDelete.Location = new Point(572, 318);
            btnPackageDelete.Name = "btnPackageDelete";
            btnPackageDelete.Size = new Size(84, 40);
            btnPackageDelete.TabIndex = 27;
            btnPackageDelete.Text = "Delete";
            btnPackageDelete.UseVisualStyleBackColor = true;
            btnPackageDelete.Click += btnPackageDelete_Click;
            // 
            // txtProductSupplierId
            // 
            txtProductSupplierId.Location = new Point(354, 80);
            txtProductSupplierId.Name = "txtProductSupplierId";
            txtProductSupplierId.ReadOnly = true;
            txtProductSupplierId.Size = new Size(302, 34);
            txtProductSupplierId.TabIndex = 22;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Location = new Point(354, 321);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(75, 37);
            btnAddPackage.TabIndex = 20;
            btnAddPackage.Text = "Add";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(354, 156);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(302, 34);
            dateTimePickerEndDate.TabIndex = 19;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(354, 118);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(302, 34);
            dateTimePickerStartDate.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 86);
            label1.Name = "label1";
            label1.Size = new Size(184, 28);
            label1.TabIndex = 17;
            label1.Text = "Prpduct_Supplier Id";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 239);
            label12.Name = "label12";
            label12.Size = new Size(202, 28);
            label12.TabIndex = 15;
            label12.Text = "Package Base Price ($)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 201);
            label13.Name = "label13";
            label13.Size = new Size(188, 28);
            label13.TabIndex = 14;
            label13.Text = "Package Description";
            // 
            // txtPackageCommission
            // 
            txtPackageCommission.Location = new Point(354, 270);
            txtPackageCommission.Name = "txtPackageCommission";
            txtPackageCommission.Size = new Size(302, 34);
            txtPackageCommission.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 279);
            label6.Name = "label6";
            label6.Size = new Size(293, 28);
            label6.TabIndex = 12;
            label6.Text = "Package Agency Commission ($)";
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(354, 232);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(302, 34);
            txtPackageBasePrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 162);
            label7.Name = "label7";
            label7.Size = new Size(167, 28);
            label7.TabIndex = 10;
            label7.Text = "Package End Date";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(354, 194);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(302, 34);
            txtPackageDescription.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 124);
            label8.Name = "label8";
            label8.Size = new Size(175, 28);
            label8.TabIndex = 8;
            label8.Text = "Package Start Date";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(354, 42);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(302, 34);
            txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 42);
            label2.Name = "label2";
            label2.Size = new Size(140, 28);
            label2.TabIndex = 0;
            label2.Text = "Package Name";
            // 
            // btnEditSupplierProduct
            // 
            btnEditSupplierProduct.Location = new Point(464, 175);
            btnEditSupplierProduct.Name = "btnEditSupplierProduct";
            btnEditSupplierProduct.Size = new Size(81, 37);
            btnEditSupplierProduct.TabIndex = 22;
            btnEditSupplierProduct.Text = "Edit";
            btnEditSupplierProduct.UseVisualStyleBackColor = true;
            btnEditSupplierProduct.Click += btnEditSupplierProduct_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.MenuHighlight;
            groupBox4.Controls.Add(btnSPDelete);
            groupBox4.Controls.Add(btnAddSupplierProduct);
            groupBox4.Controls.Add(txtPSProductSupplierId);
            groupBox4.Controls.Add(btnEditSupplierProduct);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtPSSupplierId);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtPSProductId);
            groupBox4.Controls.Add(label10);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(325, 448);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(675, 229);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Suppliers and Products";
            // 
            // btnSPDelete
            // 
            btnSPDelete.Location = new Point(572, 173);
            btnSPDelete.Name = "btnSPDelete";
            btnSPDelete.Size = new Size(84, 40);
            btnSPDelete.TabIndex = 26;
            btnSPDelete.Text = "Delete";
            btnSPDelete.UseVisualStyleBackColor = true;
            btnSPDelete.Click += btnSPDelete_Click;
            // 
            // txtPSProductSupplierId
            // 
            txtPSProductSupplierId.Location = new Point(354, 30);
            txtPSProductSupplierId.Name = "txtPSProductSupplierId";
            txtPSProductSupplierId.ReadOnly = true;
            txtPSProductSupplierId.Size = new Size(302, 34);
            txtPSProductSupplierId.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 23;
            label3.Text = "Prpduct_Supplier Id";
            // 
            // txtPSSupplierId
            // 
            txtPSSupplierId.Location = new Point(354, 74);
            txtPSSupplierId.Name = "txtPSSupplierId";
            txtPSSupplierId.ReadOnly = true;
            txtPSSupplierId.Size = new Size(302, 34);
            txtPSSupplierId.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 81);
            label9.Name = "label9";
            label9.Size = new Size(107, 28);
            label9.TabIndex = 6;
            label9.Text = "Supplier Id";
            // 
            // txtPSProductId
            // 
            txtPSProductId.Location = new Point(354, 120);
            txtPSProductId.Name = "txtPSProductId";
            txtPSProductId.ReadOnly = true;
            txtPSProductId.Size = new Size(302, 34);
            txtPSProductId.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(33, 127);
            label10.Name = "label10";
            label10.Size = new Size(103, 28);
            label10.TabIndex = 4;
            label10.Text = "Product Id";
            // 
            // dataGVPS
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGVPS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGVPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGVPS.DefaultCellStyle = dataGridViewCellStyle2;
            dataGVPS.Location = new Point(1070, 467);
            dataGVPS.Name = "dataGVPS";
            dataGVPS.RowHeadersWidth = 51;
            dataGVPS.RowTemplate.Height = 29;
            dataGVPS.Size = new Size(473, 184);
            dataGVPS.TabIndex = 25;
            dataGVPS.CellContentClick += dataGVPS_CellContentClick;
            // 
            // dataGVSupplier
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGVSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGVSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGVSupplier.DefaultCellStyle = dataGridViewCellStyle4;
            dataGVSupplier.Location = new Point(1070, 720);
            dataGVSupplier.Name = "dataGVSupplier";
            dataGVSupplier.RowHeadersWidth = 51;
            dataGVSupplier.RowTemplate.Height = 29;
            dataGVSupplier.Size = new Size(473, 183);
            dataGVSupplier.TabIndex = 27;
            dataGVSupplier.CellContentClick += dataGVSupplier_CellClick;
            // 
            // dataGVProduct
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGVProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGVProduct.DefaultCellStyle = dataGridViewCellStyle6;
            dataGVProduct.Location = new Point(1070, 977);
            dataGVProduct.Name = "dataGVProduct";
            dataGVProduct.RowHeadersWidth = 51;
            dataGVProduct.RowTemplate.Height = 29;
            dataGVProduct.Size = new Size(473, 176);
            dataGVProduct.TabIndex = 28;
            dataGVProduct.CellContentClick += dataGVProduct_CellClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ButtonHighlight;
            label14.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlText;
            label14.Location = new Point(1366, 33);
            label14.Name = "label14";
            label14.Size = new Size(170, 35);
            label14.TabIndex = 29;
            label14.Text = "Package Table";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(1171, 419);
            label15.Name = "label15";
            label15.Size = new Size(267, 35);
            label15.TabIndex = 30;
            label15.Text = "Product_Supplier Table";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlText;
            label17.Location = new Point(1223, 672);
            label17.Name = "label17";
            label17.Size = new Size(170, 35);
            label17.TabIndex = 32;
            label17.Text = "Supplier Table";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(1227, 929);
            label18.Name = "label18";
            label18.Size = new Size(166, 35);
            label18.TabIndex = 33;
            label18.Text = "Product Table";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(btnProductDelete);
            groupBox1.Controls.Add(txtEditProductId);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnEditProduct);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(325, 955);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(675, 198);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Products";
            // 
            // btnProductDelete
            // 
            btnProductDelete.Location = new Point(572, 142);
            btnProductDelete.Name = "btnProductDelete";
            btnProductDelete.Size = new Size(84, 40);
            btnProductDelete.TabIndex = 29;
            btnProductDelete.Text = "Delete";
            btnProductDelete.UseVisualStyleBackColor = true;
            btnProductDelete.Click += btnProductDelete_Click;
            // 
            // txtEditProductId
            // 
            txtEditProductId.Location = new Point(354, 40);
            txtEditProductId.Name = "txtEditProductId";
            txtEditProductId.ReadOnly = true;
            txtEditProductId.Size = new Size(302, 34);
            txtEditProductId.TabIndex = 28;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(33, 43);
            label19.Name = "label19";
            label19.Size = new Size(103, 28);
            label19.TabIndex = 27;
            label19.Text = "Product Id";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(464, 144);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(81, 38);
            btnEditProduct.TabIndex = 24;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(354, 144);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(81, 38);
            btnAddProduct.TabIndex = 21;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(354, 93);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(302, 34);
            txtProductName.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 96);
            label11.Name = "label11";
            label11.Size = new Size(138, 28);
            label11.TabIndex = 6;
            label11.Text = "Product Name";
            // 
            // btnMgPackages
            // 
            btnMgPackages.BackColor = SystemColors.Desktop;
            btnMgPackages.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMgPackages.Location = new Point(55, 38);
            btnMgPackages.Name = "btnMgPackages";
            btnMgPackages.Size = new Size(183, 71);
            btnMgPackages.TabIndex = 34;
            btnMgPackages.Text = "Manage Packages";
            btnMgPackages.UseVisualStyleBackColor = false;
            btnMgPackages.Click += btnMgPackages_Click;
            // 
            // btnMgPS
            // 
            btnMgPS.BackColor = SystemColors.MenuHighlight;
            btnMgPS.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMgPS.Location = new Point(55, 448);
            btnMgPS.Name = "btnMgPS";
            btnMgPS.Size = new Size(183, 71);
            btnMgPS.TabIndex = 35;
            btnMgPS.Text = "Manage Products_Suppliers";
            btnMgPS.UseVisualStyleBackColor = false;
            btnMgPS.Click += btnMgPS_Click;
            // 
            // btnMgSuppliers
            // 
            btnMgSuppliers.BackColor = SystemColors.GradientActiveCaption;
            btnMgSuppliers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMgSuppliers.Location = new Point(55, 732);
            btnMgSuppliers.Name = "btnMgSuppliers";
            btnMgSuppliers.Size = new Size(183, 65);
            btnMgSuppliers.TabIndex = 36;
            btnMgSuppliers.Text = "Manage Suppliers";
            btnMgSuppliers.UseVisualStyleBackColor = false;
            btnMgSuppliers.Click += btnMgSuppliers_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.BackColor = SystemColors.GradientInactiveCaption;
            btnManageProducts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageProducts.Location = new Point(55, 970);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(183, 65);
            btnManageProducts.TabIndex = 37;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = false;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // dataGVPackage
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGVPackage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGVPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGVPackage.DefaultCellStyle = dataGridViewCellStyle8;
            dataGVPackage.Location = new Point(1070, 71);
            dataGVPackage.Name = "dataGVPackage";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGVPackage.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGVPackage.RowHeadersWidth = 51;
            dataGVPackage.RowTemplate.Height = 29;
            dataGVPackage.Size = new Size(959, 295);
            dataGVPackage.TabIndex = 24;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ActiveBorder;
            btnRefresh.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(761, 1170);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(182, 53);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1626, 1235);
            Controls.Add(dataGVPackage);
            Controls.Add(btnMgPackages);
            Controls.Add(dataGVProduct);
            Controls.Add(dataGVSupplier);
            Controls.Add(label14);
            Controls.Add(dataGVPS);
            Controls.Add(label18);
            Controls.Add(groupBox3);
            Controls.Add(btnMgPS);
            Controls.Add(label17);
            Controls.Add(groupBox4);
            Controls.Add(label15);
            Controls.Add(btnMgSuppliers);
            Controls.Add(btnRefresh);
            Controls.Add(groupBox2);
            Controls.Add(btnManageProducts);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Travel Experts";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtPackageCommission;
        private Label label6;
        private TextBox txtPackageBasePrice;
        private Label label7;
        private TextBox txtPackageDescription;
        private Label label8;
        private TextBox txtPackageName;
        private TextBox txtSupplierName;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox txtPSSupplierId;
        private Label label9;
        private TextBox txtPSProductId;
        private Label label10;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private Label label12;
        private Label label13;
        private Button btnEditPackage;
        private Button btnAddPackage;
        private Button btnAddSupplier;
        private Button btnEditSupplierProduct;
        private TextBox txtProductSupplierId;
        private DataGridView dataGVPS;
        private DataGridView dataGVSupplier;
        private DataGridView dataGVProduct;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private TextBox txtPSProductSupplierId;
        private Label label3;
        private Button btnEditSupplier;
        private Button btnAddSupplierProduct;
        private GroupBox groupBox1;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private Label label11;
        private TextBox txtEditSupplierId;
        private Label label5;
        private TextBox txtEditProductId;
        private Label label19;
        private Button btnEditProduct;
        private Button btnMgPackages;
        private Button btnMgPS;
        private Button btnMgSuppliers;
        private Button btnManageProducts;
        private DataGridView dataGVPackage;
        private Button btnRefresh;
        private Button btnSupplierDelete;
        private Button btnSPDelete;
        private Button btnProductDelete;
        private Button btnPackageDelete;
    }
}