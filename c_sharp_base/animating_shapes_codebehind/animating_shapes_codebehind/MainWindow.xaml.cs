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

            doubleanimation doubleanimation = new doubleanimation(0, 4, new duration(timespan.frommilliseconds(1)));
            doubleanimation doubleanimation = new doubleanimation();
            doubleanimation.from = 0;
            doubleanimation.to = 1;
            doubleanimation.duration = timespan.fromseconds(2);


            //doubleanimation doubleanimation = new doubleanimation();
            doubleanimation.from = 0;
            doubleanimation.to = 500;
            doubleanimation.duration = timespan.fromseconds(1);

            doubleanimation.easingfunction = new quadraticease();

            rectangle1.beginanimation(widthproperty, doubleanimation);


            

            

        }
    }
}
