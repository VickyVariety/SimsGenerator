using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsGenerator
{

    public class TraitIncompatibility
    {
        public Trait t1;
        public Trait t2;
        public static List<TraitIncompatibility> incompatible = new List<TraitIncompatibility>()
        {
            new TraitIncompatibility(Trait.GOOD, Trait.EVIL),
            new TraitIncompatibility(Trait.GOOD, Trait.MEAN),
            new TraitIncompatibility(Trait.SLOB, Trait.NEAT),
            new TraitIncompatibility(Trait.SLOB, Trait.SQUEAMISH),
            new TraitIncompatibility(Trait.CHEERFUL, Trait.GLOOMY),
            new TraitIncompatibility(Trait.GLOOMY, Trait.HOT__HEADED),
            new TraitIncompatibility(Trait.UNFLIRTY, Trait.ROMANTIC),
            new TraitIncompatibility(Trait.NONCOMMITTAL, Trait.FAMILY__ORIENTED),
            new TraitIncompatibility(Trait.FAMILY__ORIENTED, Trait.HATES_CHILDREN),
            new TraitIncompatibility(Trait.CHILDISH, Trait.HATES_CHILDREN),
            new TraitIncompatibility(Trait.GLUTTON, Trait.FOODIE),
            new TraitIncompatibility(Trait.GLUTTON, Trait.SQUEAMISH),
            new TraitIncompatibility(Trait.ACTIVE, Trait.LAZY),
            new TraitIncompatibility(Trait.SNOB, Trait.GOOFBALL),
            new TraitIncompatibility(Trait.SNOB, Trait.CHILDISH),
            new TraitIncompatibility(Trait.KLEPTOMANIAC, Trait.GOOD),
            new TraitIncompatibility(Trait.EVIL, Trait.CHILDISH),
            new TraitIncompatibility(Trait.GLUTTON, Trait.FOODIE),
        };

        public TraitIncompatibility(Trait t1, Trait t2)
        {
            this.t1 = t1;
            this.t2 = t2;
        }
    }

    public enum Trait
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
        HOT__HEADED,
        SELF__ASSURED,
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
        FAMILY__ORIENTED,
        JEOLOUS,
        LONER,
        MEAN,
        NONCOMMITTAL,
        OUTGOING,
        GOOFBALL
    }
    public class Sim
    {
        string name;
        Random random;
        List<Trait> traits = new List<Trait>();

        public Sim(int seed)
        {
            random = new Random(seed);
            name = "My Generated Sim: ";
            traits = GetRandomNumTraits();
        }

        public List<Trait> GetRandomNumTraits()
        {
            List<Trait> result = new List<Trait>();

            Trait[] values = (Trait[])Enum.GetValues(typeof(Trait));
            int max = 9999;

            while (result.Count != 3 && max > 0)
            {
                max--;
                Trait randomTrait = (Trait)values.GetValue(random.Next(values.Length));

                if (result.Contains(randomTrait))
                    continue;
                if (!CheckTraitCompatibility(randomTrait, result))
                    continue;
                result.Add(randomTrait);
            }
            return result;
        }

        private bool CheckTraitCompatibility(Trait t1, List<Trait> result)
        {
            foreach (Trait t2 in result)
            {
                foreach (TraitIncompatibility traitIncompatibility in TraitIncompatibility.incompatible)
                {
                    if (traitIncompatibility.t1 == t1 && traitIncompatibility.t2 == t2)
                        return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return $"{name} {string.Join(", ", traits).Replace("__", "-").Replace("_", " ").ToLower()}";
        }

    }
    class Program
    {
        //public int amountOfSims = Convert.ToInt32(Console.ReadLine());
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("==============" + "Enter the amount of Sims to be generated" + "==============");

                int amountOfSims = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                List<Sim> sims = new List<Sim>();
                int max = 999;

                while (amountOfSims > sims.Count)
                {
                    max--;
                    sims.Add(new Sim(sims.Count));
                }

                Program.PrintResult(sims);

                Console.WriteLine("\n\n==============" + "Press [ENTER] to start over" + "==============");
                Console.ReadKey();
                Console.Clear();
            }
        }

        /*
         PrintResult SHOULD ONLY BE CALLED ONCE!
         */
        static void PrintResult(List<Sim> generatedSims)
        {
            foreach (Sim sim in generatedSims)
            {
                Console.WriteLine(sim.ToString());
            }
        }
    }
}