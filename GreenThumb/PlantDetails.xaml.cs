using GreenThumb.Database;
using GreenThumb.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for PlantDetails.xaml
    /// </summary>
    public partial class PlantDetails : Window
    {
        private Plants? plant;

        // Få alla Instrctions i listan
        public PlantDetails(Plants selectedPlant)
        {
            InitializeComponent();
            using (AppDbcontext context = new())
            {
                lblPlantName.Content = selectedPlant.Name;

                Repoository<Plants> plant = new(context);
                Repoository<Instructions> instruction = new(context);

                var allInstructions = instruction.GetAll();

                var selectedInstructions = allInstructions.Where(p => p.PlantId == selectedPlant.Id);

                foreach (var x in selectedInstructions)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = x;
                    item.Content = x.Instruction;
                    lstPlantDetails.Items.Add(item);
                }
            }

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
