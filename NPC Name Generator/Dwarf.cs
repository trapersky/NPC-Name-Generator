using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Name_Generator
{
    public class Dwarf
    {
        Random random = new Random();

        public List<string> Males = new List<string> {"Bjarni", "Ulf", "Wulfgar", "Orri", "Snorri", "Rockham", "Thorgar", "Ulfen", "Ragnar", "Korgan", "Kagain", "Kagaln", "Morri", "Lokir", "Durgan", "Norri" };
        public List<string> Females = new List<string> { "Ulfa", "Gwynn", "Brunhild", "Morra", "Ferri", "Orrina", "Frigg", "Bjor", "Cherri", "Monna", "Fredda", "Wulfhild", "Thorri", "Yrsa", "Ursa", "Ynge" };

        public List<string> FamilyName = new List<string> { "Ragnarssen", "Ironhand", "Stonefist", "Rockwool", "Steelshank", "Wulfsen", "Bjarnisson", "Stoneface", "Steinschwert", "Ironheart", "Orkslayer", "Goblinbane", "Axethrower", "Bergwerker", "Rocklobber", "Eisenhaltig" };
       
    }
}
