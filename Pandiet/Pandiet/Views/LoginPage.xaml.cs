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
    public partial class LoginPage : ContentPage
    {
        MainPage mainPage = new MainPage();
        public LoginPage()
        {
            InitializeComponent();
        }
        private void RecreatePassword_Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Уведомление!", "Эта функция пока недоступка, это тестовый вариант приложения", "ОК");
        }

        private async void LogIn_Button_Clicked(object sender, EventArgs e)
        {
            if (Login_Entry.Text != "" && Login_Entry.Text != null && Password_Entry.Text != "" && Password_Entry.Text != null)
            {

                await DisplayAlert("Успех!", "Вы вошли!!", "Ок");
                await Navigation.PushModalAsync(new HubPage());
            }
            else
            {
                await DisplayAlert("Ошибка!", "Нельзя оставлять поля пустыми!", "Ок");
            }
        }
    }
}