using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupplierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var Response = await Helper.GetAll();
            txtrichbox.Text = Helper.BeautifyJson(Response);
           // dgvSupplier.DataSource = Response;

        }

        private async void button3IDSearch_Click(object sender, EventArgs e)
        {
            var Response = await Helper.Get(txtID.Text);
            txtrichbox.Text = Helper.BeautifyJson(Response);

        }

        private async void button4Add_Click(object sender, EventArgs e)
        {
            var Response = await Helper.Post(txtaddname.Text,txtaddjob.Text);
            txtrichbox.Text = Helper.BeautifyJson(Response);

        }

        private async void button2Update_Click(object sender, EventArgs e)
        {
            var Response = await Helper.Put(textID.Text,textName.Text,textJob.Text);
            txtrichbox.Text = Helper.BeautifyJson(Response);


        }

        private async void button2Delete_Click(object sender, EventArgs e)
        {
            var Response = await Delete(textBoxDeleteID.Text);
            txtrichbox.Text = Response;

        }




        public static async Task<string> Delete(String id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44370/api/Suppliers/delete-supplier-by-id/" + id))
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
