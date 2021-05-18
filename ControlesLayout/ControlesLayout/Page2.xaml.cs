using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlesLayout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            this.controlSlider.ValueChanged += ControlSlider_ValueChanged;
            List<String> data = new List<string>
            {
                "Leche","Ajo","Azucar","Calabaza"
            };

            foreach(String d in data)
            {
                this.controlpicker.Items.Add(d);
            }

            this.controlpicker.SelectedIndexChanged += (sender, argas) =>
              {
                  this.lblvalor.Text = this.controlpicker.SelectedIndex.ToString();
              };
            this.stepper1.ValueChanged += (sender, args) =>
            {
                this.lblvalor.Text = "Stepper " + args.NewValue;
            };
        }

        private void ControlSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            this.lblvalor.Text="Valor : " + e.NewValue;
        }
    }
}