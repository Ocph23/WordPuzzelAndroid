using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;

namespace WordPuzzel.Models
{
   public class BorderLabel : StackLayout
    {
        public BorderLabel(string name)
        {
            //this.Name = name;
            //Margins = new Thickness(5);
            //Background = Brushes.Beige;
            //CornerRadius = new CornerRadius(20);
            //BorderThickness = new Thickness(5);
            //BorderBrush = Brushes.Beige;
            Padding = new Thickness(5);
            this.Text = new Label { FontSize =16, Text = name};
            this.Children.Add(this.Text);
        }

        public string Name { get; set; }


        public void Found()
        {
          //  this.Text.TextDecorations = TextDecorations.Strikethrough;
            this.Text.TextColor = Color.Red;
            this.IsFound = true;
        }

        public Label Text { get; set; }
        public bool IsFound { get; private set; }
    }
}
