using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConvertidorApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConvertPage : ContentPage
    {
        double cm;
        double m;
        public ConvertPage()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            cm = Convert.ToDouble(txtcm.Text);
            m = cm / 100;
            lblResultado.Text = m.ToString() + "m";

        }
        private void Validate()
        {
            if (!string.IsNullOrEmpty(txtcm.Text))
            {
                Calculate();
            }
            else
            {
                DisplayAlert("Error", "Ingrese una cantidad", "OK");
            }
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Validate();
        }

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}