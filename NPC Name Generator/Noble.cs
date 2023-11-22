using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Name_Generator
{
    public class Noble
    {
        public List<string> Males = new List<string> { "Jacques", "Jacob", "Lorenzo", "Richard", "Jean", "Francis", "Johann", "Otto", "Wolfgang", "Baldwin", "Jean", "Emmanuel", "Edmund", "Henry", "Andrew", "Amadeus" };
        public List<string> Females = new List<string> { "Elizabeth", "Lilith", "Anna-Maria", "Tiffany", "Margarita", "Eleonora", "Caroline", "Elise", "Chloe", "Helena", "Colette", "Stella", "Samantha", "Ioanna", "Abigail", "Amelia"};

        public List<string> FamilyName = new List<string> { "di Medico", "de la Croix", "von Schwarzberg", "d'Aqua Verde", "van der Vald", "de Rouges", "de Collines", "von Steinbruck", "de la Cote", "van Dries", "Darkmoorshire", "Whitecliff", "Hollowkeep", "Silverhelm", "d'Azurro", "de la Sera" };
    }
}
