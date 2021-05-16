using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace Joke_Generator.Services
{
    class Web_API
    {
        HttpClient client = new HttpClient(); //starts new instance of httpClient class
        public async Task<string> GetJoke()
        {
            string response = await client.GetStringAsync("https://v2.jokeapi.dev/joke/Any?blacklistFlags=nsfw,religious,political,racist,sexist,explicit&type=single" + "/&safe-mode"); // '&safe-mode' flag was added since I was getting jokes that shouldn't be shown in a school environment.
            return response;
        }
    }
}
