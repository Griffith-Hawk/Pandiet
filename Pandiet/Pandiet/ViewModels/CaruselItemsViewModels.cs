using Pandiet.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace Pandiet.ViewModels
{
    public class CaruselItemsViewModels
    {
        #region Properties
        public ObservableCollection<CaruselItems> CaruselItem { get; set; } = new ObservableCollection<CaruselItems>();
        #endregion

        public CaruselItemsViewModels()
        {
            CaruselItem.Add(new CaruselItems
            {
                CaruselTitle = "Hовые блюда!",
                Image = "food1.jpg"
            });

            CaruselItem.Add(new CaruselItems
            {
                CaruselTitle = "Привет мир!",
                Image = "food2.jpg"
            });

            CaruselItem.Add(new CaruselItems
            {
                CaruselTitle = "Кто вообще это читает?",
                Image = "food3.jpg"
            });

        }
    }
}
