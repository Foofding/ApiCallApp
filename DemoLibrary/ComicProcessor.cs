using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ComicProcessor
    {
        //gets comic from website API using ApiHelper class. 
        public static async Task<ComicModel> LoadComic(int comicNumber = 0)
        {
            string url = "";
            //unless specified, LoadComic will pull latest comic.
            if (comicNumber > 0)
            {
                url = $"https://xkcd.com/{ comicNumber }/info.0.json";
            }
            else
            {    //latest released comic
                url = "https://xkcd.com/info.0.json";
            }

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if(response.IsSuccessStatusCode)
                {
                    //gathers json key/values data and stores them in ComicModel class (Num, Img)
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();
                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }


    }
}
