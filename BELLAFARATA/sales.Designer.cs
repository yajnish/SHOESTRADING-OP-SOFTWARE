
namespace BELLAFARATA
{
    partial class sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.qty = new System.Windows.Forms.TextBox();
            this.sellP = new System.Windows.Forms.TextBox();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.quantt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.discount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.approvePrint = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contacts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(379, 860);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.qty);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(421, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QUANTITY";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.Location = new System.Drawing.Point(146, 211);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(83, 73);
            this.clear.TabIndex = 48;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(146, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 68);
            this.button2.TabIndex = 36;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(11, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 68);
            this.button1.TabIndex = 35;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(11, 32);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(218, 87);
            this.qty.TabIndex = 34;
            this.qty.Text = "1";
            // 
            // sellP
            // 
            this.sellP.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellP.Location = new System.Drawing.Point(421, 125);
            this.sellP.Name = "sellP";
            this.sellP.Size = new System.Drawing.Size(251, 43);
            this.sellP.TabIndex = 33;
            // 
            // prodName
            // 
            this.prodName.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodName.Location = new System.Drawing.Point(421, 44);
            this.prodName.Name = "prodName";
            this.prodName.ReadOnly = true;
            this.prodName.Size = new System.Drawing.Size(251, 43);
            this.prodName.TabIndex = 32;
            this.prodName.TextChanged += new System.EventHandler(this.prodName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(417, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Selling Price (Rs.):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(417, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product Name:";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addButton.Location = new System.Drawing.Point(421, 579);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(251, 112);
            this.addButton.TabIndex = 34;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quantt,
            this.desc,
            this.unitP,
            this.val});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Location = new System.Drawing.Point(740, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(834, 593);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // quantt
            // 
            this.quantt.HeaderText = "QTY";
            this.quantt.MinimumWidth = 6;
            this.quantt.Name = "quantt";
            this.quantt.ReadOnly = true;
            this.quantt.Width = 125;
            // 
            // desc
            // 
            this.desc.HeaderText = "DESCRIPTION";
            this.desc.MinimumWidth = 6;
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 350;
            // 
            // unitP
            // 
            this.unitP.HeaderText = "UNIT PRICE";
            this.unitP.MinimumWidth = 6;
            this.unitP.Name = "unitP";
            this.unitP.ReadOnly = true;
            this.unitP.Width = 125;
            // 
            // val
            // 
            this.val.HeaderText = "VALUE";
            this.val.MinimumWidth = 6;
            this.val.Name = "val";
            this.val.ReadOnly = true;
            this.val.Width = 125;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(811, 835);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(300, 99);
            this.total.TabIndex = 36;
            this.total.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(806, 804);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "TOTAL (Rs.):";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1210, 677);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(364, 112);
            this.button3.TabIndex = 38;
            this.button3.Text = "APPROVE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // discount
            // 
            this.discount.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.Location = new System.Drawing.Point(811, 702);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(300, 99);
            this.discount.TabIndex = 39;
            this.discount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(806, 670);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "DISCOUNT (Rs.):";
            // 
            // approvePrint
            // 
            this.approvePrint.BackColor = System.Drawing.Color.PaleTurquoise;
            this.approvePrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approvePrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.approvePrint.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvePrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.approvePrint.Location = new System.Drawing.Point(1210, 829);
            this.approvePrint.Name = "approvePrint";
            this.approvePrint.Size = new System.Drawing.Size(364, 112);
            this.approvePrint.TabIndex = 41;
            this.approvePrint.Text = "APPROVE AND GENERATE INVOICE";
            this.approvePrint.UseVisualStyleBackColor = false;
            this.approvePrint.Click += new System.EventHandler(this.approvePrint_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(421, 730);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(335, 50);
            this.name.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(417, 704);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "CLIENT NAME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(417, 784);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 23);
            this.label6.TabIndex = 45;
            this.label6.Text = "CLIENT CONTACTS:";
            // 
            // contacts
            // 
            this.contacts.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts.Location = new System.Drawing.Point(421, 810);
            this.contacts.Name = "contacts";
            this.contacts.Size = new System.Drawing.Size(335, 50);
            this.contacts.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(417, 862);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "CLIENT ADDRESS:";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Arial Narrow", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(421, 888);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(335, 50);
            this.address.TabIndex = 46;
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.Location = new System.Drawing.Point(421, 201);
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Size = new System.Drawing.Size(251, 43);
            this.stock.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(417, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = "Current Stock:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 43);
            this.textBox1.TabIndex = 50;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1631, 953);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contacts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.approvePrint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sellP);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sales";
            this.Load += new System.EventHandler(this.sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox sellP;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantt;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitP;
        private System.Windows.Forms.DataGridViewTextBoxColumn val;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button approvePrint;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox contacts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}