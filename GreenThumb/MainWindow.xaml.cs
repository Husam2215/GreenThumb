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

            // Få fram alla planter i listan


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

            // När användaren klickar så kommer han till nästa sida 

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
                PlantDetails PlantDetailsWindow = new(selectedPlant);
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

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            // Användaren ska kunna ta bort en växt

            ListViewItem selectedItem = (ListViewItem)lstPlant.SelectedItem;
            if (selectedItem != null)
            {
                lstPlant.Items.Remove(selectedItem);

                using (AppDbcontext context = new())
                {
                    Repoository<Plants> newPlantRepo = new(context);
                    Plants plant = (Plants)selectedItem.Tag;
                    newPlantRepo.RemoveAsync(plant);
                    newPlantRepo.SaveChangesAsync();

                }
            }
            else
            {
                MessageBox.Show("Choose an plant to remove!");
            }


        }

        private void lstPlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
