using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pandiet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Registration_Button_Clicked(object sender, EventArgs e)
        {
            if (Login_Entry.Text != null && Login_Entry.Text != "" && Password_Entry.Text != null && Password_Entry.Text != "")
            {
                await DisplayAlert("Успех!", "Вы успешно зарегистрировались!", "Ок");
                await Navigation.PopModalAsync();
            }
        }
    }
}