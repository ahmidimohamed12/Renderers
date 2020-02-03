using System;
using System.Collections.Generic;
using Plugin.XamJam;
using Plugin.FilePicker;
using Xamarin.Forms;

namespace testRenderers
{
    public partial class MyPageRegistration : ContentPage
    {
        List<int> ages = new List<int>()
        {

        };

        public MyPageRegistration()
        {
            InitializeComponent();
            //Remplire List Age
            for (int i = 8;i<120;i++)
            {
                ages.Add(i);
            }

            rempicon();
            pickerage.ItemsSource = ages;

            var colgrid = Plugin.XamJam.Screen.CrossScreen.Current.Size.Width;

            btnim.Clicked += (sender, e) =>
            {
                var a = Plugin.FilePicker.CrossFilePicker.Current.PickFile();

            };
            
        }
        private void rempicon()
        {
            txtnom.Icon = "";
        }
    }
}
