using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net.Http;

namespace SupplierCheckerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAllSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                string apiUrl = "https://localhost:44370/api/Suppliers/all-suppliers";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl);
                dgvSupplier.DataSource = (new JavaScriptSerializer()).Deserialize<List<MySupplier>>(jason);
            }catch
            {
                MessageBox.Show("Please Try Again");
            }

        }

        private void Searchbutton1_Click(object sender, EventArgs e)
        {
            try
            {

                string apiUrl = "https://localhost:44370/api/Suppliers/get-supplier-by-id";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl + "/" + txtID.Text);
                MySupplier mySupplier = new MySupplier();
                MessageBox.Show(jason);

            }
            catch
            {
                MessageBox.Show("Supplier Not Found");
            }

        }

        private void SuppAdd_Click(object sender, EventArgs e)
        {
            try { 
            string apiUrl = " https://localhost:44370/api/Suppliers/add-supplier";
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            client.Encoding = Encoding.UTF8;
            MySupplier myS = new MySupplier();
            myS.Name = txtAddSupName.Text;
            myS.Address = txtAddSupAdress.Text;
            myS.Contact = Convert.ToInt32(txtAddSupContact.Text);
            myS.DrugName = txtAddDrugName.Text;
            myS.price = Convert.ToDouble(txtAddDrugPrice.Text);
            string info =(new JavaScriptSerializer()).Serialize(myS);
            string up = client.UploadString(apiUrl, info);
            MessageBox.Show(up);

             }
            catch
            {
                MessageBox.Show("Error... Not Added");
            }

}

        private void button2SupSearch_Click(object sender, EventArgs e)
        {
            try
            {

                string apiUrl = "https://localhost:44370/api/Suppliers/get-supplier-by-name";
                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jason = client.DownloadString(apiUrl + "/" + txtSupName.Text);
                MySupplier mySupplier = new MySupplier();
                MessageBox.Show(jason);

            }
            catch
            {
                MessageBox.Show("Supplier Not Found");
            }

        }

        private  void btnUpdate_Click(object sender, EventArgs e)
        {
            try { 
             string apiUrl = "https://localhost:44370/api/Suppliers/update-supplier-by-id";

              WebClient client = new WebClient();
              client.Headers["Content-type"] = "application/json";
              client.Encoding = Encoding.UTF8;
             
              MySupplier mySC = new MySupplier();

              mySC.Name = txtUpdateName.Text;
              mySC.Address = txtUpdateAddress.Text;
              mySC.Contact = Convert.ToInt32(txtUpdateContact.Text);
              mySC.DrugName = txtUpdateDrugName.Text;
              mySC.price = Convert.ToDouble(txtUpdatePrice.Text);
              string info = (new JavaScriptSerializer()).Serialize(mySC);
              string up = client.UploadString(apiUrl, info, txtUpdateID.Text);
              MessageBox.Show(up);
            }
            catch
            {
                MessageBox.Show("Error... Not Updated");
            }

}

        private async void button1Delete_Click(object sender, EventArgs e)
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
