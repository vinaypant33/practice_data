using System.ComponentModel;              // INotifyPropertyChanged
using System.Runtime.CompilerServices;    // [CallerMemberName]
using System.Windows;                     // WPF Window base types

namespace WPF_Learning
{
    // MainWindow is a WPF Window and also implements INotifyPropertyChanged
    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        // Private backing field that stores the actual value.
        // Marked nullable to satisfy nullable-reference rules at startup.
        private string _username;

        // Public property that WPF binds to. Name matches XAML binding path.
        public string username
        {
            // Return the stored value
            get => _username;

            // When the value changes, update storage and notify the UI
            set
            {
                // If the value is the same, do nothing (avoids extra notifications)
                if (_username == value) return;

                // Update the private backing field
                _username = value;

                // Tell WPF that 'username' changed so bound controls refresh
                OnPropertyChanged();
            }
        }

        // Constructor runs when the window is created
        public MainWindow()
        {
            // Load and connect the XAML elements
            InitializeComponent();

            // Make this object the default source for all {Binding ...} in XAML
            DataContext = this;

            // Seed an initial value so you can see binding working on startup
            username = "Vinay pant";
        }

        // INotifyPropertyChanged event; nullable satisfies nullable-reference rules
        public event PropertyChangedEventHandler? PropertyChanged;

        // Helper to raise PropertyChanged. CallerMemberName uses the property name
        // of the caller automatically, so OnPropertyChanged() here sends "username".
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            // If any listener (like WPF binding engine) is subscribed, notify it
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
