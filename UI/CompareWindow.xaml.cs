namespace FileDiff.UI
{
    using System.Windows;
    using Wpf.Ui.Appearance;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            Theme.Apply(ThemeType.Light);
        }
    }
}