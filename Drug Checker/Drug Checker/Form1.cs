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

namespace Drug_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Gett_Click(object sender, EventArgs e)
        {
            try { 
            string apiUrl = "https://localhost:44370/api/Drugs/all-drugs";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            string jason = client.DownloadString(apiUrl);
            dataGridView1Drug.DataSource = (new JavaScriptSerializer()).Deserialize<List<MyDrug>>(jason);

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

                string apiUrl = "https://localhost:44370/api/Drugs/get-drug-by-id";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl + "/" + textBoxSearchID.Text);
                MyDrug myDrug = new MyDrug();
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


                string apiUrl = "https://localhost:44370/api/Drugs/add-Drug";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            MyDrug myS = new MyDrug();
            myS.Name = textBox2AddName.Text;
            myS.Price =Convert.ToDouble(textBox3AddPrice.Text);
            myS.SupplierName = textBox4AddSName.Text;
            myS.Discription = textBox5AddDesc.Text;
            myS.Quantity = Convert.ToInt32(textBox6Addqty.Text);
            myS.ExpDate = dateTimePicker1Exp.Value;
            myS.MnfDate = dateTimePicker2Mn.Value;
            myS.brandName =textBox9AddBName.Text;
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
            string apiUrl = " https://localhost:44370/api/Drugs/update-drug-by-id";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            MyDrug myS = new MyDrug();
            myS.Name = textBox2AddName.Text;
            myS.Price = Convert.ToDouble(textBox3AddPrice.Text);
            myS.SupplierName = textBox4AddSName.Text;
            myS.Discription = textBox5AddDesc.Text;
            myS.Quantity = Convert.ToInt32(textBox6Addqty.Text);
            myS.ExpDate = dateTimePicker1Exp.Value;
            myS.MnfDate = dateTimePicker2Mn.Value;
            myS.brandName = textBox9AddBName.Text;
            string info = (new JavaScriptSerializer()).Serialize(myS);
            string up = client.UploadString(apiUrl, textBoxUpdateID.Text, info);
            MessageBox.Show(up);

            }
            catch
            {
                MessageBox.Show("Error... Not Updated");
            }

        }

        private async void button5Delete_Click(object sender, EventArgs e)
        {
            try { 
            var Response = await Delete(textBoxDeleteID.Text);
               

            }
            catch
            {
                MessageBox.Show("Id Not Matched...Please try again");
            }
        }


        public static async Task<string> Delete(String id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync(" https://localhost:44370/api/Drugs/delete-drug-by-id/" + id))
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
