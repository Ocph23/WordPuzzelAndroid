using System;
using System.ComponentModel;
using Xamarin.Forms;
using DataAccess.Models;
using System.Runtime.CompilerServices;

namespace WordPuzzel.Models
{
    public partial class ButtonBox: Button
    {

        private Thickness _borderSize;
        private Color _borderColor = Color.Transparent;
        private bool _isUsed;

        public ButtonBox(Cordinate maxrowcol)
        {
            this.MaxRowCol = maxrowcol;
            this.SetBinding(Button.TextProperty, "TextView");
            this.BindingContext = this;

        }

        public int Row { get;  set; }
        public int Column { get;  set; }
        public bool IsStarter { get;  set; }
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
                if (_borderSize != value)
                {
                    _borderSize = value;
                    OnPropertyChanged("BorderSize");
                }
            }
        }


      


        public bool IsUsed
        {
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

        public bool IsFounded { get; set; }
        public Cordinate MaxRowCol { get; private set; }

        public void SetIsUsed(Color currentColor)
        {
            this.BorderSize = new Thickness(10);
            this.BorderColor = currentColor;

        }

              

        internal void ClearUsed()
        {
            this.BorderSize = new Thickness(0);
            this.BorderColor = Color.Transparent;
        }


        public string TextView
        {
            get { return Text; }
            set { Text = value;
                OnPropertyChanged("TextView");
            }
        }
       

    }
}
