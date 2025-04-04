using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BarAndPieSample
{
    public class ViewModel
    {
        public ObservableCollection<ChartModel> TrafficStats { get; set; }
        public ObservableCollection<ChartModel> ActiveUsers { get; set; }
        public List<Brush> CircularPalette { get; set; }

        public ViewModel()
        {
            TrafficStats = new ObservableCollection<ChartModel>
            {
                new ChartModel(){Source="Google", Visitors=1200,DailyActiveUsers = 500,TrafficImage="google.png"},
                new ChartModel(){Source ="Facebook",Visitors=950,DailyActiveUsers =450,TrafficImage = "social.png"},
                new ChartModel(){ Source = "Twitter", Visitors = 700 ,DailyActiveUsers=300,TrafficImage = "twitter.png"},
                new ChartModel(){ Source = "LinkedIn", Visitors = 450 ,DailyActiveUsers=200,TrafficImage= "linkedin.png"}
            };

            ActiveUsers = new ObservableCollection<ChartModel>
            {
                new ChartModel(){AgeGroup="13-17 years",Percentage=10},
                new ChartModel(){AgeGroup="18-24 years",Percentage=25},
                new ChartModel(){AgeGroup="25-34 years",Percentage=35},
                new ChartModel(){AgeGroup="35-44 years",Percentage=15},
                new ChartModel(){AgeGroup="45-54 years",Percentage=8},
                
            };
          
            CircularPalette = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#ee964b")),
                new SolidColorBrush(Color.FromArgb("#9b5de5")),
                new SolidColorBrush(Color.FromArgb("#f15bb5")),
                new SolidColorBrush(Color.FromArgb("#00bbf9")),
                new SolidColorBrush(Color.FromArgb("#00f5d4")),
            };
        }
    }
}
