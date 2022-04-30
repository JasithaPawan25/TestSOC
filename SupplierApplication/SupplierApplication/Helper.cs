using IdentityServer4.Models;
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
//using System.Xml;
using Twilio.TwiML.Voice;

namespace SupplierApplication
{
    public static class Helper
    {
        private static readonly string baseURL = "https://localhost:44370/api";

        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.GetAsync(baseURL +"/"+ "Suppliers/all-suppliers"))
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



        public static async Task<string> Get(String id)
        {
            using (HttpClient client = new HttpClient())
            {

                using (HttpResponseMessage res = await client.GetAsync(baseURL + "/" + "Suppliers/get-supplier-by-id/" + id))
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


        public static async Task<string> Post(string name, string job)
        {
            using (HttpClient client = new HttpClient())
            {
                var InputDat = new Dictionary<string, string>
                {
                    { "name", name},
                    {"job", job}
                };

                var input = new FormUrlEncodedContent(InputDat);

                using (HttpResponseMessage res = await client.PostAsync(baseURL + "/" + "Suppliers/add-supplier", input))
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




        public static async Task<string> Put(string id, string name, string job)
        {
            using (HttpClient client = new HttpClient())
            {
                var InputDat = new Dictionary<string, string>
                {
                    { "name", name},
                    {"job", job}
                };

                var input = new FormUrlEncodedContent(InputDat);

                using (HttpResponseMessage res = await client.PutAsync(baseURL + "/" + "users" + id, input))
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


    }
}
