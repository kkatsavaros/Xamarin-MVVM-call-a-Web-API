using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.CompilerServices;

using Newtonsoft.Json;
using ProjectWithoutMvvm;
using System.Net.Http;
using System.Collections.ObjectModel;

namespace RestApiWithMvvm.ViewModels
{
    public class QuotesViewModel : BaseViewModel
    {

        public ObservableCollection<Quote> Quotes7 { get; set; }   // using System.Collections.ObjectModel;

        public QuotesViewModel()
        {
            Quotes7 = new ObservableCollection<Quote>();           // Initialize the ObservableCollection.

            LoadQuotes();
        }


        public async void LoadQuotes()
        {
            var httpClient = new HttpClient();

            var response = await httpClient.GetStringAsync("https://quotessamplerestfulwebapi.azurewebsites.net/api/quotes");

            var quotes = JsonConvert.DeserializeObject<List<Quote>>(response);

            //LvQuotes.ItemsSource = quotes;

            foreach (var quote in quotes)
            {
                Quotes7.Add(quote);
            }
        }
    }
}
