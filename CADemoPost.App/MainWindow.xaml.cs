using RamboTweets.App.ViewModels;
using System.Windows;

namespace RamboTweets.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Gets or sets the main view model.
        /// </summary>
        /// <value>The main view model.</value>
        public MainViewModel MainViewModel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel(this);
            this.DataContext = MainViewModel;
        }
    }
}
