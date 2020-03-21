using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DersMvvmYapisi.Models;
using DersMvvmYapisi.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DersMvvmYapisi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarView : ContentPage
    {
        public CarView()
        {
            InitializeComponent();
        }
        private void listView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;

            if (sender is ListView lv) lv.SelectedItem = null;

            var marka2 = (e.SelectedItem as Car).Marka;
            var model2 = (e.SelectedItem as Car).Model;
            DisplayAlert("Araba", marka2 +" \'nın en güzel modeli " + model2, "OK");
        }
    }
}