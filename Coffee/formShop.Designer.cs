namespace Coffee
{
    partial class FormShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.lbshowname = new System.Windows.Forms.Label();
            this.btnRegisterCustomer = new System.Windows.Forms.Button();
            this.btnInputCustomer = new System.Windows.Forms.Button();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.lblIdCustomer = new System.Windows.Forms.Label();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSnackMenu = new System.Windows.Forms.Button();
            this.btnMilkMenu = new System.Windows.Forms.Button();
            this.btnWaterMenu = new System.Windows.Forms.Button();
            this.btnBakeryMenu = new System.Windows.Forms.Button();
            this.btnFurityMenu = new System.Windows.Forms.Button();
            this.btnTeaMenu = new System.Windows.Forms.Button();
            this.btnHotMenu = new System.Windows.Forms.Button();
            this.btnIcedMenu = new System.Windows.Forms.Button();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.water5 = new System.Windows.Forms.Button();
            this.water4 = new System.Windows.Forms.Button();
            this.water3 = new System.Windows.Forms.Button();
            this.water2 = new System.Windows.Forms.Button();
            this.water1 = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.btnClearList = new System.Windows.Forms.Button();
            this.btnReduceProdect = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.totalPrice = new System.Windows.Forms.Label();
            this.totalProduct = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblListProducts = new System.Windows.Forms.Label();
            this.showProduct = new System.Windows.Forms.DataGridView();
            this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.among = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.discountButton = new System.Windows.Forms.Button();
            this.lblNumberTotalPrice = new System.Windows.Forms.Label();
            this.lblNumberDistcount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panelCustomer.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showProduct)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.lbshowname);
            this.panelCustomer.Controls.Add(this.btnRegisterCustomer);
            this.panelCustomer.Controls.Add(this.btnInputCustomer);
            this.panelCustomer.Controls.Add(this.txtIdCustomer);
            this.panelCustomer.Controls.Add(this.lblIdCustomer);
            this.panelCustomer.Controls.Add(this.lblNameCustomer);
            this.panelCustomer.Location = new System.Drawing.Point(1, 1);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(329, 182);
            this.panelCustomer.TabIndex = 0;
            // 
            // lbshowname
            // 
            this.lbshowname.AutoSize = true;
            this.lbshowname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbshowname.Location = new System.Drawing.Point(106, 77);
            this.lbshowname.Name = "lbshowname";
            this.lbshowname.Size = new System.Drawing.Size(16, 24);
            this.lbshowname.TabIndex = 6;
            this.lbshowname.Text = "-";
            // 
            // btnRegisterCustomer
            // 
            this.btnRegisterCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterCustomer.Location = new System.Drawing.Point(194, 123);
            this.btnRegisterCustomer.Name = "btnRegisterCustomer";
            this.btnRegisterCustomer.Size = new System.Drawing.Size(99, 39);
            this.btnRegisterCustomer.TabIndex = 5;
            this.btnRegisterCustomer.Text = "สมัครสมาชิก";
            this.btnRegisterCustomer.UseVisualStyleBackColor = true;
            this.btnRegisterCustomer.Click += new System.EventHandler(this.btnRegisterCustomerClick);
            // 
            // btnInputCustomer
            // 
            this.btnInputCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInputCustomer.Location = new System.Drawing.Point(44, 123);
            this.btnInputCustomer.Name = "btnInputCustomer";
            this.btnInputCustomer.Size = new System.Drawing.Size(95, 39);
            this.btnInputCustomer.TabIndex = 4;
            this.btnInputCustomer.Text = "ตกลง";
            this.btnInputCustomer.UseVisualStyleBackColor = true;
            this.btnInputCustomer.Click += new System.EventHandler(this.btnInputCustomerClick);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCustomer.Location = new System.Drawing.Point(102, 35);
            this.txtIdCustomer.MaxLength = 10;
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(191, 29);
            this.txtIdCustomer.TabIndex = 3;
            this.txtIdCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCustomerKeyPress);
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.AutoSize = true;
            this.lblIdCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCustomer.Location = new System.Drawing.Point(18, 35);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(80, 24);
            this.lblIdCustomer.TabIndex = 1;
            this.lblIdCustomer.Text = "เบอร์โทร :";
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(40, 77);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(58, 24);
            this.lblNameCustomer.TabIndex = 0;
            this.lblNameCustomer.Text = "ลูกค้า :";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnSnackMenu);
            this.panelMenu.Controls.Add(this.btnMilkMenu);
            this.panelMenu.Controls.Add(this.btnWaterMenu);
            this.panelMenu.Controls.Add(this.btnBakeryMenu);
            this.panelMenu.Controls.Add(this.btnFurityMenu);
            this.panelMenu.Controls.Add(this.btnTeaMenu);
            this.panelMenu.Controls.Add(this.btnHotMenu);
            this.panelMenu.Controls.Add(this.btnIcedMenu);
            this.panelMenu.Location = new System.Drawing.Point(330, 1);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(614, 182);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSnackMenu
            // 
            this.btnSnackMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnackMenu.Location = new System.Drawing.Point(460, 91);
            this.btnSnackMenu.Name = "btnSnackMenu";
            this.btnSnackMenu.Size = new System.Drawing.Size(152, 90);
            this.btnSnackMenu.TabIndex = 8;
            this.btnSnackMenu.Text = "Snack";
            this.btnSnackMenu.UseVisualStyleBackColor = true;
            this.btnSnackMenu.Click += new System.EventHandler(this.btnSnackMenuClick);
            // 
            // btnMilkMenu
            // 
            this.btnMilkMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMilkMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilkMenu.Location = new System.Drawing.Point(460, 1);
            this.btnMilkMenu.Name = "btnMilkMenu";
            this.btnMilkMenu.Size = new System.Drawing.Size(152, 90);
            this.btnMilkMenu.TabIndex = 7;
            this.btnMilkMenu.Text = "Milk";
            this.btnMilkMenu.UseVisualStyleBackColor = true;
            this.btnMilkMenu.Click += new System.EventHandler(this.btnMilkMenuClick);
            // 
            // btnWaterMenu
            // 
            this.btnWaterMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWaterMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWaterMenu.Location = new System.Drawing.Point(307, 91);
            this.btnWaterMenu.Name = "btnWaterMenu";
            this.btnWaterMenu.Size = new System.Drawing.Size(152, 90);
            this.btnWaterMenu.TabIndex = 6;
            this.btnWaterMenu.Text = "Water";
            this.btnWaterMenu.UseVisualStyleBackColor = true;
            this.btnWaterMenu.Click += new System.EventHandler(this.btnWaterMenuClick);
            // 
            // btnBakeryMenu
            // 
            this.btnBakeryMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBakeryMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBakeryMenu.Location = new System.Drawing.Point(154, 91);
            this.btnBakeryMenu.Name = "btnBakeryMenu";
            this.btnBakeryMenu.Size = new System.Drawing.Size(152, 90);
            this.btnBakeryMenu.TabIndex = 5;
            this.btnBakeryMenu.Text = "Bakery";
            this.btnBakeryMenu.UseVisualStyleBackColor = true;
            this.btnBakeryMenu.Click += new System.EventHandler(this.btnBakeryMenuClick);
            // 
            // btnFurityMenu
            // 
            this.btnFurityMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFurityMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFurityMenu.Location = new System.Drawing.Point(1, 91);
            this.btnFurityMenu.Name = "btnFurityMenu";
            this.btnFurityMenu.Size = new System.Drawing.Size(152, 90);
            this.btnFurityMenu.TabIndex = 4;
            this.btnFurityMenu.Text = "Furity";
            this.btnFurityMenu.UseVisualStyleBackColor = true;
            this.btnFurityMenu.Click += new System.EventHandler(this.btnFurityMenuClick);
            // 
            // btnTeaMenu
            // 
            this.btnTeaMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeaMenu.Location = new System.Drawing.Point(307, 1);
            this.btnTeaMenu.Name = "btnTeaMenu";
            this.btnTeaMenu.Size = new System.Drawing.Size(152, 90);
            this.btnTeaMenu.TabIndex = 3;
            this.btnTeaMenu.Text = "Tea";
            this.btnTeaMenu.UseVisualStyleBackColor = true;
            this.btnTeaMenu.Click += new System.EventHandler(this.btnTeaMenuClick);
            // 
            // btnHotMenu
            // 
            this.btnHotMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotMenu.Location = new System.Drawing.Point(154, 1);
            this.btnHotMenu.Name = "btnHotMenu";
            this.btnHotMenu.Size = new System.Drawing.Size(152, 90);
            this.btnHotMenu.TabIndex = 2;
            this.btnHotMenu.Text = "Hot";
            this.btnHotMenu.UseVisualStyleBackColor = true;
            this.btnHotMenu.Click += new System.EventHandler(this.btnHotMenuClick);
            // 
            // btnIcedMenu
            // 
            this.btnIcedMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIcedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIcedMenu.Location = new System.Drawing.Point(1, 1);
            this.btnIcedMenu.Name = "btnIcedMenu";
            this.btnIcedMenu.Size = new System.Drawing.Size(152, 90);
            this.btnIcedMenu.TabIndex = 0;
            this.btnIcedMenu.Text = "Iced";
            this.btnIcedMenu.UseVisualStyleBackColor = true;
            this.btnIcedMenu.Click += new System.EventHandler(this.btnIcedMenuClick);
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.water5);
            this.panelProduct.Controls.Add(this.water4);
            this.panelProduct.Controls.Add(this.water3);
            this.panelProduct.Controls.Add(this.water2);
            this.panelProduct.Controls.Add(this.water1);
            this.panelProduct.Location = new System.Drawing.Point(329, 183);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(615, 365);
            this.panelProduct.TabIndex = 2;
            // 
            // water5
            // 
            this.water5.BackgroundImage = global::Coffee.Properties.Resources.minireV2;
            this.water5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water5.Location = new System.Drawing.Point(208, 99);
            this.water5.Name = "water5";
            this.water5.Size = new System.Drawing.Size(200, 80);
            this.water5.TabIndex = 4;
            this.water5.UseVisualStyleBackColor = true;
            this.water5.Visible = false;
            this.water5.Click += new System.EventHandler(this.water5Click);
            // 
            // water4
            // 
            this.water4.BackgroundImage = global::Coffee.Properties.Resources.pepsiV2;
            this.water4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water4.Location = new System.Drawing.Point(5, 99);
            this.water4.Name = "water4";
            this.water4.Size = new System.Drawing.Size(200, 80);
            this.water4.TabIndex = 3;
            this.water4.UseVisualStyleBackColor = true;
            this.water4.Visible = false;
            this.water4.Click += new System.EventHandler(this.water4Click);
            // 
            // water3
            // 
            this.water3.BackgroundImage = global::Coffee.Properties.Resources.purraV2;
            this.water3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water3.Location = new System.Drawing.Point(411, 6);
            this.water3.Name = "water3";
            this.water3.Size = new System.Drawing.Size(200, 80);
            this.water3.TabIndex = 2;
            this.water3.UseVisualStyleBackColor = true;
            this.water3.Visible = false;
            this.water3.Click += new System.EventHandler(this.water3Click);
            // 
            // water2
            // 
            this.water2.BackgroundImage = global::Coffee.Properties.Resources.SinghaV2;
            this.water2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water2.Location = new System.Drawing.Point(208, 6);
            this.water2.Name = "water2";
            this.water2.Size = new System.Drawing.Size(200, 80);
            this.water2.TabIndex = 1;
            this.water2.UseVisualStyleBackColor = true;
            this.water2.Visible = false;
            this.water2.Click += new System.EventHandler(this.water2Click);
            // 
            // water1
            // 
            this.water1.BackgroundImage = global::Coffee.Properties.Resources.Splash;
            this.water1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.water1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.water1.Location = new System.Drawing.Point(4, 6);
            this.water1.Name = "water1";
            this.water1.Size = new System.Drawing.Size(200, 80);
            this.water1.TabIndex = 0;
            this.water1.UseVisualStyleBackColor = true;
            this.water1.Visible = false;
            this.water1.Click += new System.EventHandler(this.water1Click);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.btnClearList);
            this.panelList.Controls.Add(this.btnReduceProdect);
            this.panelList.Controls.Add(this.btnAddProduct);
            this.panelList.Controls.Add(this.totalPrice);
            this.panelList.Controls.Add(this.totalProduct);
            this.panelList.Controls.Add(this.lblTotal);
            this.panelList.Controls.Add(this.lblPrice);
            this.panelList.Controls.Add(this.lblAmount);
            this.panelList.Controls.Add(this.lblListProducts);
            this.panelList.Controls.Add(this.showProduct);
            this.panelList.Location = new System.Drawing.Point(0, 183);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(329, 365);
            this.panelList.TabIndex = 3;
            // 
            // btnClearList
            // 
            this.btnClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearList.Location = new System.Drawing.Point(219, 333);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(109, 29);
            this.btnClearList.TabIndex = 13;
            this.btnClearList.Text = "ลบรายการสินค้า";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearListClick);
            // 
            // btnReduceProdect
            // 
            this.btnReduceProdect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReduceProdect.Location = new System.Drawing.Point(110, 333);
            this.btnReduceProdect.Name = "btnReduceProdect";
            this.btnReduceProdect.Size = new System.Drawing.Size(109, 29);
            this.btnReduceProdect.TabIndex = 12;
            this.btnReduceProdect.Text = "ลดจำนวนสินค้า";
            this.btnReduceProdect.UseVisualStyleBackColor = true;
            this.btnReduceProdect.Click += new System.EventHandler(this.btnReduceProdectClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Location = new System.Drawing.Point(1, 333);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(109, 29);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "เพิ่มจำนวนสินค้า";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProductClick);
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(218, 303);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(109, 29);
            this.totalPrice.TabIndex = 9;
            this.totalPrice.Text = "$ 0.00";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // totalProduct
            // 
            this.totalProduct.BackColor = System.Drawing.SystemColors.Control;
            this.totalProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalProduct.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.totalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProduct.Location = new System.Drawing.Point(110, 303);
            this.totalProduct.Name = "totalProduct";
            this.totalProduct.Size = new System.Drawing.Size(109, 29);
            this.totalProduct.TabIndex = 8;
            this.totalProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(2, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(109, 29);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "ยอดรวม";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(218, 3);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(109, 29);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "ราคา";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAmount
            // 
            this.lblAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(110, 3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(109, 29);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "จำนวน";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblListProducts
            // 
            this.lblListProducts.BackColor = System.Drawing.SystemColors.Control;
            this.lblListProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListProducts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblListProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProducts.Location = new System.Drawing.Point(2, 3);
            this.lblListProducts.Name = "lblListProducts";
            this.lblListProducts.Size = new System.Drawing.Size(109, 29);
            this.lblListProducts.TabIndex = 0;
            this.lblListProducts.Text = "รายการสินค้า";
            this.lblListProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // showProduct
            // 
            this.showProduct.AllowUserToAddRows = false;
            this.showProduct.AllowUserToDeleteRows = false;
            this.showProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProduct,
            this.among,
            this.price});
            this.showProduct.Location = new System.Drawing.Point(2, 35);
            this.showProduct.Name = "showProduct";
            this.showProduct.ReadOnly = true;
            this.showProduct.Size = new System.Drawing.Size(327, 265);
            this.showProduct.TabIndex = 3;
            this.showProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showProductCellClick);
            // 
            // nameProduct
            // 
            this.nameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProduct.HeaderText = "รายการสินค้า";
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.ReadOnly = true;
            // 
            // among
            // 
            this.among.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.among.HeaderText = "จำนวน";
            this.among.Name = "among";
            this.among.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "ราคา";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnCancel);
            this.panelButton.Controls.Add(this.btnPayment);
            this.panelButton.Location = new System.Drawing.Point(329, 548);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(615, 129);
            this.panelButton.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(331, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(263, 81);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "ยกเลิกรายการ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnPayment
            // 
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(19, 22);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(263, 81);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "ชำระเงิน";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPaymentClick);
            // 
            // panelPrice
            // 
            this.panelPrice.Controls.Add(this.discountButton);
            this.panelPrice.Controls.Add(this.lblNumberTotalPrice);
            this.panelPrice.Controls.Add(this.lblNumberDistcount);
            this.panelPrice.Controls.Add(this.lblTotalPrice);
            this.panelPrice.Controls.Add(this.lblDiscount);
            this.panelPrice.Location = new System.Drawing.Point(0, 547);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(329, 130);
            this.panelPrice.TabIndex = 5;
            // 
            // discountButton
            // 
            this.discountButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.discountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountButton.Location = new System.Drawing.Point(0, 0);
            this.discountButton.Name = "discountButton";
            this.discountButton.Size = new System.Drawing.Size(165, 39);
            this.discountButton.TabIndex = 20;
            this.discountButton.Text = "ส่วนลด";
            this.discountButton.UseVisualStyleBackColor = true;
            this.discountButton.Click += new System.EventHandler(this.discountButtonClick);
            // 
            // lblNumberTotalPrice
            // 
            this.lblNumberTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumberTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNumberTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTotalPrice.Location = new System.Drawing.Point(164, 41);
            this.lblNumberTotalPrice.Name = "lblNumberTotalPrice";
            this.lblNumberTotalPrice.Size = new System.Drawing.Size(163, 88);
            this.lblNumberTotalPrice.TabIndex = 17;
            this.lblNumberTotalPrice.Text = "$ 0.00";
            this.lblNumberTotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblNumberDistcount
            // 
            this.lblNumberDistcount.BackColor = System.Drawing.SystemColors.Control;
            this.lblNumberDistcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberDistcount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNumberDistcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDistcount.Location = new System.Drawing.Point(2, 41);
            this.lblNumberDistcount.Name = "lblNumberDistcount";
            this.lblNumberDistcount.Size = new System.Drawing.Size(163, 88);
            this.lblNumberDistcount.TabIndex = 16;
            this.lblNumberDistcount.Text = "$ 0.00";
            this.lblNumberDistcount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(164, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(163, 40);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "ราคารวม";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(163, 40);
            this.lblDiscount.TabIndex = 14;
            this.lblDiscount.Text = "ส่วนลด";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Coffee.Properties.Resources.bg_shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 676);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop";
            this.Activated += new System.EventHandler(this.activatedFormShop);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingFormShop);
            this.Load += new System.EventHandler(this.loadFormShop);
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showProduct)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelPrice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button btnRegisterCustomer;
        private System.Windows.Forms.Button btnInputCustomer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private System.Windows.Forms.Label lblIdCustomer;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.Button btnSnackMenu;
        private System.Windows.Forms.Button btnMilkMenu;
        private System.Windows.Forms.Button btnWaterMenu;
        private System.Windows.Forms.Button btnBakeryMenu;
        private System.Windows.Forms.Button btnFurityMenu;
        private System.Windows.Forms.Button btnTeaMenu;
        private System.Windows.Forms.Button btnHotMenu;
        private System.Windows.Forms.Button btnIcedMenu;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label totalProduct;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblListProducts;
        private System.Windows.Forms.DataGridView showProduct;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Button water5;
        private System.Windows.Forms.Button water4;
        private System.Windows.Forms.Button water3;
        private System.Windows.Forms.Button water2;
        private System.Windows.Forms.Button water1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Button btnReduceProdect;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblNumberTotalPrice;
        private System.Windows.Forms.Label lblNumberDistcount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn among;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label lbshowname;
        private System.Windows.Forms.Button discountButton;
    }
}