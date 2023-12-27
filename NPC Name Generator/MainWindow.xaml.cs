using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
using System.IO;
using System.Windows.Shapes;
using Microsoft.Win32;

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

        //input and output global variables, used to properly determine what type of name is generated

        private string species;
        private bool male;
        private bool family;
        private bool nick;
        string FirstName;
        string LastName;
        int listNumber;
        string Nickname;
        private string Hero;

        void AddNickname()
        {
            // as the Nickname has been represented by an enum, it has been converted to a list with LINQ
            // this function is based on a boolean value to check if the character has a nickname
            
            Random random = new Random();
            var values = (Enum.GetValues(typeof(Nickname)) as IEnumerable<Nickname>).ToList();
            int length = values.Count;
            int nickNumber = random.Next(0, length);
            var nicknamed = values[nickNumber];

            if (nick == true && (Female.IsChecked == true || Male.IsChecked == true || family == true)) { Nickname = " known as " + nicknamed.ToString(); }
            else if (nick == true && (Female.IsChecked == false && Male.IsChecked == false && family == false)) { Nickname =  nicknamed.ToString(); }
            else { Nickname = ""; }
            
        }

        void printFullName()
        {
            // writes hero name or names in the Character Name field 

            string PrintedName;
            if (family == false) { PrintedName = FirstName; LastName = ""; }
            else if (family == true && Male.IsChecked == false && Female.IsChecked == false) { PrintedName = LastName; FirstName = ""; }
            else { PrintedName = FirstName + " " + LastName; }
            NameOutput.Text = PrintedName + Nickname;
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            //this is to say that user provided no input apart from species            
            Random random = new Random();
            if (Male.IsChecked == false && Female.IsChecked == false && nick == false && family == false)
            { NameOutput.Text = "Please select some input for your hero!"; }
            //this enables to generate just a random nickname from the list
            else if (Male.IsChecked == false && Female.IsChecked == false && family ==false && nick == true) 
            {
                AddNickname();
                NameOutput.Text = Nickname;
            }
            else
            switch (species)
            {
                // this switch is tied to radio buttons, enables to generate the proper name based on input
                // the male/female and family name are selected via booleans
                case "Dwarves":
                    Dwarf dwarf = new Dwarf();
                    AddNickname();                    
                    if (family == true)
                    {
                        int length = dwarf.FamilyName.Count;
                        listNumber = random.Next(0, length);
                        LastName = dwarf.FamilyName[listNumber];
                    }

                    if (male == true)
                    {
                        int length = dwarf.Males.Count;
                        listNumber = random.Next(0, length);
                        FirstName = dwarf.Males[listNumber];
                        printFullName();
                        break;
                    }
                    else
                    {
                        int length = dwarf.Females.Count;
                        listNumber = random.Next(0, length);
                        FirstName = dwarf.Females[listNumber];
                        printFullName();
                        break;
                    }
                case "Elf":
                        Elf elf = new Elf();
                        AddNickname();
                        if (family == true)
                        {
                            int length = elf.FamilyName.Count;
                            listNumber = random.Next(0, length);
                            LastName = elf.FamilyName[listNumber];
                        }

                        if (male == true)
                        {
                            int length = elf.Males.Count;
                            listNumber = random.Next(0, length);
                            FirstName = elf.Males[listNumber];
                            printFullName();
                            break;
                        }
                        else
                        {
                            int length = elf.Females.Count;
                            listNumber = random.Next(0, length);
                            FirstName = elf.Females[listNumber];
                            printFullName();
                            break;
                        }
                    case "Halfling":
                    Halfling halfling = new Halfling();
                    AddNickname();
                    if (family == true)
                    {
                        int length = halfling.FamilyName.Count;
                        listNumber = random.Next(0, length);
                        LastName = halfling.FamilyName[listNumber];
                    }

                    if (male == true)
                    {
                        int length = halfling.Males.Count;
                        listNumber = random.Next(0, length);
                        FirstName = halfling.Males[listNumber];
                        printFullName();
                        break;
                    }
                    else
                    {
                        int length = halfling.Females.Count;
                        listNumber = random.Next(0, length);
                        FirstName = halfling.Females[listNumber];
                        printFullName();
                        break;
                    }
                case "Human":
                    Human human = new Human();
                    AddNickname();
                    if (family == true)
                    {
                        int length = human.FamilyName.Count;
                        listNumber = random.Next(0, length);
                        LastName = human.FamilyName[listNumber];
                    }

                    if (male == true)
                    {
                        int length = human.Males.Count;
                        listNumber = random.Next(0, length);
                        FirstName = human.Males[listNumber];
                        printFullName();
                        break;
                    }
                    else
                    {
                        int length = human.Females.Count;
                        listNumber = random.Next(0, length);
                        FirstName = human.Females[listNumber];
                        printFullName();
                        break;
                    }
                case "Noble":
                    Noble noble = new Noble();
                    AddNickname();
                    if (family == true)
                    {
                        int length = noble.FamilyName.Count;
                        listNumber = random.Next(0, length);
                        LastName = noble.FamilyName[listNumber];
                    }

                    if (male == true)
                    {
                        int length = noble.Males.Count;
                        listNumber = random.Next(0, length);
                        FirstName = noble.Males[listNumber];
                        printFullName();
                        break;
                    }
                    else
                    {
                        int length = noble.Females.Count;
                        listNumber = random.Next(0, length);
                        FirstName = noble.Females[listNumber];
                        printFullName();
                        break;
                    }
                    default:
                    //should never be seen, as conditions should never be met; left for bugfixing
                    NameOutput.Text = "Oops! Something went wrong!";
                    break;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (NameOutput.Text != "Please select some input for your hero!" && NameOutput.Text != "Press \"Generate\" to create a new hero!" && !HeroList.Items.Contains (NameOutput.Text))
            {
                Hero = NameOutput.Text;
                HeroList.Items.Add(Hero);
            }
        }


        private void Blank_Click(object sender, RoutedEventArgs e)
        {
            HeroList.Items.Clear();
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            var exports = new StringBuilder();
            foreach (var item in HeroList.Items)
            {
                exports.AppendLine (item.ToString ());
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "NPC list";
            saveFileDialog.Filter = "txt file|*.txt";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            if (saveFileDialog.ShowDialog() == true) 
            {
                File.WriteAllText (saveFileDialog.FileName, exports.ToString ());
            }
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
            HeroList.Items.Remove(HeroList.Items.GetItemAt(HeroList.Items.Count -1));
        }

        private void Halfling_Checked(object sender, RoutedEventArgs e)
        {
            species = "Halfling";
        }

        private void Human_Checked(object sender, RoutedEventArgs e)
        {
            species = "Human";
        }

        private void Noble_Checked(object sender, RoutedEventArgs e)
        {
            species = "Noble";
        }

        private void HeroList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            HeroList.Items.Remove(HeroList.SelectedItem);
        }
    }
}
