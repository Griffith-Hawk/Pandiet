using Microcharts;
using SkiaSharp;
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
    public partial class StatisticsPage : ContentPage
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

        private readonly ChartEntry[] entriesBar_Belki = new[]
        {
            new ChartEntry(123)
            {
                Label = "Пн",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(432)
            {
                Label = "Вт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(342)
            {
                Label = "Ср",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(325)
            {
                Label = "Чт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(285)
            {
                Label = "Пт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(532)
            {
                Label = "Сб",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(123)
            {
                Label = "Вс",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(343)
            {
                Label = "Пн",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(462)
            {
                Label = "Вт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(345)
            {
                Label = "Ср",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(356)
            {
                Label = "Чт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(467)
            {
                Label = "Пт",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(700)
            {
                Label = "Сб",
                Color = SKColor.Parse("#FF9640")
            },
            new ChartEntry(325)
            {
                Label = "Вс",
                Color = SKColor.Parse("#FF9640")
            }
        };

        private readonly ChartEntry[] entriesBar_Fats = new[]
        {
            new ChartEntry(323)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(232)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(442)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(525)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(685)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(332)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(323)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(343)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(262)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(445)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(456)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(567)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(400)
            {
                Color = SKColor.Parse("#35D3A7")
            },
            new ChartEntry(325)
            {
                Color = SKColor.Parse("#35D3A7")
            }
        };

        private readonly ChartEntry[] entriesBar_Uglevodi = new[]
        {
            new ChartEntry(223)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(332)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(442)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(425)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(485)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(432)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(523)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(643)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(662)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(645)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(556)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(667)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(500)
            {
                Color = SKColor.Parse("#3BA3D0")
            },
            new ChartEntry(425)
            {
                Color = SKColor.Parse("#3BA3D0")
            }
        };
        public StatisticsPage()
        {
            InitializeComponent();
            chartViewPie.Chart = new PieChart
            {
                Entries = entries,
                BackgroundColor = SKColor.Empty
            };
            chartViewPie2.Chart = new PieChart
            {
                Entries = entries,
                BackgroundColor = SKColor.Empty
            };
            chartViewBar.Chart = new BarChart
            {
                Entries = entriesBar_Belki,
                BackgroundColor = SKColor.Empty,
                LabelTextSize = 14,
                LabelOrientation = Orientation.Vertical
            };
        }

        private void Statistics_Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Statistics_Picker.SelectedIndex == 0)
            {
                chartViewBar.Chart.Entries = entriesBar_Belki;
            }
            else if (Statistics_Picker.SelectedIndex == 1)
            {
                chartViewBar.Chart.Entries = entriesBar_Fats;
            }
            else if (Statistics_Picker.SelectedIndex == 2)
            {
                chartViewBar.Chart.Entries = entriesBar_Uglevodi;
            }
        }
    }
}