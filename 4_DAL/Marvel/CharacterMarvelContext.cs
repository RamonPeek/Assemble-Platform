using _4_DAL.Interfaces;
using _5_Models;
using _5_Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4_DAL.Marvel
{
    public class CharacterMarvelContext : ICharacterContext
    {

        private HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://gateway.marvel.com:443/v1/public/")
        };

        public async Task<Character> GetCharacterByName(string name)
        {
            String queryURI = client.BaseAddress + "characters?ts=" + DateTime.Now.ToLongTimeString() +
                               "&apikey=" + Environment.GetEnvironmentVariable("MARVEL_API_PUBLIC_KEY") +
                               "&hash=" + MD5Hash() + "&name=" + name;
            var response = await client.GetAsync(queryURI);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject o = JObject.Parse(responseBody);
            JToken allCharacters = o.SelectToken("data.results");
            return new Character() {
                Name = allCharacters[0].Value<String>("name"),
                Description = allCharacters[0].Value<String>("description"),
                Thumbnail = allCharacters[0]["thumbnail"].Value<String>("path")
            };
        }

        private String MD5Hash()
        {
            String privateKey = System.Environment.GetEnvironmentVariable("MARVEL_API_PRIVATE_KEY");
            String publicKey = System.Environment.GetEnvironmentVariable("MARVEL_API_PUBLIC_KEY");
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5Provider.ComputeHash(new UTF8Encoding().GetBytes(DateTime.Now.ToLongTimeString() + privateKey + publicKey));
            for (int i = 0; i < bytes.Length; i++)
                hash.Append(bytes[i].ToString("x2"));
             return hash.ToString();
        }
    }
}
