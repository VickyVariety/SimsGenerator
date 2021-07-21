using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsGenerator
{
    public enum Traits
    {
        ACTIVE,
        GLUTTON,
        ROMANTIC,
        CREATIVE,
        GLOOMY,
        CHILD_OF_THE_ISLANDS,
        GOOD,
        EVIL,
        FOODIE,
        SLOB,
        NEAT,
        CHEERFUL,
        HOT_HEADED,
        SELF_ASSURED,
        HATES_CHILDREN,
        UNFLIRTY,
        ART_LOVER,
        BOOK_WORM,
        MUSIC_LOVER,
        PERFECTIONIST,
        AMBITIOUS,
        CHILDISH,
        CLUMSY,
        ERRATIC,
        KLEPTOMANIAC,
        LAZY,
        LOVES_OUTDOORS,
        MATERIALISTIC,
        SNOB,
        SQUEAMISH,
        VEGETARIAN,
        BRO,
        FAMILY_ORIENTED,
        JEOLOUS,
        LONER,
        MEAN,
        NONCOMMITTAL,
        OUTGOING
    }
    public class Sim
    {
        public int amountOfSims = Convert.ToInt32(Console.ReadLine());

        public List<Traits> GetRandomNumTraits()
        {
            return
                Enum.GetValues(typeof(Traits)
        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
                        
        }
        static void PrintResult(List<Sim> generatedSims)
        {
            foreach (Sim sim in generatedSims)
            {
                Console.WriteLine(sim.ToString());
            }
        }
    }
}
