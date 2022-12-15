using RestApiWithMvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace RestApiWithMvvm.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();


            // Εδώ πριν είχα τον κώδικα: LoadQuotes();
            // τώρα που το έσβησα για να το συνδέσω με το QuotesViewModel όπου μετέφερα τον κώδικα, γράφω:

            BindingContext = new QuotesViewModel();

        }

    }
}
