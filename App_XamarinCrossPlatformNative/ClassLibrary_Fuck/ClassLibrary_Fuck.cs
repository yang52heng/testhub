﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ClassLibrary_Fuck
{
    public class ClassLibrary_Fuck : ContentPage
    {
        public ClassLibrary_Fuck()
        {
            var button = new Button
            {
                Text = "Click Me!",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            int clicked = 0;
            button.Clicked += (s, e) => button.Text = "Clicked: " + clicked++;

            Content = button;
        }
    }
}