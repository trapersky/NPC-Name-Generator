using System;
using System.Collections.Generic;
using System.Linq;
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
            switch (species)
            {
                default:
                    //this code should never be executed, as the condition should never be met
                    Console.WriteLine("You shouldn't see this");
                    break;
            }
        }

        public readonly string species;

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
    }

    
}
