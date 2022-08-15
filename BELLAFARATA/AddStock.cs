using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;

using System.IO;
using System.Drawing.Imaging;

namespace BELLAFARATA
{
    public partial class AddStock : Form
    {
        public AddStock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string choice = dataGridView1.SelectedCells[0].Value.ToString();

            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                {


                    if ((connection.ExecuteScalar($"SELECT productName FROM product WHERE productName = '{choice}'") == null))
                    {
                        prodName.Text = "";
                        stock.Text = "";


                    }
                    else
                    {
                        prodName.Text = connection.ExecuteScalar($"SELECT productName FROM product WHERE productName = '{choice}'").ToString();
                        //string amt = connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{choice}'").ToString();
                        if (connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{choice}'") == null)
                        {
                            stock.Text = "";
                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{choice}'").ToString();
                            stock.Text = stock2;
                        }

                        
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string queryString = $"SELECT productName FROM product WHERE productName LIKE '%{textBox1.Text}%'";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


            DataTable dt = new System.Data.DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Columns[0].HeaderText = "PRODUCTS:";
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 500;

            }
        }

        private void AddStock_Load(object sender, EventArgs e)
        {
            string queryString = $"SELECT productName FROM product";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


            DataTable dt = new System.Data.DataTable();
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                dataGridView1.Columns[0].HeaderText = "PRODUCTS:";
                dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("ARIAL", 30F, GraphicsUnit.Pixel);
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 500;

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double stock2;
            stock2 = double.Parse(stock.Text) + Convert.ToDouble(stocktoadd.Value);
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {
                connection.Query($"UPDATE product SET stock = {stock2} WHERE productName = '{prodName.Text}'");
            }
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {


                
                    //string amt = connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{choice}'").ToString();
                    if (connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{prodName.Text}'") == null)
                    {
                        stock.Text = "";
                    }
                    else
                    {
                        stock.Text = connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{prodName.Text}'").ToString();
                    }


                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryString = $"SELECT ROW_NUMBER() OVER(ORDER BY productName) AS #, [productName], [price], [stock] FROM[BELLA].[dbo].[product]";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);
                grid.DataSource = dt;

                var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\ProductList-{DateTime.Today.ToString("ddd dd MMM yyyy")}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\STOCK.jpg";
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
                Paragraph title = new Paragraph($"", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                grid.Columns[0].HeaderText = "#";
                grid.Columns[1].HeaderText = "Product";
                grid.Columns[2].HeaderText = "Selling Price";
                grid.Columns[3].HeaderText = "Stock";

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

                float[] widths2 = new float[] { 1f, 4f, 2f, 2f };
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

                        if ((double.TryParse(text, out d)) && (counta == 3))
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

                



                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\ProductList-{DateTime.Today.ToString("ddd dd MMM yyyy")}.pdf");



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string queryString = $"SELECT TOP (1000) [productName], [stock], [costP], [costP]*[stock] AS totalCost FROM [BELLA].[dbo].[product]";
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);
                grid.DataSource = dt;

                var pdfReport = new Document(PageSize.A4, 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\COSTREPORT-{DateTime.Today.ToString("ddd dd MMM yyyy")}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\COST.jpg";
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
                Paragraph title = new Paragraph($"Cost Report for: {DateTime.Today.ToString("ddd dd MMM yyyy")}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                grid.Columns[3].HeaderText = " Product Total Cost";
                grid.Columns[0].HeaderText = "Product";
                grid.Columns[1].HeaderText = "Cost Price";
                grid.Columns[2].HeaderText = "Stock";

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

                float[] widths2 = new float[] { 4f, 2f, 2f, 3f };
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

                        if ((double.TryParse(text, out d)) && (counta == 3))
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

                double sumINVOICE = 0;
                for (int i = 0; i < grid.Rows.Count; ++i)
                {
                    sumINVOICE += Convert.ToDouble(grid.Rows[i].Cells[3].Value);
                }

                title = new Paragraph($"NET COST OF PRODUCTS IN STOCK : Rs.{sumINVOICE}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\DAILY REPORTS\\COSTREPORT-{DateTime.Today.ToString("ddd dd MMM yyyy")}.pdf");

            }
        }
    }
}
