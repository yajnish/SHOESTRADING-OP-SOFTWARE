
namespace BELLAFARATA
{
    partial class genReport
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
            this.ExecuteGenReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toY = new System.Windows.Forms.ComboBox();
            this.toM = new System.Windows.Forms.ComboBox();
            this.toD = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromY = new System.Windows.Forms.ComboBox();
            this.fromM = new System.Windows.Forms.ComboBox();
            this.fromD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invoicelist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).BeginInit();
            this.SuspendLayout();
            // 
            // ExecuteGenReport
            // 
            this.ExecuteGenReport.BackColor = System.Drawing.Color.MediumPurple;
            this.ExecuteGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExecuteGenReport.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteGenReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExecuteGenReport.Location = new System.Drawing.Point(38, 253);
            this.ExecuteGenReport.Name = "ExecuteGenReport";
            this.ExecuteGenReport.Size = new System.Drawing.Size(327, 99);
            this.ExecuteGenReport.TabIndex = 55;
            this.ExecuteGenReport.Text = "GET SALES REPORT";
            this.ExecuteGenReport.UseVisualStyleBackColor = false;
            this.ExecuteGenReport.Click += new System.EventHandler(this.ExecuteGenReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(463, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "DD            MM              YYYY";
            // 
            // toY
            // 
            this.toY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toY.FormattingEnabled = true;
            this.toY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.toY.Location = new System.Drawing.Point(610, 145);
            this.toY.Name = "toY";
            this.toY.Size = new System.Drawing.Size(121, 46);
            this.toY.TabIndex = 53;
            this.toY.Text = "2022";
            // 
            // toM
            // 
            this.toM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toM.FormattingEnabled = true;
            this.toM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.toM.Location = new System.Drawing.Point(531, 145);
            this.toM.Name = "toM";
            this.toM.Size = new System.Drawing.Size(73, 46);
            this.toM.TabIndex = 52;
            this.toM.Text = "01";
            // 
            // toD
            // 
            this.toD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toD.FormattingEnabled = true;
            this.toD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.toD.Location = new System.Drawing.Point(452, 145);
            this.toD.Name = "toD";
            this.toD.Size = new System.Drawing.Size(73, 46);
            this.toD.TabIndex = 51;
            this.toD.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(529, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 50;
            this.label2.Text = "TO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(64, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "DD            MM              YYYY";
            // 
            // fromY
            // 
            this.fromY.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromY.FormattingEnabled = true;
            this.fromY.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.fromY.Location = new System.Drawing.Point(201, 145);
            this.fromY.Name = "fromY";
            this.fromY.Size = new System.Drawing.Size(145, 46);
            this.fromY.TabIndex = 48;
            this.fromY.Text = "2022";
            // 
            // fromM
            // 
            this.fromM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromM.FormattingEnabled = true;
            this.fromM.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.fromM.Location = new System.Drawing.Point(119, 145);
            this.fromM.Name = "fromM";
            this.fromM.Size = new System.Drawing.Size(76, 46);
            this.fromM.TabIndex = 47;
            this.fromM.Text = "01";
            // 
            // fromD
            // 
            this.fromD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromD.FormattingEnabled = true;
            this.fromD.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.fromD.Location = new System.Drawing.Point(38, 145);
            this.fromD.Name = "fromD";
            this.fromD.Size = new System.Drawing.Size(75, 46);
            this.fromD.TabIndex = 46;
            this.fromD.Text = "01";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(113, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "FROM: ";
            // 
            // invoicelist
            // 
            this.invoicelist.AllowUserToAddRows = false;
            this.invoicelist.AllowUserToDeleteRows = false;
            this.invoicelist.AllowUserToResizeColumns = false;
            this.invoicelist.AllowUserToResizeRows = false;
            this.invoicelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicelist.Location = new System.Drawing.Point(40, 433);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.RowHeadersWidth = 56;
            this.invoicelist.RowTemplate.Height = 24;
            this.invoicelist.Size = new System.Drawing.Size(725, 192);
            this.invoicelist.TabIndex = 56;
            this.invoicelist.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 19.93846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(404, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 99);
            this.button1.TabIndex = 57;
            this.button1.Text = "GET PRODUCTS SALES REPORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(762, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.ExecuteGenReport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toY);
            this.Controls.Add(this.toM);
            this.Controls.Add(this.toD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromY);
            this.Controls.Add(this.fromM);
            this.Controls.Add(this.fromD);
            this.Controls.Add(this.label3);
            this.Name = "genReport";
            this.Text = "genReport";
            ((System.ComponentModel.ISupportInitialize)(this.invoicelist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteGenReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox toY;
        private System.Windows.Forms.ComboBox toM;
        private System.Windows.Forms.ComboBox toD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox fromY;
        private System.Windows.Forms.ComboBox fromM;
        private System.Windows.Forms.ComboBox fromD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView invoicelist;
        private System.Windows.Forms.Button button1;
    }
}