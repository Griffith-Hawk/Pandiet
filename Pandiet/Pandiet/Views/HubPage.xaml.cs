using Microcharts;
using Pandiet.Models;
using Pandiet.ViewModels;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pandiet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HubPage : ContentPage
    {
        private readonly ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(248)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(514)
            {
                Color = SKColor.Parse("#3BA3D0")
            }
        };
        public HubPage()
        {
            InitializeComponent();
            Navigation.RemovePage(new MainPage());
            Navigation.RemovePage(new LoginPage());
            chartViewPie.Chart = new PieChart
            {
                Entries = entries,
                BackgroundColor = SKColor.Empty
            };
            chartViewBar.Chart = new BarChart
            {
                Entries = entries,
                BackgroundColor = SKColor.Empty
            };
            this.BindingContext = new CaruselItemsViewModels();
        }

        private async void MyProfile_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ProfilePage());
        }

        private async void AddMeal_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddMealPage());
        }

        private async void Statistics_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new StatisticsPage());
        }
    }
}