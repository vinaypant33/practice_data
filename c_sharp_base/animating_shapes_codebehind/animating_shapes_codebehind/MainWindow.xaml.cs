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
using System.Windows.Media.Animation;

namespace animating_shapes_codebehind
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            //DoubleAnimation doubleanimation = new DoubleAnimation(0, 4, new Duration(TimeSpan.FromMilliseconds(1)));
            DoubleAnimation doubleanimation = new DoubleAnimation();
            //doubleanimation.From = 0;
            //doubleanimation.To = 1;
            //doubleanimation.Duration = TimeSpan.FromSeconds(2);


            //doubleanimation doubleanimation = new doubleanimation();
            doubleanimation.From = 0;
            doubleanimation.To = 500;
            doubleanimation.Duration = TimeSpan.FromSeconds(1);

            doubleanimation.EasingFunction = new QuadraticEase();

            rectangle1.BeginAnimation(WidthProperty , doubleanimation);
        }
    }
}
