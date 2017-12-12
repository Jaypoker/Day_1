using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Day_1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        //private async void button_OnclickAsync(object sender, EventArgs e)
        //{
        //    //Device.BeginInvokeOnMainThread(async () => {
        //    //    var result = await this.DisplayAlert("Alert!", "Do you really want to continue?", "Yes", "No");
        //    //    if (result) await Navigation.PushAsync(new Sample()); // or anything else
        //    //});
        //    //return true;

        //    var result = await DisplayAlert("title", "Hello", "OK", "Cancel");
        //    if(result.Equals(true))
        //    {
        //        await Navigation.PushAsync(new Sample());
        //    }
        //}
        private async void button_Onclick(object sender, EventArgs e)
        {
            //Device.BeginInvokeOnMainThread(async () => {
            //    var result = await this.DisplayAlert("Alert!", "Do you really want to continue?", "Yes", "No");
            //    if (result) await Navigation.PushAsync(new Sample()); // or anything else
            //});
            //return true;

            var result = await DisplayAlert("title", "Hello", "OK", "Cancel");
            if (result.Equals(true))
            {
                await Navigation.PushAsync(new Sample());
            }
        }
    }
}
