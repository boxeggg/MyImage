using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.WebRequestMethods;

namespace MyImage
{
    public partial class MainPage : ContentPage
    {
        static int currentIndex = 0;
        List<string> urlList;
        

        public MainPage()
        {
            InitializeComponent();

            urlList = new List<string>
        {
            "https://www.josera.pl/media/jak-karmic-malego-kotka.jpg",
            "https://images.iberion.media/images/1920/Kotek_1_c0cc2b8ff0.jpg",
            "https://fera.pl/images/companies/1/jak%20odr%C3%B3%C5%BCni%C4%87%20kota%20od%20kotki.jpg?1607517006790",
            "https://picsum.photos/id/1/200/300",
            "https://picsum.photos/id/20/200/300",
            "https://picsum.photos/id/50/200/300",
            "https://picsum.photos/id/70/200/300",
            "https://picsum.photos/id/90/200/300",
            "https://picsum.photos/id/96/200/300",
            "https://picsum.photos/id/98/200/300"
        };

            myImage.Source = urlList[currentIndex];
            
        }

        private void Button_Clicked_Next(object sender, EventArgs e)
        {
            
            if (currentIndex < urlList.Count - 1)
            {
                currentIndex++;
                myImage.Source = urlList[currentIndex];
            }
            else
            {
                currentIndex = 0;
                myImage.Source = urlList[currentIndex];
            }
        }

        private void Button_Clicked_Previous(object sender, EventArgs e)
        {

            if (currentIndex > 0)
            {
                currentIndex--; 
                myImage.Source =  urlList[currentIndex]; 
            }
        }
    }
}
