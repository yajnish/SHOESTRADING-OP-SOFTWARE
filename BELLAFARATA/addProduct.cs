using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;


namespace BELLAFARATA
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((prodName.Text != "") && (sellP.Text != ""))
            {

                decimal d; decimal c;
                if ((decimal.TryParse(sellP.Text, out d))&&(decimal.TryParse(stock.Text, out c)))
                {
                    try
                    {
                        using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(helper.connectproduct("BELLADB")))
                        {

                            connection.Query($"INSERT INTO product(productname, price, stock, costP) VALUES ('{ prodName.Text}', '{ sellP.Text }', '{stock.Value}', '{costP.Text}')");
                            announce.Text = "Product added successfully!";
                        }
                    }
                    catch (Exception)
                    {
                        announce.Text = "Product Already Exists! Error!";
                    }
                        
                    

                }
                else
                {
                    announce.Text = "ERROR! Enter correct details please.";
                }

            }
            else
            {
                announce.Text = "Fill all information please!";
            }
        }

        private void prodName_TextChanged(object sender, EventArgs e)
        {
            announce.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            announce.Text = "";
            sellP.Text = "";
            prodName.Text = "";
        }

        private void announce_TextChanged(object sender, EventArgs e)
        {

        }

        private void sellP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
