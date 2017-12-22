using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinPractice1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class QuotesPage : ContentPage
    {

        public QuotesPage()
        {
            InitializeComponent();
        }

        string[] quotes = {
            "Don't cry because it's over, smile because it happened.",
            "Be yourself; everyone else is already taken.",
            "So many books, so little time.",
            "A room without books is like a body without a soul.",
            "You only live once, but if you do it right, once is enough.",
            "Be the change that you wish to see in the world."
        };

        int i = 0;
        void NextButton_Clicked(object sender, System.EventArgs e)
        {
            if (i == quotes.Length)
                i = 0;

            label.Text = quotes[i];
            i++;
        }
    }
}