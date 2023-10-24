using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NPC_Name_Generator
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private string species;
        string DwarfTest = "Test";

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            switch (species)
            {
                case "Dwarves":
                    NameOutput.Text = "Tested";
                    break;
                case "Elf":
                    //placeholder
                    Console.WriteLine("You shouldn't see this");
                    break;
                case "Halfling":
                    //placeholder
                    Console.WriteLine("You shouldn't see this");
                    break;
                case "Human":
                    //placeholder
                    Console.WriteLine("You shouldn't see this");
                    break;
                default:
                    //this code should never be executed, as the condition should never be met
                    Console.WriteLine("You shouldn't see this");
                    break;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Blank_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Dwarves_Checked(object sender, RoutedEventArgs e)
        {
            species = "Dwarves";
        }

        private void NameOutput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
