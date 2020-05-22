using GameTools.ViewModel.Windows;
using System.Windows;

namespace GameTools.View.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HubView : Window
    {
        public HubView()
        {
            InitializeComponent();
            this.DataContext = new HubViewModel();
        }
    }
}
