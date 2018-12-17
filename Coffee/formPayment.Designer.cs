namespace Coffee
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.total = new System.Windows.Forms.TextBox();
            this.payment = new System.Windows.Forms.TextBox();
            this.crashChange = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridViewDetailBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewListProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(272, 92);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(295, 32);
            this.total.TabIndex = 1;
            // 
            // payment
            // 
            this.payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(272, 142);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(295, 32);
            this.payment.TabIndex = 0;
            this.payment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentKeyPress);
            // 
            // crashChange
            // 
            this.crashChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashChange.Location = new System.Drawing.Point(272, 195);
            this.crashChange.Name = "crashChange";
            this.crashChange.ReadOnly = true;
            this.crashChange.Size = new System.Drawing.Size(295, 32);
            this.crashChange.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Payment";
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(202, 264);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(50, 50);
            this.number7.TabIndex = 6;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.number7Click);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(258, 264);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(50, 50);
            this.number8.TabIndex = 7;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.number8Click);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(314, 264);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(50, 50);
            this.number9.TabIndex = 8;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.number9Click);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(314, 320);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(50, 50);
            this.number6.TabIndex = 11;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.number6Click);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(258, 320);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(50, 50);
            this.number5.TabIndex = 10;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.number5Click);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(202, 320);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(50, 50);
            this.number4.TabIndex = 9;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.number4Click);
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(314, 376);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(50, 50);
            this.number3.TabIndex = 14;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.number3Click);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(258, 376);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(50, 50);
            this.number2.TabIndex = 13;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.number2Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(202, 376);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(50, 50);
            this.number1.TabIndex = 12;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.number1Click);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(370, 320);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(50, 106);
            this.number0.TabIndex = 15;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.number0Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(370, 264);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 50);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemoveClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(675, 346);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(86, 76);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrintClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "ยอดรวม :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "รับเงิน :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "เงินทอน :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(477, 290);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(113, 50);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "ตกลง";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmitClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(477, 359);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 50);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // dataGridViewDetailBill
            // 
            this.dataGridViewDetailBill.AllowUserToAddRows = false;
            this.dataGridViewDetailBill.AllowUserToDeleteRows = false;
            this.dataGridViewDetailBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailBill.Location = new System.Drawing.Point(701, 360);
            this.dataGridViewDetailBill.Name = "dataGridViewDetailBill";
            this.dataGridViewDetailBill.ReadOnly = true;
            this.dataGridViewDetailBill.Size = new System.Drawing.Size(34, 23);
            this.dataGridViewDetailBill.TabIndex = 25;
            // 
            // dataGridViewListProducts
            // 
            this.dataGridViewListProducts.AllowUserToAddRows = false;
            this.dataGridViewListProducts.AllowUserToDeleteRows = false;
            this.dataGridViewListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListProducts.Location = new System.Drawing.Point(701, 389);
            this.dataGridViewListProducts.Name = "dataGridViewListProducts";
            this.dataGridViewListProducts.ReadOnly = true;
            this.dataGridViewListProducts.Size = new System.Drawing.Size(34, 20);
            this.dataGridViewListProducts.TabIndex = 26;
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridViewDetailBill);
            this.Controls.Add(this.dataGridViewListProducts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.number0);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number6);
            this.Controls.Add(this.number5);
            this.Controls.Add(this.number4);
            this.Controls.Add(this.number9);
            this.Controls.Add(this.number8);
            this.Controls.Add(this.number7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.crashChange);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.total);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closingFormPayment);
            this.Load += new System.EventHandler(this.loadFormPayment);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.TextBox crashChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridViewDetailBill;
        private System.Windows.Forms.DataGridView dataGridViewListProducts;
    }
}