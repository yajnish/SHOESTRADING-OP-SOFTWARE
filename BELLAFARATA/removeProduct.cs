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
namespace BELLAFARATA
{
    public partial class removeProduct : Form
    {
        public removeProduct()
        {
            InitializeComponent();
        }

        private void removeProduct_Load(object sender, EventArgs e)
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
                dataGridView1.DefaultCellStyle.Font = new Font("ARIAL", 30F, GraphicsUnit.Pixel);
                DataGridViewColumn column = dataGridView1.Columns[0];
                column.Width = 500;
                
            }
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
                        double amtd = double.Parse(amt);
                        sellP.Text = amtd.ToString("#.00");
                    }
                }

            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(sellP.Text, out d))
            {
                try
                {
                    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                    {

                        connection.Query($"UPDATE product SET price = {sellP.Text} WHERE productName = '{prodName.Text}'");
                        announce.Text = "Price updated successfully!";
                        string queryString = $"SELECT productName FROM product";
                        //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                        DataTable dt = new System.Data.DataTable();
                        using (SqlConnection conne = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {

                            SqlDataAdapter adapt = new SqlDataAdapter(queryString, conne);
                            adapt.Fill(dt);

                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoResizeColumns();
                            dataGridView1.Columns[0].HeaderText = "PRODUCTS:";
                            dataGridView1.DefaultCellStyle.Font = new Font("ARIAL", 30F, GraphicsUnit.Pixel);
                            DataGridViewColumn column = dataGridView1.Columns[0];
                            column.Width = 500;
                            
                        }
                    }
                }
                catch (Exception)
                {
                    announce.Text = "ERROR! Product not found.";
                }
                


            }
            else
            {
                announce.Text = "ERROR! Enter correct details please.";
            }
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                {
                    connection.Query($"DELETE FROM product WHERE productName = '{prodName.Text}'");
                    announce.Text = "Product removed!";
                    string queryString = $"SELECT productName FROM product";
                    //string queryreceipt = $"select * from receipt WHERE (date_paid BETEEN '{fromY.Text}-{fromM.Text}-{fromD.Text}'AND '{toY.Text}-{toM.Text}-{toD.Text}')";


                    DataTable dt = new System.Data.DataTable();
                    using (SqlConnection conn = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                    {

                        SqlDataAdapter adapt = new SqlDataAdapter(queryString, conn);
                        adapt.Fill(dt);

                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoResizeColumns();
                        dataGridView1.Columns[0].HeaderText = "PRODUCTS:";
                        dataGridView1.DefaultCellStyle.Font = new Font("ARIAL", 30F, GraphicsUnit.Pixel);
                        DataGridViewColumn column = dataGridView1.Columns[0];
                        column.Width = 500;
                        
                    }
                }
            }
            catch (Exception)
            {
                announce.Text = "ERROR! Product already does not exist.";
            }
        }
    }
}
