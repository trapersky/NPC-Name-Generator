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
        private bool male;
        private bool family;
        private bool nick;
        string FirstName;
        string LastName;
        int listNumber;
        string Nickname;

        void AddNickname()
        {
            // as the Nickname has been represented by an enum, it has been converted to a list with LINQ
            
            Random random = new Random();
            var values = (Enum.GetValues(typeof(Nickname)) as IEnumerable<Nickname>).ToList();
            int length = values.Count;
            int nickNumber = random.Next(0, length);
            var nicknamed = values[nickNumber];
            
            if (nick == true) { Nickname = " known as " + nicknamed.ToString(); }
            else { Nickname = ""; }
            
        }

        void printFullName()
        {
            // writes hero name or names in the Character Name field 

            string PrintedName;
            if (family == false) { PrintedName = FirstName; LastName = ""; }
            else { PrintedName = FirstName + " " + LastName; }
            NameOutput.Text = PrintedName + Nickname;
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            switch (species)
            {
                case "Dwarves":
                    Dwarf dwarf = new Dwarf();
                    AddNickname();
                    Random random = new Random();
                    if (family == true)
                    {
                        int length = dwarf.FamilyName.Count;
                        listNumber = random.Next(0, length);
                        LastName = dwarf.FamilyName[listNumber];
                    }

                    if (male == true)
                    {
                        int length = dwarf.DwarfM.Count;
                        listNumber = random.Next(0, length);
                        FirstName = dwarf.DwarfM[listNumber];
                        printFullName();
                        break;
                    }
                    else
                    {
                        int length = dwarf.DwarfF.Count;
                        listNumber = random.Next(0, length);
                        FirstName = dwarf.DwarfF[listNumber];
                        printFullName();
                        break;
                    }
                case "Elf":
                    //quick check if switch works
                    FirstName = "Elf McElf the Elf";
                    printFullName();
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
                    //this should never be shown
                    NameOutput.Text = "You shouldn't see this!";
                    break;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
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

        private void Male_Checked(object sender, RoutedEventArgs e)
        {
            male = true;
            Female.IsChecked = false;
        }

        private void Family_Checked(object sender, RoutedEventArgs e)
        {
            family = true;
        }

        private void Female_Checked(object sender, RoutedEventArgs e)
        {
            male = false;
            Male.IsChecked = false;
        }

        private void Nick_Checked(object sender, RoutedEventArgs e)
        {
            nick = true;
        }

        private void Elf_Checked(object sender, RoutedEventArgs e)
        {
            species = "Elf";
        }

        private void Family_Unchecked(object sender, RoutedEventArgs e)
        {
            family = false;
        }

        private void Nick_Unchecked(object sender, RoutedEventArgs e)
        {
            nick = false;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
