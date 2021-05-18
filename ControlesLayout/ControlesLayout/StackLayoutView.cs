using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ControlesLayout
{
    public class StackLayoutView : ContentPage
    {
        public StackLayoutView()
        {
            StackLayout principal = new StackLayout();
            Label header = new Label()
            {
                Text = "Layout en C#",
                FontSize = 40,
                TextColor = Color.Red
            };


            StackLayout contenido = new StackLayout();
            Label lbl1 = new Label()
            {
                Text ="Inicio",
                HorizontalOptions=LayoutOptions.Start
            };

            contenido.Children.Add(lbl1);
            principal.Children.Add(contenido);
            this.Content = principal;
        }
    }
}