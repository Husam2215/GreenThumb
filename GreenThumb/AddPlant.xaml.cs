using GreenThumb.Database;
using GreenThumb.Models;
using System.Windows;
using System.Windows.Controls;

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

        private async void btnAddPlant_Click(object sender, RoutedEventArgs e)
        {

            // Checka så alla inputs e ifyllda


            if (string.IsNullOrWhiteSpace(txtPlantName.Text.Trim()))
            {
                MessageBox.Show("Fill in the missing");
            }
            else
            {

                using (var context = new AppDbcontext())
                {

                    string name = txtPlantName.Text;


                    Plants newPlant = new()
                    {
                        Name = name
                    };

                    Repoository<Plants> plant = new(context);

                    await plant.AddAsync(newPlant);
                    await plant.SaveChangesAsync();


                    // Fylla i listan

                    Repoository<Instructions> instructions = new(context);
                    foreach (ListViewItem instruction in lstPlantDetails.Items)
                    {
                        Instructions newInstruction = (Instructions)instruction.Tag;
                        newInstruction.PlantId = newPlant.Id;
                        await instructions.AddAsync(newInstruction);
                        await instructions.SaveChangesAsync();
                    }
                }
                MessageBox.Show("Plant Added");
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();


            }

        }

        private void btnInstruction_Click(object sender, RoutedEventArgs e)
        {

            // Checka så alla inputs är ifyllda

            if (string.IsNullOrWhiteSpace(txtInstructions.Text.Trim()))
            {

                MessageBox.Show("Fill in the missing");
            }
            else
            {
                using (var context = new AppDbcontext())
                {

                    string Instruction = txtInstructions.Text;
                    Instructions newInstructions = new()
                    {
                        Instruction = Instruction
                    };

                    ListViewItem item = new();
                    item.Tag = newInstructions;
                    item.Content = Instruction;
                    txtInstructions.Clear();

                    Repoository<Instructions> instruction = new(context);
                    lstPlantDetails.Items.Add(item);



                }
                MessageBox.Show("Instruction Added");
            }


        }
    }

}
