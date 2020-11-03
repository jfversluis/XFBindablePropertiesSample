using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XFBindablePropertiesSample
{
    public partial class MyCustomControl : ContentView
    {
        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(nameof(TitleText),
            typeof(string),
            typeof(MyCustomControl),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyCustomControl)bindable;
            control.Title.Text = newValue?.ToString();
        }

        public string TitleText
        {
            get
            {
                return base.GetValue(TitleTextProperty)?.ToString();
            }

            set
            {
                base.SetValue(TitleTextProperty, value);
            }
        }

        public static readonly BindableProperty DescriptionTextProperty = BindableProperty.Create(nameof(TitleText),
            typeof(string),
            typeof(MyCustomControl),
            defaultValue: string.Empty,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: DescriptionTextPropertyChanged);

        private static void DescriptionTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyCustomControl)bindable;
            control.Description.Text = newValue?.ToString();
        }

        public string DescriptionText
        {
            get
            {
                return base.GetValue(DescriptionTextProperty)?.ToString();
            }

            set
            {
                base.SetValue(DescriptionTextProperty, value);
            }
        }

        public MyCustomControl()
        {
            InitializeComponent();
        }
    }
}
