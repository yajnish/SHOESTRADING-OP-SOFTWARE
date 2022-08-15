using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace BELLAFARATA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            addProduct addprod = new addProduct();
            addprod.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            removeProduct remProd = new removeProduct();
            remProd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sales sale = new sales();
            sale.Show();
        }
        public string datetoday = DateTime.Now.ToString("yyyy/MM/dd");
        public string datetoday1 = DateTime.Now.ToString("ddd dd MMMM yyyy");
        public string datetoday2 = DateTime.Now.ToString("dd-MMMM-yyyy");
        private void button3_Click(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            string queryString = $"SELECT invoiceNum, description, total FROM invoice WHERE date = '{datetoday}'";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);
                grid.DataSource = dt;

                var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\DailyReport-{datetoday2}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\DAILY.jpg";
                using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                {
                    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    jpg.ScaleToFit(pdfReport.PageSize);
                    jpg.SetAbsolutePosition(0, 0);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    pdfReport.Add(jpg);
                }
                Font titleFont = FontFactory.GetFont("Courier");

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                Paragraph title = new Paragraph($"Report for: {DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                grid.Columns[0].HeaderText = "Invoice Number";
                //grid.Columns[1].HeaderText = "Date";
                grid.Columns[1].HeaderText = "Description";
                grid.Columns[2].HeaderText = "Amount";

                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                PdfPTable producttable2 = new PdfPTable(grid.ColumnCount);
                producttable2.DefaultCell.Padding = 3;
                producttable2.WidthPercentage = 100;
                producttable2.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable2.DefaultCell.BorderWidth = 1;
                couleur = new BaseColor(255, 255, 255);
                titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable2.AddCell(cell);
                }

                float[] widths2 = new float[] { 1f, 4f, 1f };
                producttable2.SetWidths(widths2);

                foreach (DataGridViewRow row in grid.Rows)
                {
                    int counta = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text;
                        if ((cell.Value == null))
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell.Value.ToString();
                        }


                        double d;

                        if ((double.TryParse(text, out d)) && (counta != 1))
                        {
                            d = double.Parse(text);
                            text = String.Format("{0:f2}", d);
                        }
                        


                        counta = counta + 1;

                        producttable2.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));



                    }
                }
                pdfReport.Add(spacer);

                


                pdfReport.Add(producttable2);

                pdfReport.Add(spacer);
                double sum = 0;
                for (int i = 0; i < grid.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(grid.Rows[i].Cells[2].Value);
                }
                title = new Paragraph($"TOTAL FOR TODAY: Rs. {sum}", titleFont);
                pdfReport.Add(title);



                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\DailyReport-{datetoday2}.pdf");



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            genReport gen = new genReport();
            gen.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addStock_Click(object sender, EventArgs e)
        {
            AddStock add = new AddStock();
            add.Show();
        }
    }
}
