using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        public MainWindow()
        {
               DataContext = this; // This makes the data context for the property and for MVVM it doesnot apply
            InitializeComponent();

        }
           private string BoundText;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Myproperty
            { 
            get { return BoundText;  } set {
                BoundText =  value; 
                // We can make it using on property changed so that we dont have to change it manually
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(BoundText));
            }
        }

            
        
    }
}
