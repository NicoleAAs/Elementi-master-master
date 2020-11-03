using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListView : ContentPage
    {
        public ListView()
        {
            StackLayout st = new StackLayout();
            Button tagasi_btn = new Button { Text = "Back" };
            tagasi_btn.HorizontalOptions = LayoutOptions.StartAndExpand;
            tagasi_btn.VerticalOptions = LayoutOptions.EndAndExpand;
            tagasi_btn.Clicked += Tagasi_btn_Clicked;
            st.Children.Add(tagasi_btn);
            Content = st;
        }

        private async void Tagasi_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}