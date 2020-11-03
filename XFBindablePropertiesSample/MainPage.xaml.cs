using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBindablePropertiesSample
{
    public partial class MainPage : ContentPage
    {
        public string MyDescription { get; set; } = "Did you subscribe yet?";

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}
