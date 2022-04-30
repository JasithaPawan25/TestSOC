using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Order_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Get_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://localhost:44370/api/Orders/all-orders";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl);
                dataGridViewOrder.DataSource = (new JavaScriptSerializer()).Deserialize<List<MyOrder>>(jason);
            }
            catch
            {
                MessageBox.Show("Please Try Again");
            }
        }

        private void button2Search_Click(object sender, EventArgs e)
        {
            try
            {

                string apiUrl = "https://localhost:44370/api/Orders/get-order-by-id";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl + "/" + textBox1SearchID.Text);
                MyOrder myOrder = new MyOrder();
                MessageBox.Show(jason);

            }
            catch
            {
                MessageBox.Show("Supplier Not Found");
            }
        }

        private void button3Add_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://localhost:44370/api/Orders/add-order";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                MyOrder myS = new MyOrder();
                myS.DrugName = textBox2AddDName.Text;
                myS.DrugQty = Convert.ToInt32(textBox3AddQty.Text);
                myS.DrugPrice = Convert.ToDouble(textBox4AddPrice.Text);
                myS.Description = textBox5AddDesc.Text;
                myS.PharmacyName = textBox6AddPhaName.Text;
                myS.PharmacyAddress = textBox7AddPhaAddress.Text;
                myS.PharmacyCity = textBox8AddPharCity.Text;
                myS.PharmacyContactNO = Convert.ToInt32(textBox9AddPhaContact.Text);

                string info = (new JavaScriptSerializer()).Serialize(myS);
                string up = client.UploadString(apiUrl, info);
                MessageBox.Show(up);

            }
            catch
            {
                MessageBox.Show("Error... Not Added");
            }

        }

        private void button4Update_Click(object sender, EventArgs e)
        {

            try
            {

                string apiUrl = "https://localhost:44370/api/Orders/update-order-by-id";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                MyOrder myS = new MyOrder();
                myS.DrugName = textBox2AddDName.Text;
                myS.DrugQty = Convert.ToInt32(textBox3AddQty.Text);
                myS.DrugPrice = Convert.ToDouble(textBox4AddPrice.Text);
                myS.Description = textBox5AddDesc.Text;
                myS.PharmacyName = textBox6AddPhaName.Text;
                myS.PharmacyAddress = textBox7AddPhaAddress.Text;
                myS.PharmacyCity = textBox8AddPharCity.Text;
                myS.PharmacyContactNO = Convert.ToInt32(textBox9AddPhaContact.Text);

                string info = (new JavaScriptSerializer()).Serialize(myS);
                string up = client.UploadString(apiUrl, textBox10UpdateID.Text, info);
                MessageBox.Show(up);
            }catch
            {
                MessageBox.Show("Error... Not Updated");
            }

        }

        private async void button5Delete_Click(object sender, EventArgs e)
        {
            try
            {
                var Response = await Delete(textBox11DeleteID.Text);
            }catch
            {
                MessageBox.Show("Id Not Matched...Please try again");
            }

        }


        public static async Task<string> Delete(String id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync(" https://localhost:44370/api/Orders/delete-order-by-id/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show("Deleted");

                        string data = await content.ReadAsStringAsync();

                        if (data != null)
                        {
                            return data;
                        }
                    }


                }
            }

            return string.Empty;
        }






    }
}
