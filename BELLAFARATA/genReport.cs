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
using System.Reflection;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using Dapper;

namespace BELLAFARATA
{
    public partial class genReport : Form
    {
        public genReport()
        {
            InitializeComponent();
        }

        private void ExecuteGenReport_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"select invoiceNum, date, description, total from invoice WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                double sumINVOICE = 0;
                for (int i = 0; i < invoicelist.Rows.Count; ++i)
                {
                    sumINVOICE += Convert.ToDouble(invoicelist.Rows[i].Cells[3].Value);
                }


                //try
                //{
                var pdfReport = new Document(PageSize.A4.Rotate(), 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\SALES REPORTS\\SALES_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\SALESREPORT.jpg";
                using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                {
                    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    jpg.ScaleToFit(pdfReport.PageSize);
                    jpg.SetAbsolutePosition(0, 0);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    pdfReport.Add(jpg);
                }

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);


                Font titleFont = FontFactory.GetFont("Courier");
                DateTime today = DateTime.Today;

                Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
                title.Alignment = 2;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);



                title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                pdfReport.Add(spacer);

                title = new Paragraph($"SALES REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
                title.Alignment = 1;
                title.Font = FontFactory.GetFont("Courier", 16);

                pdfReport.Add(title);

                pdfReport.Add(spacer);
                //invoiceNo, date, clientName, totalCourse, coursePer, balRemaining
                invoicelist.Columns[0].HeaderText = "Invoice";
                invoicelist.Columns[1].HeaderText = "Date";
                invoicelist.Columns[2].HeaderText = "Description";
                invoicelist.Columns[3].HeaderText = "Total";
                


                PdfPTable producttable = new PdfPTable(4);
                producttable.DefaultCell.Padding = 3;
                producttable.WidthPercentage = 100;
                producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable.DefaultCell.BorderWidth = 1;
                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in invoicelist.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);
                }

                float[] widths = new float[] { 1f, 1f, 4f, 1f };
                producttable.SetWidths(widths);

                foreach (DataGridViewRow row in invoicelist.Rows)
                {
                    int counta = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text = cell.Value.ToString();
                        double d;
                        if (cell.Value == null)
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell.Value.ToString();
                        }
                        if (counta != 1)
                        {
                            if (double.TryParse(text, out d))
                            {
                                d = double.Parse(text);
                                text = String.Format("{0:f2}", d);
                            }
                        }
                        if (counta == 3)
                        {
                            //using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRENTONDB")))
                            //{
                            //    string invbrn;
                            //    string invVat;
                            //    if (connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'") == null)
                            //    {
                            //        invbrn = "";
                            //    }
                            //    else
                            //    {
                            //        invbrn = connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'").ToString();
                            //    }
                            //    if (connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'") == null)
                            //    {
                            //        invVat = "";
                            //    }
                            //    else
                            //    {
                            //        invVat = connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'").ToString();
                            //    }

                            //    ;
                            //    text = text + $" BRN:{invbrn} VAT NO:{invVat}";
                            //}


                        }
                        counta = counta + 1;
                        producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                    }
                }

                pdfReport.Add(producttable);





                title = new Paragraph($"NET TOTAL FOR SET PERIOD OF TIME: Rs. {sumINVOICE}.", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Courier", 16);
                pdfReport.Add(title);
                //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
                //title.Alignment = 0;
                //title.Font = FontFactory.GetFont("Courier", 16);
                //pdfReport.Add(title);



                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\SALES REPORTS\\SALES_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");

                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //DataTable dt2 = new DataTable();
            string queryString = $"SELECT [date], [invoice], [productName], [qty], [costP], [price], [sellP], qty*costP As total_cost, qty*sellP as total_sold, (qty*sellP)-(qty*costP) As profit  FROM [BELLA].[dbo].[productsale] WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}') ORDER BY date ASC";
            //string queryreceipt = $"select * from receipt WHERE (date_paid BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";
            var table = new DataTable();

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
            {

                SqlDataAdapter adapt = new SqlDataAdapter(queryString, connection);
                adapt.Fill(dt);

                invoicelist.DataSource = dt;

                double sumINVOICE = 0;
                double sumINVOICE2 = 0;
                for (int i = 0; i < invoicelist.Rows.Count; ++i)
                {
                    sumINVOICE += Convert.ToDouble(invoicelist.Rows[i].Cells[8].Value);
                    sumINVOICE2 += Convert.ToDouble(invoicelist.Rows[i].Cells[7].Value);

                }


                //try
                //{
                var pdfReport = new Document(PageSize.A4.Rotate(), 20f, 20f, 50f, 50f);
                Random rnd = new Random();
                int saveno = rnd.Next(1, 51);
                string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\SALES REPORTS\\PRODUCTSALES_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf";

                PdfWriter.GetInstance(pdfReport, new FileStream(path, FileMode.OpenOrCreate));
                pdfReport.Open();

                var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\PRODDSALE.jpg";
                using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                {
                    var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                    jpg.ScaleToFit(pdfReport.PageSize);
                    jpg.SetAbsolutePosition(0, 0);
                    jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                    pdfReport.Add(jpg);
                }

                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);
                pdfReport.Add(spacer);


                Font titleFont = FontFactory.GetFont("Courier");
                DateTime today = DateTime.Today;

                Paragraph title = new Paragraph($"Date Generated: {today.ToString("dd/MM/yyyy")}", titleFont);
                title.Alignment = 2;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);



                title = new Paragraph($"Selected Period of Time: {fromD.Text}/{fromM.Text}/{fromY.Text} TO {toD.Text}/{toM.Text}/{toY.Text}", titleFont);
                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Helvetica Bold", 19);
                pdfReport.Add(title);

                pdfReport.Add(spacer);

                title = new Paragraph($"SALES REPORT FOR THE SELECTED PERIOD OF TIME", titleFont);
                title.Alignment = 1;
                title.Font = FontFactory.GetFont("Courier", 16);

                pdfReport.Add(title);

                pdfReport.Add(spacer);
                //invoiceNo, date, clientName, totalCourse, coursePer, balRemaining
                invoicelist.Columns[0].HeaderText = "Date";
                invoicelist.Columns[1].HeaderText = "Invoice";
                invoicelist.Columns[2].HeaderText = "Description";
                invoicelist.Columns[3].HeaderText = "Quantity";
                invoicelist.Columns[4].HeaderText = "Cost/Unit";
                invoicelist.Columns[5].HeaderText = "Price/Unit";
                invoicelist.Columns[6].HeaderText = "Actual Sold/Unit";
                invoicelist.Columns[7].HeaderText = "Total Cost";
                invoicelist.Columns[8].HeaderText = "Total Sold";
                invoicelist.Columns[9].HeaderText = "PROFIT";

                PdfPTable producttable = new PdfPTable(10);
                producttable.DefaultCell.Padding = 3;
                producttable.WidthPercentage = 100;
                producttable.HorizontalAlignment = Element.ALIGN_LEFT;
                producttable.DefaultCell.BorderWidth = 1;
                BaseColor couleur = new BaseColor(255, 255, 255);
                Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                foreach (DataGridViewColumn column in invoicelist.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    producttable.AddCell(cell);
                }

                float[] widths = new float[] { 1.5f, 1.5f, 3f, 1f, 1f, 1f, 1f, 1f, 1f, 1f };
                producttable.SetWidths(widths);

                foreach (DataGridViewRow row in invoicelist.Rows)
                {
                    int counta = 1;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string text = cell.Value.ToString();
                        double d;
                        if (cell.Value == null)
                        {
                            text = "";
                        }
                        else
                        {
                            text = cell.Value.ToString();
                        }
                        if ((counta > 4))
                        {
                            if (double.TryParse(text, out d))
                            {
                                d = double.Parse(text);
                                text = String.Format("{0:f2}", d);
                            }
                        }
                        if (counta == 3)
                        {
                            //using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BRENTONDB")))
                            //{
                            //    string invbrn;
                            //    string invVat;
                            //    if (connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'") == null)
                            //    {
                            //        invbrn = "";
                            //    }
                            //    else
                            //    {
                            //        invbrn = connection2.ExecuteScalar($"SELECT brn FROM clients WHERE company_name = '{text}'").ToString();
                            //    }
                            //    if (connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'") == null)
                            //    {
                            //        invVat = "";
                            //    }
                            //    else
                            //    {
                            //        invVat = connection2.ExecuteScalar($"SELECT vat FROM clients WHERE company_name = '{text}'").ToString();
                            //    }

                            //    ;
                            //    text = text + $" BRN:{invbrn} VAT NO:{invVat}";
                            //}


                        }
                        counta = counta + 1;
                        producttable.AddCell(new PdfPCell(new Phrase(text, FontFactory.GetFont("Courier", 10))));
                    }
                }

                pdfReport.Add(producttable);
                string sale= "0";
                double saled = 0;
                using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                {
                    if (connection2.ExecuteScalar($"SELECT SUM(total) FROM invoice WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')") == null)
                    {

                    }
                    else
                    {
                        sale = connection2.ExecuteScalar($"SELECT SUM(total) FROM invoice WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')").ToString();
                        //WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')
                        saled = double.Parse(sale) - sumINVOICE2;
                    }

                }



                title = new Paragraph($"SALE FOR SET PERIOD OF TIME: Rs. {sale}.", titleFont);

                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Courier", 16);
                pdfReport.Add(title);
                title = new Paragraph($"PROFIT FOR SET PERIOD OF TIME: Rs. {saled}.", titleFont);

                title.Alignment = 0;
                title.Font = FontFactory.GetFont("Courier", 16);
                pdfReport.Add(title);


                using (IDbConnection connection2 = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                {
                    if (connection2.ExecuteScalar($"SELECT TOP 1 productName  FROM [BELLA].[dbo].[productsale] WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}') GROUP BY productName  ORDER BY SUM((qty*sellP)-(qty*costP)) DESC") == null)
                    {
                        
                    }
                    else
                    {
                        string addd = connection2.ExecuteScalar($"SELECT TOP 1 productName  FROM [BELLA].[dbo].[productsale] WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}') GROUP BY productName  ORDER BY SUM((qty*sellP)-(qty*costP)) DESC").ToString();
                        //WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')
                        string add = connection2.ExecuteScalar($"SELECT TOP 1 SUM((qty*sellP)-(qty*costP)) As profit  FROM [BELLA].[dbo].[productsale] WHERE (date BETWEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}') GROUP BY productName  ORDER BY SUM((qty*sellP)-(qty*costP)) DESC ").ToString();
                        title = new Paragraph($"Most profitable product is {addd} with Rs. {add} profit.");
                    }

                    title.Alignment = 0;
                    title.Font = FontFactory.GetFont("Courier", 16);
                    pdfReport.Add(title);

                }
                //title = new Paragraph($"TOTAL TAX: Rs. {taxamt}.", titleFont);
                //title.Alignment = 0;
                //title.Font = FontFactory.GetFont("Courier", 16);
                //pdfReport.Add(title);



                pdfReport.Close();

                System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\SALES REPORTS\\PRODUCTSALES_{fromY.Text}-{fromM.Text}-{fromD.Text} to {toY.Text}-{toM.Text}-{toD.Text}.pdf");


            }
        }
    }
}
