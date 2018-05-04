namespace ConfigureMyAuto
{
    partial class AutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoForm));
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.rbRover = new System.Windows.Forms.RadioButton();
            this.rbChevrolet = new System.Windows.Forms.RadioButton();
            this.pbAuto = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.cbAbs = new System.Windows.Forms.CheckBox();
            this.cbFog = new System.Windows.Forms.CheckBox();
            this.cbChains = new System.Windows.Forms.CheckBox();
            this.lblExtras = new System.Windows.Forms.Label();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.rbCheque = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDiscountAuto = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPriceOfAuto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Location = new System.Drawing.Point(23, 11);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(73, 19);
            this.rbAudi.TabIndex = 0;
            this.rbAudi.Text = "AudiRS7";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // rbRover
            // 
            this.rbRover.AutoSize = true;
            this.rbRover.Location = new System.Drawing.Point(23, 39);
            this.rbRover.Name = "rbRover";
            this.rbRover.Size = new System.Drawing.Size(97, 19);
            this.rbRover.TabIndex = 1;
            this.rbRover.Text = "Range Rover";
            this.rbRover.UseVisualStyleBackColor = true;
            this.rbRover.CheckedChanged += new System.EventHandler(this.rbRover_CheckedChanged);
            // 
            // rbChevrolet
            // 
            this.rbChevrolet.AutoSize = true;
            this.rbChevrolet.Checked = true;
            this.rbChevrolet.Location = new System.Drawing.Point(23, 66);
            this.rbChevrolet.Name = "rbChevrolet";
            this.rbChevrolet.Size = new System.Drawing.Size(123, 19);
            this.rbChevrolet.TabIndex = 2;
            this.rbChevrolet.TabStop = true;
            this.rbChevrolet.Text = "Chevrolet Camaro";
            this.rbChevrolet.UseVisualStyleBackColor = true;
            this.rbChevrolet.CheckedChanged += new System.EventHandler(this.rbChevrolet_CheckedChanged);
            // 
            // pbAuto
            // 
            this.pbAuto.Location = new System.Drawing.Point(253, 36);
            this.pbAuto.Name = "pbAuto";
            this.pbAuto.Size = new System.Drawing.Size(277, 177);
            this.pbAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAuto.TabIndex = 3;
            this.pbAuto.TabStop = false;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.Blue;
            this.lblChoose.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblChoose.Location = new System.Drawing.Point(22, 9);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(205, 24);
            this.lblChoose.TabIndex = 4;
            this.lblChoose.Text = "Choose your model :";
            // 
            // cbAbs
            // 
            this.cbAbs.AutoSize = true;
            this.cbAbs.Location = new System.Drawing.Point(49, 176);
            this.cbAbs.Name = "cbAbs";
            this.cbAbs.Size = new System.Drawing.Size(49, 19);
            this.cbAbs.TabIndex = 5;
            this.cbAbs.Text = "ABS";
            this.cbAbs.UseVisualStyleBackColor = true;
            this.cbAbs.CheckedChanged += new System.EventHandler(this.cbAbs_CheckedChanged);
            // 
            // cbFog
            // 
            this.cbFog.AutoSize = true;
            this.cbFog.Location = new System.Drawing.Point(49, 201);
            this.cbFog.Name = "cbFog";
            this.cbFog.Size = new System.Drawing.Size(87, 19);
            this.cbFog.TabIndex = 6;
            this.cbFog.Text = "Fog lamps ";
            this.cbFog.UseVisualStyleBackColor = true;
            this.cbFog.CheckedChanged += new System.EventHandler(this.cbFog_CheckedChanged);
            // 
            // cbChains
            // 
            this.cbChains.AutoSize = true;
            this.cbChains.Location = new System.Drawing.Point(49, 226);
            this.cbChains.Name = "cbChains";
            this.cbChains.Size = new System.Drawing.Size(64, 19);
            this.cbChains.TabIndex = 7;
            this.cbChains.Text = "Chains";
            this.cbChains.UseVisualStyleBackColor = true;
            this.cbChains.CheckedChanged += new System.EventHandler(this.cbChains_CheckedChanged);
            // 
            // lblExtras
            // 
            this.lblExtras.AutoSize = true;
            this.lblExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExtras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblExtras.Location = new System.Drawing.Point(45, 149);
            this.lblExtras.Name = "lblExtras";
            this.lblExtras.Size = new System.Drawing.Size(80, 24);
            this.lblExtras.TabIndex = 8;
            this.lblExtras.Text = "Extras :";
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(14, 20);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(66, 19);
            this.rbCash.TabIndex = 9;
            this.rbCash.Text = "In Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            this.rbCash.CheckedChanged += new System.EventHandler(this.rbCash_CheckedChanged);
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(14, 45);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(82, 19);
            this.rbCheque.TabIndex = 10;
            this.rbCheque.Text = "By cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(14, 70);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(100, 19);
            this.rbCreditCard.TabIndex = 11;
            this.rbCreditCard.Text = "By Credit card";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPayment.Location = new System.Drawing.Point(31, 273);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(200, 24);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "Method of payment :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPrice.Location = new System.Drawing.Point(342, 258);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 24);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price :";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDiscount.Location = new System.Drawing.Point(309, 283);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(103, 24);
            this.lblDiscount.TabIndex = 15;
            this.lblDiscount.Text = "Discount :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(290, 311);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 24);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total Price :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Red;
            this.btnCalculate.Location = new System.Drawing.Point(146, 403);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 36);
            this.btnCalculate.TabIndex = 19;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(271, 403);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 36);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDiscountAuto
            // 
            this.lblDiscountAuto.Location = new System.Drawing.Point(418, 283);
            this.lblDiscountAuto.Name = "lblDiscountAuto";
            this.lblDiscountAuto.Size = new System.Drawing.Size(123, 24);
            this.lblDiscountAuto.TabIndex = 24;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Location = new System.Drawing.Point(418, 311);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(112, 24);
            this.lblTotalPrice.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.rbCash);
            this.groupBox1.Controls.Add(this.rbCheque);
            this.groupBox1.Controls.Add(this.rbCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(35, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 97);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // lblPriceOfAuto
            // 
            this.lblPriceOfAuto.Location = new System.Drawing.Point(418, 258);
            this.lblPriceOfAuto.Name = "lblPriceOfAuto";
            this.lblPriceOfAuto.Size = new System.Drawing.Size(112, 24);
            this.lblPriceOfAuto.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAudi);
            this.groupBox2.Controls.Add(this.rbChevrolet);
            this.groupBox2.Controls.Add(this.rbRover);
            this.groupBox2.Location = new System.Drawing.Point(26, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // AutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPriceOfAuto);
            this.Controls.Add(this.cbAbs);
            this.Controls.Add(this.cbFog);
            this.Controls.Add(this.cbChains);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDiscountAuto);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblExtras);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.pbAuto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoForm";
            this.Text = "Configure Your Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AutoForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbAuto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.RadioButton rbRover;
        private System.Windows.Forms.RadioButton rbChevrolet;
        private System.Windows.Forms.PictureBox pbAuto;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.CheckBox cbAbs;
        private System.Windows.Forms.CheckBox cbFog;
        private System.Windows.Forms.CheckBox cbChains;
        private System.Windows.Forms.Label lblExtras;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.RadioButton rbCheque;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDiscountAuto;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPriceOfAuto;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

