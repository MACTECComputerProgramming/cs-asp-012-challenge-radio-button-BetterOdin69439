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
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            if (pencilradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pencil, Very reliable! ";
            }

            else if (penradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pen, nice choice! ";
            }

            else if (phoneradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Phone, msut be from the future! ";
            }

            else if (padradioButton.IsChecked == true)
            {
                labelAnswer.Content = " Pad, Welcom to 2020! ";
            }

            
        }
    }
}
