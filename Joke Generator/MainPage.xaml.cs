using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Joke_Generator.Services;
using Newtonsoft.Json;
using Joke_Generator.Models;
using System.Diagnostics;

namespace Joke_Generator
{
    public partial class MainPage : ContentPage
    {
        string jokeText;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Web_API api = new Web_API();
            jokeText = await api.GetJoke(); //gets the joke. Data types in C# are a bit funny, so they have to be converted to string.
            Root jokeTextParsed = JsonConvert.DeserializeObject<Root>(jokeText);
            Debug.WriteLine(jokeTextParsed.joke);
            joke.Text = jokeTextParsed.joke;
            categoryText.Text = jokeTextParsed.category;
        }
    }
}
