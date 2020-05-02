using _4_DAL.Interfaces;
using _5_Models;
using _5_Models.Enums;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _4_DAL.Marvel
{
    public class CharacterMarvelContext : ICharacterContext
    {

        private HttpClient client = new HttpClient();

        public async Task<Character> GetCharacterByName(string name)
        {
            MD5Hash();
            //TODO DO REST CALL WITH PARAMETER = $name.
            throw new NotImplementedException();
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
