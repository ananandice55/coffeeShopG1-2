namespace Coffee
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblName = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(9, 649);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.BackColor = System.Drawing.Color.Transparent;
            this.lblShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblShowName.ForeColor = System.Drawing.Color.Black;
            this.lblShowName.Location = new System.Drawing.Point(62, 649);
            this.lblShowName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(51, 20);
            this.lblShowName.TabIndex = 7;
            this.lblShowName.Text = "label2";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MMM-yyyy HH:mm tt";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(697, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 29);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(396, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "COFFEE";
            // 
            // btnSignout
            // 
            this.btnSignout.AutoSize = true;
            this.btnSignout.BackColor = System.Drawing.Color.Transparent;
            this.btnSignout.BackgroundImage = global::Coffee.Properties.Resources.logout;
            this.btnSignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSignout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSignout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSignout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSignout.Location = new System.Drawing.Point(697, 390);
            this.btnSignout.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(199, 222);
            this.btnSignout.TabIndex = 5;
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignoutClick);
            // 
            // btnSetting
            // 
            this.btnSetting.AutoSize = true;
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.BackgroundImage = global::Coffee.Properties.Resources.management;
            this.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnSetting.Location = new System.Drawing.Point(360, 390);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(224, 222);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSettingClick);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoSize = true;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BackgroundImage = global::Coffee.Properties.Resources.ecommerce;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnProduct.Location = new System.Drawing.Point(41, 390);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(216, 222);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProductClick);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AutoSize = true;
            this.btnCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomer.BackgroundImage = global::Coffee.Properties.Resources.investor;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnCustomer.Location = new System.Drawing.Point(686, 67);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(223, 222);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomerClick);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AutoSize = true;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.BackgroundImage = global::Coffee.Properties.Resources.folder;
            this.btnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnEmployee.Location = new System.Drawing.Point(349, 67);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(260, 222);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployeeClick);
            // 
            // btnShop
            // 
            this.btnShop.AutoSize = true;
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.BackgroundImage = global::Coffee.Properties.Resources.cart;
            this.btnShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnShop.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnShop.Location = new System.Drawing.Point(41, 67);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(209, 222);
            this.btnShop.TabIndex = 0;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShopClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnShop);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingFormMain);
            this.Load += new System.EventHandler(this.loadFormMain);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Label label3;
    }
}

