using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Name_Generator
{
    public class Halfling
    {
        Random random = new Random();

        public List<string> Males = new List<string> { "Grodo", "Ondo", "Nigel", "Milo", "Barret", "Manco", "Errol", "Alto", "Eldo", "Federico", "Jorry", "Rodney", "Umbo", "Arno", "Trogo", "Corgo" };
        public List<string> Females = new List<string> { "Alora", "Lily", "Violet", "Marigold", "Rose", "Jenny", "Tina", "Alina", "Mina", "Nina", "Dani", "Daisy", "Orola", "Elena", "Iris", "Pola" };

        public List<string> FamilyName = new List<string> { "Hairfoot", "Longarm", "Applebarrel", "Lightfoot", "Harefoot", "Shorthill", "Sharpeye", "Bakerhat", "Woodwall", "Cateye", "Rockcatcher", "Ninefingers", "Wonderhill", "Meadowfoot", "Strongheart", "Breadbarrow" };
    }
}
