using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserControlFun.Fun;

namespace UserControlFun
{
    /// <summary>
    /// Interaction logic for RangeSlider.xaml
    /// </summary>
    public partial class RangeSlider : UserControl
    {
        public event EventHandler RangeSliderMinValueChanged;
        public event EventHandler RangeSliderMaxValueChanged;
        public RangeSlider()
        {
            InitializeComponent();
            this.LowerSlider.AddHandler(Slider.MouseLeftButtonUpEvent,
    new MouseButtonEventHandler(LowerSlider_MouseLeftButtonUp),
    true);
            this.UpperSlider.AddHandler(Slider.MouseLeftButtonUpEvent,
   new MouseButtonEventHandler(UpperSlider_MouseLeftButtonUp),
     true);
            this.Loaded += Slider_Loaded;

        }

        void Slider_Loaded(object sender, RoutedEventArgs e)
        {
            LowerSlider.ValueChanged += LowerSlider_ValueChanged;
            UpperSlider.ValueChanged += UpperSlider_ValueChanged;
        }

        private void LowerSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            UpperSlider.Value = Math.Max(UpperSlider.Value, LowerSlider.Value);
            RangeSliderMaxValueChanged?.Invoke(UpperSlider.Value, EventArgs.Empty);
        }

        private void UpperSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LowerSlider.Value = Math.Min(UpperSlider.Value, LowerSlider.Value);
            RangeSliderMinValueChanged?.Invoke(LowerSlider.Value, EventArgs.Empty);
        }

        public double Minimum
        {
            get { return (double)GetValue(MinimumProperty); }
            set { SetValue(MinimumProperty, value); }
        }


        public static readonly DependencyProperty MinimumProperty =
            DependencyProperty.Register("Minimum", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(0d));

        public double LowerValue
        {
            get { return (double)GetValue(LowerValueProperty); }
            set { SetValue(LowerValueProperty, value); }
        }

        public static readonly DependencyProperty LowerValueProperty =
            DependencyProperty.Register("LowerValue", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(0d));

        public double UpperValue
        {
            get { return (double)GetValue(UpperValueProperty); }
            set { SetValue(UpperValueProperty, value); }
        }

        public static readonly DependencyProperty UpperValueProperty =
            DependencyProperty.Register("UpperValue", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(0d));

        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register("Maximum", typeof(double), typeof(RangeSlider), new UIPropertyMetadata(1d));

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.IsReadOnly = false;
                textBox.BorderThickness = new Thickness(1);
            }
        }

        private void LowerValueTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.IsReadOnly = true;
                textBox.BorderThickness = new Thickness(0);
                RangeSliderMinValueChanged?.Invoke(textBox.Text, EventArgs.Empty);
            }


        }

        private void HigherValueTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.IsReadOnly = true;
                textBox.BorderThickness = new Thickness(0);
                RangeSliderMaxValueChanged?.Invoke(textBox.Text, EventArgs.Empty);
            }
        }

        private void LowerSlider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RangeSliderMinValueChanged?.Invoke(LowerSlider.Value, EventArgs.Empty);
        }

        private void UpperSlider_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            RangeSliderMaxValueChanged?.Invoke(UpperSlider.Value, EventArgs.Empty);
        }

        private void LowerSlider_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            RangeSliderMinValueChanged?.Invoke(LowerSlider.Value, EventArgs.Empty);

        }

        private void UpperSlider_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            RangeSliderMaxValueChanged?.Invoke(UpperSlider.Value, EventArgs.Empty);
        }


        private void rangeSlider_RangeSelectionChanged(object sender, AC.AvalonControlsLibrary.Controls.RangeSelectionChangedEventArgs e)
        {
            LowerValue = e.NewRangeStart;
            UpperValue = e.NewRangeStop;
            RangeSliderMinValueChanged?.Invoke(LowerValue, EventArgs.Empty);
            RangeSliderMaxValueChanged?.Invoke(UpperValue, EventArgs.Empty);
        }

        private void LowerSlider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RangeSliderMinValueChanged?.Invoke( (sender as TextBox)?.Text, EventArgs.Empty);
                (sender as TextBox)?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next) { });
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RangeSliderMinValueChanged?.Invoke((sender as TextBox)?.Text, EventArgs.Empty);
                (sender as TextBox)?.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next) { });
            }
        }
    }
}
