using SensorsMaster.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SensorsMaster.AppSettings.Model
{
    public class SizeSettings : DependencyObject, IViewModelBase
    {
        public SizeSettings(double width = 100.0, double height = 100.0)
        {
            this.Width = width;
            this.Height = height;
            this.Scale = 7.0;
        }

        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set 
            { 
                SetValue(HeightProperty, value);
                VisualHeight = Height * Scale;
            }
        }
        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set 
            { 
                SetValue(WidthProperty, value);
                VisualWidth = Width * Scale;
            }
        }
        public double Scale
        {
            get { return (double)GetValue(ScaleProperty); }
            set 
            { 
                SetValue(ScaleProperty, value);
                VisualWidth = Width * Scale;
                VisualHeight = Height * Scale;
                OnPropertyChanged(Scale);
            }
        }

        public double VisualWidth
        {
            get { return (double)GetValue(VisualWidthProperty); }
            set { SetValue(VisualWidthProperty, value); }
        }
        public double VisualHeight
        {
            get { return (double)GetValue(VisualHeightProperty); }
            set { SetValue(VisualHeightProperty, value); }
        }


        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(SizeSettings), new UIPropertyMetadata(800.0));

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(SizeSettings), new UIPropertyMetadata(1200.0));

        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register("Scale", typeof(double), typeof(SizeSettings), new UIPropertyMetadata(1.0));

        public static readonly DependencyProperty VisualWidthProperty =
            DependencyProperty.Register("VisualWidth", typeof(double), typeof(SizeSettings), new UIPropertyMetadata(1200.0));

        public static readonly DependencyProperty VisualHeightProperty =
            DependencyProperty.Register("VisualHeight", typeof(double), typeof(SizeSettings), new UIPropertyMetadata(800.0));

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public void OnPropertyChanged(object o) => OnPropertyChanged(o.GetType().Name);
    }
}
