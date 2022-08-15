using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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


namespace BELLAFARATA
{
    public partial class sales : Form
    {
        public sales()
        {
            InitializeComponent();
        }

        private void sales_Load(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                        sellP.Text = "";


                    }
                    else
                    {
                        prodName.Text = connection.ExecuteScalar($"SELECT productName FROM product WHERE productName = '{choice}'").ToString();
                        string amt = connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{choice}'").ToString();
                        if(connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{choice}'") == null)
                        {
                            stock.Text = "";
                        }
                        else
                        {
                            string stock2 = connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{choice}'").ToString();
                            stock.Text = stock2;
                        }
                        
                        double amtd = double.Parse(amt);
                        sellP.Text = amtd.ToString("#.00");
                    }
                }

            }
            catch (Exception)
            {

            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(qty.Text, out d))
            {
                double quan = double.Parse(qty.Text);
                quan++;

                qty.Text = $"{quan}";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(qty.Text, out d))
            {
                double quan = double.Parse(qty.Text);
                if (quan > 0)
                {
                    quan--;
                }

                qty.Text = $"{quan}";
            }
            
        }

        private void clear_Click(object sender, EventArgs e)
        {
            qty.Text = "0";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int check = 0;
            double price=0;
            double quan=0;
            try
            {
                price = double.Parse(sellP.Text);
                quan = double.Parse(qty.Text);
            }
            catch (Exception)
            {
                check = 1;
                MessageBox.Show("Fill correct information");
            }

            if (check != 1)
            {
                dataGridView2.Rows.Add(quan, $"{prodName.Text}", price, $"{quan*price}");
                
                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                }
                total.Text = sum.ToString();


            }


        }

        private void dataGridView2_RowDeleting(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        string invoicetext;
        public string yeartoday = DateTime.Now.ToString("yyyy"); //current year
        private void button3_Click(object sender, EventArgs e)
        {
            invoicetext = "";
            DialogResult choice;
            choice = MessageBox.Show($"Approve Transaction?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {

                double number = 0;
                try
                {
                    string num;

                    string yr;
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                    {
                        num = connection.ExecuteScalar($"SELECT TOP 1 counter FROM counter ORDER BY counter DESC").ToString();
                        yr = connection.ExecuteScalar($"SELECT TOP 1 year FROM counter ORDER BY counter DESC").ToString();
                    }
                    if (yeartoday == yr)
                    {
                        number = double.Parse(num);
                        number++;
                    }
                    else
                    {
                        number = 1;
                    }

                    
                    invoicetext = $"{yeartoday}{number.ToString().PadLeft(6, '0')}";
                    

                }
                catch (Exception)
                {

                }

                if((invoicetext!= "")&&(dataGridView2.Rows.Count!=0))
                {
                    string descriptionallprod = "";
                    string updatestock = "";
                    string stock2, costprice, sellprice, productsale = "";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {
                            if (connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'")== null)
                            {
                                stock2 = "0";
                            }
                            else
                            {
                                stock2 = connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }

                            if (connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'") == null)
                            {
                                sellprice = "0";
                            }
                            else
                            {
                                sellprice = connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }

                            if (connection.ExecuteScalar($"SELECT costP FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'") == null)
                            {
                                costprice = "0";
                            }
                            else
                            {
                                costprice = connection.ExecuteScalar($"SELECT costP FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }

                        }
                        double newstock = double.Parse(stock2) - Convert.ToDouble((dataGridView2.Rows[i].Cells[0].Value));
                        descriptionallprod = descriptionallprod + $"{dataGridView2.Rows[i].Cells[0].Value}X {dataGridView2.Rows[i].Cells[1].Value}, ";
                        updatestock = updatestock + $"UPDATE product SET stock = {newstock} WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}' ";
                        productsale = productsale + $"INSERT INTO productsale(invoice, productName, qty, costP, price, sellP) VALUES ('{invoicetext}', '{dataGridView2.Rows[i].Cells[1].Value}', '{dataGridView2.Rows[i].Cells[0].Value}', '{costprice}', '{sellprice}', '{dataGridView2.Rows[i].Cells[2].Value}') ";

                    }

                    try
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {
                            connection.Query($"INSERT INTO invoice (invoiceNum, description, total) VALUES ('{invoicetext}', '{descriptionallprod}', '{total.Text}')");
                            connection.Query($"INSERT INTO counter (counter, year) VALUES ('{number}', '{yeartoday}')");
                            connection.Query(updatestock);
                            connection.Query(productsale);
                        }
                        MessageBox.Show("Successful!");
                        dataGridView2.Rows.Clear();
                        total.Text = "0";
                        prodName.Text = "";
                        sellP.Text = "";
                        stock.Text = "";
                    }
                    catch (Exception)
                    {
                        
                    }
                    

                }
                else
                {
                    MessageBox.Show("ERROR! Table is null. Invoice number has not been generated.");
                }

            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count != 0)
            {
                double sum = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    sum += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                }
                decimal d;
                if(decimal.TryParse(discount.Text, out d))
                {
                    sum = sum - double.Parse(discount.Text);
                    total.Text = sum.ToString("0.00");
                }
                else
                {
                    total.Text = sum.ToString("0.00");
                }
                
            }
            else
            {
                total.Text = "0";
            }
        }

        private void approvePrint_Click(object sender, EventArgs e)
        {
            invoicetext = "";
            DialogResult choice;
            choice = MessageBox.Show($"Approve Transaction?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {

                double number = 0;
                try
                {
                    string num;

                    string yr;
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                    {
                        num = connection.ExecuteScalar($"SELECT TOP 1 counter FROM counter ORDER BY counter DESC").ToString();
                        yr = connection.ExecuteScalar($"SELECT TOP 1 year FROM counter ORDER BY counter DESC").ToString();
                    }
                    if (yeartoday == yr)
                    {
                        number = double.Parse(num);
                        number++;
                    }
                    else
                    {
                        number = 1;
                    }


                    invoicetext = $"{yeartoday}{number.ToString().PadLeft(6, '0')}";


                }
                catch (Exception)
                {

                }

                if ((invoicetext != "") && (dataGridView2.Rows.Count != 0))
                {
                    string descriptionallprod = "";
                    string updatestock = "";
                    string stock2, costprice, sellprice, productsale = "";
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {
                            if (connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'") == null)
                            {
                                stock2 = "0";
                            }
                            else
                            {
                                stock2 = connection.ExecuteScalar($"SELECT stock FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }
                            if (connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'") == null)
                            {
                                sellprice = "0";
                            }
                            else
                            {
                                sellprice = connection.ExecuteScalar($"SELECT price FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }

                            if (connection.ExecuteScalar($"SELECT costP FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'") == null)
                            {
                                costprice = "0";
                            }
                            else
                            {
                                costprice = connection.ExecuteScalar($"SELECT costP FROM product WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}'").ToString();
                            }

                        }
                        double newstock = double.Parse(stock2) - Convert.ToDouble((dataGridView2.Rows[i].Cells[0].Value));
                        descriptionallprod = descriptionallprod + $"{dataGridView2.Rows[i].Cells[0].Value}X {dataGridView2.Rows[i].Cells[1].Value}, ";
                        productsale = productsale + $"INSERT INTO productsale(invoice, productName, qty, costP, price, sellP) VALUES ('{invoicetext}', '{dataGridView2.Rows[i].Cells[1].Value}', '{dataGridView2.Rows[i].Cells[0].Value}', '{costprice}', '{sellprice}', '{dataGridView2.Rows[i].Cells[2].Value}') ";
                        updatestock = updatestock + $"UPDATE product SET stock = {newstock} WHERE productName = '{dataGridView2.Rows[i].Cells[1].Value}' ";
                    }
                    try
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {
                            connection.Query($"INSERT INTO invoice (invoiceNum, description, total) VALUES ('{invoicetext}', '{descriptionallprod}', '{total.Text}')");
                            connection.Query($"INSERT INTO counter (counter, year) VALUES ('{number}', '{yeartoday}')");
                            connection.Query(updatestock);
                            connection.Query(productsale);
                        }
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERROR! Sale not recorded in database. Try Again.");
                    }
                    try
                    {
                        try
                        {
                            var pdfInvoice = new Document(PageSize.A4, 50f, 50f, 45f, 50f);
                            string path = $"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\INVOICES\\INV{invoicetext}.pdf";
                            PdfWriter.GetInstance(pdfInvoice, new FileStream(path, FileMode.OpenOrCreate));
                            pdfInvoice.Open();

                            var imagepth = @"C:\Users\maste\Desktop\SHOES TRADING SOFTWARE\RESOURCES\INVOICE.jpg";
                            using (FileStream fs = new FileStream(imagepth, FileMode.Open))
                            {
                                var jpg = Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
                                jpg.ScaleToFit(pdfInvoice.PageSize);
                                jpg.SetAbsolutePosition(0, 0);
                                jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
                                pdfInvoice.Add(jpg);
                            }

                            var spacer = new Paragraph("")
                            {
                                SpacingBefore = 10f,
                                SpacingAfter = 10f,
                            };
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer);

                            Font titleFont = FontFactory.GetFont("Helvetica", 12);


                            Paragraph title = new Paragraph($"", titleFont);

                            title.Alignment = 2;
                            pdfInvoice.Add(title);

                            


                            titleFont = FontFactory.GetFont("Helvetica", 12);

                            var spacerx = new Paragraph("")
                            {
                                SpacingBefore = 2f,
                                SpacingAfter = 2f,
                            };
                            pdfInvoice.Add(spacerx);
                            pdfInvoice.Add(spacerx);
                            pdfInvoice.Add(spacerx);

                            Paragraph dateToday = new Paragraph($"{DateTime.Now.ToString("ddd dd MMMM yyyy")}", titleFont);
                            dateToday.Alignment = 2;

                            pdfInvoice.Add(dateToday);

                            pdfInvoice.Add(spacerx);

                            var spacer4 = new Paragraph("")
                            {
                                SpacingBefore = 0.5f,
                                SpacingAfter = 0.5f,
                            };

                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);

                            var invoicenum = new Paragraph($"{invoicetext}", titleFont);
                            invoicenum.Alignment = 2;
                            pdfInvoice.Add(invoicenum);

                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer);
                            pdfInvoice.Add(spacer4); pdfInvoice.Add(spacer4);
                            Paragraph compName = new Paragraph($"                     {name.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);



                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);

                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                     {contacts.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacer4);
                            pdfInvoice.Add(spacerx);

                            compName = new Paragraph($"                     {address.Text}", titleFont);
                            compName.Alignment = 0;
                            pdfInvoice.Add(compName);

                            
                            

                            pdfInvoice.Add(spacer4);
                            
                            pdfInvoice.Add(spacerx);

                            
                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);


                            //Font titleFont2 = FontFactory.GetFont("Helvetica Bold", 12);
                            PdfPCell cell = new PdfPCell();
                            PdfPTable producttable = new PdfPTable(dataGridView2.ColumnCount);
                            producttable.DefaultCell.Padding = 8;
                            producttable.WidthPercentage = 100;
                            producttable.HorizontalAlignment = Element.ALIGN_RIGHT;
                            producttable.DefaultCell.BorderWidth = 0;
                            BaseColor couleur = new BaseColor(255, 255, 255);
                            Font titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);
                            foreach (DataGridViewColumn column in dataGridView2.Columns)
                            {
                                cell = new PdfPCell(new Phrase(column.HeaderText, titleFont3));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(0, 0, 0);
                                producttable.AddCell(cell);
                            }
                            float[] widths = new float[] { 0.65f, 3.5f, 0.80f, 0.80f };
                            producttable.SetWidths(widths);


                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                foreach (DataGridViewCell cell1 in row.Cells)
                                {
                                    string text = cell1.Value.ToString();

                                    producttable.AddCell(new PdfPCell(new Phrase(text, titleFont)));
                                }
                            }

                            pdfInvoice.Add(spacerx); pdfInvoice.Add(spacerx);

                            pdfInvoice.Add(producttable);

                            PdfPTable tabletotal = new PdfPTable(2);
                            tabletotal.DefaultCell.Padding = 8;
                            tabletotal.WidthPercentage = 40;
                            tabletotal.HorizontalAlignment = Element.ALIGN_RIGHT;

                            tabletotal.DefaultCell.BorderWidth = 1;
                            couleur = new BaseColor(0, 0, 0);
                            titleFont3 = FontFactory.GetFont("Helvetica Bold", 10, couleur);

                            widths = new float[] { 1.5f, 1f };
                            tabletotal.SetWidths(widths);

                            cell = new PdfPCell(new Phrase("SUB-TOTAL:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            double sum1 = 0;
                            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                            {
                                sum1 += Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                            }

                            cell = new PdfPCell(new Phrase($"{sum1}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase("DISCOUNT:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{discount.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);


                            cell = new PdfPCell(new Phrase("TOTAL:", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);

                            cell = new PdfPCell(new Phrase($"{total.Text}", titleFont3));
                            cell.HorizontalAlignment = 2;
                            tabletotal.AddCell(cell);


                            pdfInvoice.Add(tabletotal);



                            pdfInvoice.Close();


                            System.Diagnostics.Process.Start($"C:\\Users\\maste\\Desktop\\SHOES TRADING SOFTWARE\\INVOICES\\INV{invoicetext}.pdf");

                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error approving transaction for VAT INVOICE!");
                        }
                    }
                    catch(Exception)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ERROR! Table is null. Invoice number has not been generated.");
                }

            }
            dataGridView2.Rows.Clear();
            total.Text = "0";
            prodName.Text = "";
            sellP.Text = "";
            stock.Text = "";
            name.Text = "";
            contacts.Text = "";
            address.Text = "";
        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {

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
    }
}
