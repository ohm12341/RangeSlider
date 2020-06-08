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

namespace UserControlFun
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {


        public Window1()
        {
            InitializeComponent();
        }

        private void grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Focus();
            Keyboard.ClearFocus();
        }

        private void slider_LostFocus(object sender, RoutedEventArgs e)
        {

        }

        private void slider_RangeSliderMinValueChanged(object sender, EventArgs e)
        {

            minTextBox.Text = sender.ToString();
            
        }

        private void slider_RangeSliderMaxValueChanged(object sender, EventArgs e)
        {

            maxTextBox.Text = sender.ToString();
        }
    }
}
