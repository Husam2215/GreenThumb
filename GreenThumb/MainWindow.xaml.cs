using GreenThumb.Database;
using GreenThumb.Models;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace GreenThumb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            using (AppDbcontext context = new())
            {
                var repository = new Repoository<Plants>(context);
                var plants = repository.GetAll();

                foreach (var plant in plants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstPlant.Items.Add(item);
                }
            }
        }

        private void btnAddPlantWindow_Click(object sender, RoutedEventArgs e)
        {
            AddPlant AddplantWindow = new();
            AddplantWindow.Show();
            Close();

        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstPlant.SelectedItem;
            if (selectedItem != null)
            {
                // Kolla vad som är selectat
                Plants selectedPlant = (Plants)selectedItem.Tag;

                // Skicka den plantan som är selectad
                PlantDetails PlantDetailsWindow = new(/*selectedPlant.Id*/selectedPlant);
                PlantDetailsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Please choose an item");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {



        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (AppDbcontext context = new())
            {
                var repository = new Repoository<Plants>(context);

                var allPlants = repository.GetAll();
                string searchPlant = txtSearch.Text.ToLower();

                //var filtererdPlants = allPlants;
                var filteredPlants = allPlants.Where(p => p.Name.ToLower().Contains(searchPlant));
                lstPlant.Items.Clear();

                foreach (var plant in filteredPlants)
                {
                    ListViewItem item = new();
                    item.Tag = plant;
                    item.Content = plant.Name;
                    lstPlant.Items.Add(item);
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem selectedItem = (ListViewItem)lstPlant.SelectedItem;
            if (selectedItem != null)
            {
                lstPlant.Items.Remove(selectedItem);

                using (AppDbcontext context = new())
                {

                }
            }
            else
            {
                MessageBox.Show("Choose an item");
            }

        }

        private void lstPlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
