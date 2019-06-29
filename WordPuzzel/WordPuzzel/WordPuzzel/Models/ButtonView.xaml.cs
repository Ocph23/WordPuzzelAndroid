using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xamarin.Forms;

namespace WordPuzzel.Models
{
    /// <summary>
    /// Interaction logic for ButtonView.xaml
    /// </summary>
    public partial class ButtonView : ContentView
    {
      
        private Thickness _borderSize;
        private Color _borderColor= Color.Transparent;
        private bool _isUsed;

        public ButtonView(Cordinate maxrowcol)
        {
            InitializeComponent();
            this.MaxRowCol = maxrowcol;
            this.BindingContext= this;
           
        }

        public int Row { get; internal set; }
        public int Column { get; internal set; }
        public bool IsStarter { get; internal set; }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Thickness BorderSize
        {
            get { return _borderSize; }
            set
            {
                if(_borderSize!=value)
                {
                    _borderSize = value;
                    OnPropertyChanged("BorderSize");
                }
            }
        }


        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                if(_borderColor!=value)
                {
                    _borderColor = value;
                    OnPropertyChanged("BorderColor");
                }
            }
        }

      

        public bool IsUsed {
            get
            {
                return _isUsed;
            }
            set
            {
                _isUsed = value;
                OnPropertyChanged("IsUsed");
              
            }
        }

        public bool IsFounded { get;  set; }
        public Cordinate MaxRowCol { get; private set; }

        public void SetIsUsed(Color currentColor)
        {
            this.BorderSize= new Thickness(10);
            this.BorderColor = currentColor;

        }

       


        internal void ClearUsed()
        {
            this.BorderSize = new Thickness(0);
            this.BorderColor = Color.Transparent;
        }

       
    }
}
