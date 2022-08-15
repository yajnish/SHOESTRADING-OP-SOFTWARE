
namespace BELLAFARATA
{
    partial class addProduct
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
            this.announce = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.sellP = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.NumericUpDown();
            this.costP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.SuspendLayout();
            // 
            // announce
            // 
            this.announce.BackColor = System.Drawing.Color.MistyRose;
            this.announce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.announce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.announce.Location = new System.Drawing.Point(309, 514);
            this.announce.Name = "announce";
            this.announce.ReadOnly = true;
            this.announce.Size = new System.Drawing.Size(477, 35);
            this.announce.TabIndex = 25;
            this.announce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.announce.TextChanged += new System.EventHandler(this.announce_TextChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(428, 428);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(235, 55);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add Product";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sellP
            // 
            this.sellP.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellP.Location = new System.Drawing.Point(309, 177);
            this.sellP.Name = "sellP";
            this.sellP.Size = new System.Drawing.Size(477, 43);
            this.sellP.TabIndex = 23;
            this.sellP.TextChanged += new System.EventHandler(this.sellP_TextChanged);
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(309, 74);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(477, 43);
            this.prodName.TabIndex = 21;
            this.prodName.TextChanged += new System.EventHandler(this.prodName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(97, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selling Price (Rs.):";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(70, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Product Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(842, 51);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(68, 66);
            this.clear.TabIndex = 26;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(79, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 27;
            this.label2.Text = "Starting Stock (Rs.):";
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(309, 316);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(186, 61);
            this.stock.TabIndex = 28;
            // 
            // costP
            // 
            this.costP.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costP.Location = new System.Drawing.Point(309, 248);
            this.costP.Name = "costP";
            this.costP.Size = new System.Drawing.Size(477, 43);
            this.costP.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cost Price (Rs.):";
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1005, 569);
            this.Controls.Add(this.costP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.announce);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sellP);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "addProduct";
            this.Text = "addProduct";
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox announce;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox sellP;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown stock;
        private System.Windows.Forms.TextBox costP;
        private System.Windows.Forms.Label label3;
    }
}