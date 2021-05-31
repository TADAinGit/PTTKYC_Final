namespace QuanLyBanHoa.Forms
{
    partial class ImportGoods
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
            this.tcImportGoods = new System.Windows.Forms.TabControl();
            this.tabImportGoods = new System.Windows.Forms.TabPage();
            this.flpListProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            this.add10 = new System.Windows.Forms.Button();
            this.sub10 = new System.Windows.Forms.Button();
            this.add100 = new System.Windows.Forms.Button();
            this.sub100 = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.iconbtnAddProduct = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnImport = new FontAwesome.Sharp.IconButton();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.listVProduct = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gianhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.iconbtnFilter = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconbtnReset = new FontAwesome.Sharp.IconButton();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dtbTime = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcImportGoods.SuspendLayout();
            this.tabImportGoods.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // tcImportGoods
            // 
            this.tcImportGoods.Controls.Add(this.tabImportGoods);
            this.tcImportGoods.Controls.Add(this.tabHistory);
            this.tcImportGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcImportGoods.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tcImportGoods.ItemSize = new System.Drawing.Size(120, 45);
            this.tcImportGoods.Location = new System.Drawing.Point(0, 0);
            this.tcImportGoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tcImportGoods.Name = "tcImportGoods";
            this.tcImportGoods.Padding = new System.Drawing.Point(20, 7);
            this.tcImportGoods.SelectedIndex = 0;
            this.tcImportGoods.Size = new System.Drawing.Size(1676, 1026);
            this.tcImportGoods.TabIndex = 0;
            this.tcImportGoods.SelectedIndexChanged += new System.EventHandler(this.tcImportGoods_SelectedIndexChanged);
            // 
            // tabImportGoods
            // 
            this.tabImportGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.tabImportGoods.Controls.Add(this.flpListProduct);
            this.tabImportGoods.Controls.Add(this.tableLayoutPanel2);
            this.tabImportGoods.Controls.Add(this.tableLayoutPanel1);
            this.tabImportGoods.Location = new System.Drawing.Point(4, 49);
            this.tabImportGoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.tabImportGoods.Name = "tabImportGoods";
            this.tabImportGoods.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabImportGoods.Size = new System.Drawing.Size(1668, 973);
            this.tabImportGoods.TabIndex = 0;
            this.tabImportGoods.Text = "Nhập hàng";
            this.tabImportGoods.Click += new System.EventHandler(this.tabImportGoods_Click);
            // 
            // flpListProduct
            // 
            this.flpListProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListProduct.AutoScroll = true;
            this.flpListProduct.BackColor = System.Drawing.Color.White;
            this.flpListProduct.Location = new System.Drawing.Point(0, 183);
            this.flpListProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flpListProduct.Name = "flpListProduct";
            this.flpListProduct.Size = new System.Drawing.Size(866, 757);
            this.flpListProduct.TabIndex = 22;
            this.flpListProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.flpListProduct_Paint_2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(866, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 928);
            this.tableLayoutPanel2.TabIndex = 21;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panelProduct
            // 
            this.panelProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.panelProduct.Controls.Add(this.txtID);
            this.panelProduct.Controls.Add(this.label7);
            this.panelProduct.Controls.Add(this.txtBID);
            this.panelProduct.Controls.Add(this.add10);
            this.panelProduct.Controls.Add(this.sub10);
            this.panelProduct.Controls.Add(this.add100);
            this.panelProduct.Controls.Add(this.sub100);
            this.panelProduct.Controls.Add(this.nudAmount);
            this.panelProduct.Controls.Add(this.txtName);
            this.panelProduct.Controls.Add(this.iconbtnAddProduct);
            this.panelProduct.Location = new System.Drawing.Point(6, 5);
            this.panelProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(784, 120);
            this.panelProduct.TabIndex = 7;
            this.panelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProduct_Paint_1);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtID.Location = new System.Drawing.Point(10, 9);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(58, 35);
            this.txtID.TabIndex = 19;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(572, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 29);
            this.label7.TabIndex = 18;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBID
            // 
            this.txtBID.BackColor = System.Drawing.Color.White;
            this.txtBID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBID.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBID.Location = new System.Drawing.Point(402, 9);
            this.txtBID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(193, 35);
            this.txtBID.TabIndex = 17;
            this.txtBID.Text = "Giá nhập";
            this.txtBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBID.TextChanged += new System.EventHandler(this.txtBID_TextChanged);
            this.txtBID.Enter += new System.EventHandler(this.txtBID_Enter);
            this.txtBID.Leave += new System.EventHandler(this.txtBID_Leave);
            // 
            // add10
            // 
            this.add10.BackColor = System.Drawing.SystemColors.Control;
            this.add10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add10.FlatAppearance.BorderSize = 0;
            this.add10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add10.Location = new System.Drawing.Point(402, 69);
            this.add10.Margin = new System.Windows.Forms.Padding(0);
            this.add10.Name = "add10";
            this.add10.Size = new System.Drawing.Size(81, 43);
            this.add10.TabIndex = 16;
            this.add10.Text = "+10";
            this.add10.UseVisualStyleBackColor = false;
            this.add10.Click += new System.EventHandler(this.button3_Click);
            // 
            // sub10
            // 
            this.sub10.BackColor = System.Drawing.SystemColors.Control;
            this.sub10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub10.FlatAppearance.BorderSize = 0;
            this.sub10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub10.Location = new System.Drawing.Point(111, 69);
            this.sub10.Margin = new System.Windows.Forms.Padding(0);
            this.sub10.Name = "sub10";
            this.sub10.Size = new System.Drawing.Size(74, 43);
            this.sub10.TabIndex = 15;
            this.sub10.Text = "-10";
            this.sub10.UseVisualStyleBackColor = false;
            this.sub10.Click += new System.EventHandler(this.button2_Click);
            // 
            // add100
            // 
            this.add100.BackColor = System.Drawing.SystemColors.Control;
            this.add100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.add100.FlatAppearance.BorderSize = 0;
            this.add100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add100.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.add100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.add100.Location = new System.Drawing.Point(492, 69);
            this.add100.Margin = new System.Windows.Forms.Padding(0);
            this.add100.Name = "add100";
            this.add100.Size = new System.Drawing.Size(108, 43);
            this.add100.TabIndex = 14;
            this.add100.Text = "+100";
            this.add100.UseVisualStyleBackColor = false;
            this.add100.Click += new System.EventHandler(this.button1_Click);
            // 
            // sub100
            // 
            this.sub100.BackColor = System.Drawing.SystemColors.Control;
            this.sub100.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.sub100.FlatAppearance.BorderSize = 0;
            this.sub100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sub100.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sub100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sub100.Location = new System.Drawing.Point(10, 69);
            this.sub100.Margin = new System.Windows.Forms.Padding(0);
            this.sub100.Name = "sub100";
            this.sub100.Size = new System.Drawing.Size(93, 43);
            this.sub100.TabIndex = 13;
            this.sub100.Text = "-100";
            this.sub100.UseVisualStyleBackColor = false;
            this.sub100.Click += new System.EventHandler(this.btnS100_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.White;
            this.nudAmount.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.nudAmount.Location = new System.Drawing.Point(194, 69);
            this.nudAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(200, 37);
            this.nudAmount.TabIndex = 11;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.nudAmount.Enter += new System.EventHandler(this.nudAmount_Enter);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtName.Location = new System.Drawing.Point(76, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(317, 35);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Tên sản phẩm";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // iconbtnAddProduct
            // 
            this.iconbtnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.FlatAppearance.BorderSize = 2;
            this.iconbtnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnAddProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnAddProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnAddProduct.ForeColor = System.Drawing.Color.White;
            this.iconbtnAddProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnAddProduct.IconColor = System.Drawing.Color.Black;
            this.iconbtnAddProduct.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconbtnAddProduct.IconSize = 40;
            this.iconbtnAddProduct.Location = new System.Drawing.Point(606, 9);
            this.iconbtnAddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconbtnAddProduct.Name = "iconbtnAddProduct";
            this.iconbtnAddProduct.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.iconbtnAddProduct.Rotation = 0D;
            this.iconbtnAddProduct.Size = new System.Drawing.Size(172, 106);
            this.iconbtnAddProduct.TabIndex = 0;
            this.iconbtnAddProduct.Text = "Thêm";
            this.iconbtnAddProduct.UseCompatibleTextRendering = true;
            this.iconbtnAddProduct.UseVisualStyleBackColor = true;
            this.iconbtnAddProduct.Click += new System.EventHandler(this.iconbtnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.iconbtnImport);
            this.panel1.Controls.Add(this.cbSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalMoney);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 794);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 129);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // iconbtnImport
            // 
            this.iconbtnImport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnImport.FlatAppearance.BorderSize = 2;
            this.iconbtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnImport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnImport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.iconbtnImport.ForeColor = System.Drawing.Color.White;
            this.iconbtnImport.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnImport.IconColor = System.Drawing.Color.Black;
            this.iconbtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnImport.IconSize = 40;
            this.iconbtnImport.Location = new System.Drawing.Point(540, 14);
            this.iconbtnImport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconbtnImport.Name = "iconbtnImport";
            this.iconbtnImport.Rotation = 0D;
            this.iconbtnImport.Size = new System.Drawing.Size(232, 108);
            this.iconbtnImport.TabIndex = 20;
            this.iconbtnImport.Text = "Nhập hàng";
            this.iconbtnImport.UseCompatibleTextRendering = true;
            this.iconbtnImport.UseVisualStyleBackColor = true;
            this.iconbtnImport.Click += new System.EventHandler(this.iconbtnImport_Click);
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(214, 82);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(314, 35);
            this.cbSupplier.TabIndex = 10;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Nhà cung cấp";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.BackColor = System.Drawing.Color.White;
            this.txtTotalMoney.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalMoney.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMoney.Location = new System.Drawing.Point(162, 14);
            this.txtTotalMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.ReadOnly = true;
            this.txtTotalMoney.Size = new System.Drawing.Size(368, 40);
            this.txtTotalMoney.TabIndex = 18;
            this.txtTotalMoney.Text = "0";
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalMoney.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tổng tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.listVProduct);
            this.panel8.Location = new System.Drawing.Point(6, 139);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(784, 644);
            this.panel8.TabIndex = 10;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // listVProduct
            // 
            this.listVProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listVProduct.BackColor = System.Drawing.Color.White;
            this.listVProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listVProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.Ten,
            this.SL,
            this.ThanhTien,
            this.Gianhap});
            this.listVProduct.FullRowSelect = true;
            this.listVProduct.GridLines = true;
            this.listVProduct.HideSelection = false;
            this.listVProduct.Location = new System.Drawing.Point(0, 5);
            this.listVProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listVProduct.Name = "listVProduct";
            this.listVProduct.Size = new System.Drawing.Size(784, 634);
            this.listVProduct.TabIndex = 0;
            this.listVProduct.UseCompatibleStateImageBehavior = false;
            this.listVProduct.View = System.Windows.Forms.View.Details;
            this.listVProduct.SelectedIndexChanged += new System.EventHandler(this.listVProduct_SelectedIndexChanged_1);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 52;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên sản phẩm";
            this.Ten.Width = 188;
            // 
            // SL
            // 
            this.SL.Text = "Số lượng";
            this.SL.Width = 94;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DisplayIndex = 4;
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 127;
            // 
            // Gianhap
            // 
            this.Gianhap.DisplayIndex = 3;
            this.Gianhap.Text = "Giá nhập";
            this.Gianhap.Width = 78;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.64452F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65315F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.70233F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(1050, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 174);
            this.tableLayoutPanel1.TabIndex = 20;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(4, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 77);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cbPrice
            // 
            this.cbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(4, 32);
            this.cbPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPrice.MaximumSize = new System.Drawing.Size(493, 0);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(270, 35);
            this.cbPrice.TabIndex = 21;
            this.cbPrice.SelectedIndexChanged += new System.EventHandler(this.cbPrice_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Giá thành";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cbTypeProduct);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(4, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 77);
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Location = new System.Drawing.Point(4, 32);
            this.cbTypeProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTypeProduct.MaximumSize = new System.Drawing.Size(403, 0);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(270, 35);
            this.cbTypeProduct.TabIndex = 20;
            this.cbTypeProduct.SelectedIndexChanged += new System.EventHandler(this.cbTypeProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Loại sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtProductName);
            this.panel4.Location = new System.Drawing.Point(293, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 77);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(0, 32);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductName.MaximumSize = new System.Drawing.Size(448, 26);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(339, 35);
            this.txtProductName.TabIndex = 17;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.txtProductID);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(293, 92);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 77);
            this.panel5.TabIndex = 18;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtProductID
            // 
            this.txtProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductID.Location = new System.Drawing.Point(4, 32);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductID.MaximumSize = new System.Drawing.Size(448, 26);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(335, 35);
            this.txtProductID.TabIndex = 21;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "ID sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.iconbtnFilter);
            this.panel6.Location = new System.Drawing.Point(659, 5);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 77);
            this.panel6.TabIndex = 19;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // iconbtnFilter
            // 
            this.iconbtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(225)))), ((int)(((byte)(90)))));
            this.iconbtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(179)))));
            this.iconbtnFilter.FlatAppearance.BorderSize = 0;
            this.iconbtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnFilter.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnFilter.ForeColor = System.Drawing.Color.White;
            this.iconbtnFilter.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnFilter.IconColor = System.Drawing.Color.Black;
            this.iconbtnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnFilter.IconSize = 40;
            this.iconbtnFilter.Location = new System.Drawing.Point(3, 0);
            this.iconbtnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconbtnFilter.MaximumSize = new System.Drawing.Size(300, 74);
            this.iconbtnFilter.Name = "iconbtnFilter";
            this.iconbtnFilter.Rotation = 0D;
            this.iconbtnFilter.Size = new System.Drawing.Size(190, 74);
            this.iconbtnFilter.TabIndex = 14;
            this.iconbtnFilter.Text = "Lọc";
            this.iconbtnFilter.UseVisualStyleBackColor = false;
            this.iconbtnFilter.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.iconbtnReset);
            this.panel7.Location = new System.Drawing.Point(659, 92);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 77);
            this.panel7.TabIndex = 20;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // iconbtnReset
            // 
            this.iconbtnReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconbtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(225)))), ((int)(((byte)(90)))));
            this.iconbtnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(179)))));
            this.iconbtnReset.FlatAppearance.BorderSize = 0;
            this.iconbtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnReset.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconbtnReset.ForeColor = System.Drawing.Color.White;
            this.iconbtnReset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconbtnReset.IconColor = System.Drawing.Color.Black;
            this.iconbtnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnReset.IconSize = 40;
            this.iconbtnReset.Location = new System.Drawing.Point(3, 5);
            this.iconbtnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconbtnReset.MaximumSize = new System.Drawing.Size(300, 74);
            this.iconbtnReset.Name = "iconbtnReset";
            this.iconbtnReset.Rotation = 0D;
            this.iconbtnReset.Size = new System.Drawing.Size(190, 74);
            this.iconbtnReset.TabIndex = 15;
            this.iconbtnReset.Text = "Làm mới";
            this.iconbtnReset.UseVisualStyleBackColor = false;
            this.iconbtnReset.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(90)))));
            this.tabHistory.Controls.Add(this.lblMoney);
            this.tabHistory.Controls.Add(this.label8);
            this.tabHistory.Controls.Add(this.labelTime);
            this.tabHistory.Controls.Add(this.dtbTime);
            this.tabHistory.Controls.Add(this.dataGridViewHistory);
            this.tabHistory.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabHistory.Location = new System.Drawing.Point(4, 49);
            this.tabHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHistory.Size = new System.Drawing.Size(1668, 973);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "Lịch sử nhập hàng";
            this.tabHistory.Click += new System.EventHandler(this.tabHistory_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(1198, 45);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(36, 25);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "0đ";
            this.lblMoney.Click += new System.EventHandler(this.lblMoney_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(874, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tổng tiền nhập hàng:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(108, 45);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(102, 25);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Thời gian";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // dtbTime
            // 
            this.dtbTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbTime.Location = new System.Drawing.Point(312, 38);
            this.dtbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtbTime.Name = "dtbTime";
            this.dtbTime.Size = new System.Drawing.Size(238, 35);
            this.dtbTime.TabIndex = 1;
            this.dtbTime.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TenSP,
            this.TenNV,
            this.MaNH,
            this.BID,
            this.Soluong,
            this.TT,
            this.Tong});
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 98);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 62;
            this.dataGridViewHistory.RowTemplate.Height = 35;
            this.dataGridViewHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory.Size = new System.Drawing.Size(1640, 834);
            this.dataGridViewHistory.TabIndex = 0;
            this.dataGridViewHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellContentClick);
            this.dataGridViewHistory.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewHistory_ColumnHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "Ten";
            this.TenSP.FillWeight = 180F;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.FillWeight = 200F;
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 8;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            // 
            // MaNH
            // 
            this.MaNH.DataPropertyName = "MaNH";
            this.MaNH.FillWeight = 60F;
            this.MaNH.HeaderText = "Mã nhập hàng";
            this.MaNH.MinimumWidth = 8;
            this.MaNH.Name = "MaNH";
            this.MaNH.ReadOnly = true;
            // 
            // BID
            // 
            this.BID.DataPropertyName = "GiaNhap";
            this.BID.FillWeight = 85.94357F;
            this.BID.HeaderText = "Giá nhập";
            this.BID.MinimumWidth = 8;
            this.BID.Name = "BID";
            this.BID.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "SoLuong";
            this.Soluong.FillWeight = 85.94357F;
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 8;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // TT
            // 
            this.TT.DataPropertyName = "ThanhTien";
            this.TT.FillWeight = 85.94357F;
            this.TT.HeaderText = "Thành tiền";
            this.TT.MinimumWidth = 8;
            this.TT.Name = "TT";
            this.TT.ReadOnly = true;
            // 
            // Tong
            // 
            this.Tong.DataPropertyName = "TongTien";
            this.Tong.FillWeight = 140F;
            this.Tong.HeaderText = "Tổng tiền";
            this.Tong.MinimumWidth = 8;
            this.Tong.Name = "Tong";
            this.Tong.ReadOnly = true;
            // 
            // ImportGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1676, 1026);
            this.ControlBox = false;
            this.Controls.Add(this.tcImportGoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportGoods";
            this.Text = "ImportGoods";
            this.TransparencyKey = System.Drawing.Color.White;
            this.tcImportGoods.ResumeLayout(false);
            this.tabImportGoods.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcImportGoods;
        private System.Windows.Forms.TabPage tabImportGoods;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox txtName;
        private FontAwesome.Sharp.IconButton iconbtnAddProduct;
        private System.Windows.Forms.Button sub10;
        private System.Windows.Forms.Button add100;
        private System.Windows.Forms.Button sub100;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBID;
        private System.Windows.Forms.Button add10;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconbtnFilter;
        private FontAwesome.Sharp.IconButton iconbtnReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flpListProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton iconbtnImport;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ListView listVProduct;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader SL;
        private System.Windows.Forms.ColumnHeader ThanhTien;
        private System.Windows.Forms.ColumnHeader Gianhap;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dtbTime;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNH;
        private System.Windows.Forms.DataGridViewTextBoxColumn BID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong;
    }
}