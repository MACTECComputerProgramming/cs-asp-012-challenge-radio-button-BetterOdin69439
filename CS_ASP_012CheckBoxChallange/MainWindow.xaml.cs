using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS_ASP_012CheckBoxChallange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            pencilImage.Visibility = 0;

            penImage.Visibility = 0;

            phoneImage.Visibility = 0;

            padImage.Visibility = 0;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (pencilradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pencil, Very reliable! ";

                pencilImage.Opacity = 100;
                penImage.Opacity = 0;
                phoneImage.Opacity = 0;
                padImage.Opacity = 0;
            }

            else if (penradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pen, nice choice! ";

                penImage.Opacity = 100;
                pencilImage.Opacity = 0;
                padImage.Opacity = 0;
                phoneImage.Opacity = 0;
            }

            else if (phoneradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Phone, msut be from the future! ";

                phoneImage.Opacity = 100;
                pencilImage.Opacity = 0;
                padImage.Opacity = 0;
                penImage.Opacity = 0;
            }

            else if (padradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pad, Welcom to 2020! ";

                padImage.Opacity = 100;
                penImage.Opacity = 0;
                pencilImage.Opacity = 0;
                phoneImage.Opacity = 0;
            }
        }
    }
}
