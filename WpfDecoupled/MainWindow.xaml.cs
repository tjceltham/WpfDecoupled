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

namespace WpfDecoupled
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Game g;
        public MainWindow()
        {
            InitializeComponent();
            g = new Game();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            g.buttonClick();
            // to change the textbox I had to give it a name using x:Name="t1" in.xaml file
           
            t1.Text =  ""+g.getX();
            if (g.getX() % 2 == 0)
            {
                b1.Background = new SolidColorBrush(System.Windows.Media.Colors.Red);
                
                
            }
            else
            {
                b1.Background = new SolidColorBrush(System.Windows.Media.Colors.Green);

            }
            
        }
    }
}
