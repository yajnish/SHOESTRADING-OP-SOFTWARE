
namespace BELLAFARATA
{
    partial class removeProduct
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.announce = new System.Windows.Forms.TextBox();
            this.remButton = new System.Windows.Forms.Button();
            this.sellP = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(379, 796);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // announce
            // 
            this.announce.BackColor = System.Drawing.Color.MistyRose;
            this.announce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.announce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.announce.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.27692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.announce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.announce.Location = new System.Drawing.Point(479, 419);
            this.announce.Name = "announce";
            this.announce.ReadOnly = true;
            this.announce.Size = new System.Drawing.Size(711, 35);
            this.announce.TabIndex = 31;
            this.announce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // remButton
            // 
            this.remButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.remButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remButton.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remButton.Location = new System.Drawing.Point(1036, 273);
            this.remButton.Name = "remButton";
            this.remButton.Size = new System.Drawing.Size(154, 104);
            this.remButton.TabIndex = 30;
            this.remButton.Text = "Remove Product";
            this.remButton.UseVisualStyleBackColor = false;
            this.remButton.Click += new System.EventHandler(this.remButton_Click);
            // 
            // sellP
            // 
            this.sellP.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellP.Location = new System.Drawing.Point(713, 178);
            this.sellP.Name = "sellP";
            this.sellP.Size = new System.Drawing.Size(477, 43);
            this.sellP.TabIndex = 29;
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(713, 75);
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Size = new System.Drawing.Size(477, 43);
            this.prodName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(501, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 30);
            this.label4.TabIndex = 27;
            this.label4.Text = "Selling Price (Rs.):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12.18462F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(531, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "Product Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(795, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 104);
            this.button1.TabIndex = 32;
            this.button1.Text = "Edit Price";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1282, 846);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.announce);
            this.Controls.Add(this.remButton);
            this.Controls.Add(this.sellP);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "removeProduct";
            this.Text = "removeProduct";
            this.Load += new System.EventHandler(this.removeProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox announce;
        private System.Windows.Forms.Button remButton;
        private System.Windows.Forms.TextBox sellP;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}