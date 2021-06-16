using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class DataProcessor
    {
        public static async Task<T> LoadData<T>(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //gathers json key/values data and stores them in ComicModel class (Num, Img)
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<T> LoadData<T>(int num)
        {
            string url = "";

            if (num > 0)
            {
                url = $"https://xkcd.com/{ num }/info.0.json";
            }
            else
            {    //latest released comic
                url = "https://xkcd.com/info.0.json";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    //gathers json key/values data and stores them in ComicModel class (Num, Img)
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

    }
}
