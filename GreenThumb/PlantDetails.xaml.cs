using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for PlantDetails.xaml
    /// </summary>
    public partial class PlantDetails : Window
    {
        public PlantDetails()
        {
            InitializeComponent();




        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new();
            MainWindow.Show();
            Close();
        }

        private void lstPlantDetails_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
