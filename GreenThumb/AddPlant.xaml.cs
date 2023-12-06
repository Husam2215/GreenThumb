using System.Windows;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for AddPlant.xaml
    /// </summary>
    public partial class AddPlant : Window
    {
        public AddPlant()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new();
            MainWindow.Show();
            Close();
        }

        private void btnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            // Hämta och checka så alla inputs inte är tomma 

            bool PlantName = txtPlantName.Text.Trim().Length > 0;

            bool Instructions = txtInstructions.Text.Trim().Length > 0;


        }
    }
}
