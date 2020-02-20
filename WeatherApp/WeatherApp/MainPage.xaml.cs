using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Weather> Weathers { get => WeatherData(); }

        private List<Weather> WeatherData()
        {
            var tempList = new List<Weather>();
            tempList.Add(new Weather { Temp = "20", Date = "Tuesday 29", Icon = "sun.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Wednesday 30", Icon = "sun.png" });
            tempList.Add(new Weather { Temp = "17", Date = "Thursday 31", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "16", Date = "Friday 01", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "18", Date = "Saturday 02", Icon = "weather.png" });
            tempList.Add(new Weather { Temp = "20", Date = "Sunday 03", Icon = "sun.png" });

            return tempList;
        }
    }

    public class Weather
    {
        public string Temp { get; set; }
        public string Date { get; set; }
        public string Icon { get; set; }
    }
}
