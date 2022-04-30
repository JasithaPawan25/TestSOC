using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SupplierCheckerApp
{
    public static class Helper
    {
        private static readonly string baseURL = "https://localhost:44370/api";

        public static async Task<string> Put(string id, string Name, string Address, string Contact, string DrugName, string price)
        {
            using (HttpClient client = new HttpClient())
            {
                var InputDat = new Dictionary<string, string>
                {
                    { "name", Name},
                    {"job", Address},
                    {"123", Contact},
                    {"drugname", DrugName},
                    {"15", price}


                    /*
                     public string Name { get; set; }

        public string Address { get; set; }

        public int Contact { get; set; }

        public string DrugName { get; set; }

        public double price { get; set; }
              
                    update-https://localhost:44370/api/Suppliers/update-supplier-by-id/6
                     
                     */



                };

                var input = new FormUrlEncodedContent(InputDat);

                using (HttpResponseMessage res = await client.PutAsync(baseURL + "/" + "Suppliers/update-supplier-by-id" + id, input))
                {
                    using (HttpContent content = res.Content)
                    {
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





        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

    }
}
