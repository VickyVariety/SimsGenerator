using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimsGenerator
{
    public class NameStorage
    {
        public static Dictionary<Culture, List<string>> lastNames = new Dictionary<Culture, List<string>>()
        {
            {
                Culture.ALIEN, new List<string>()
                {
                    "Mauglander",
                    "Badork",
                    "Phascoix",
                    "Kholva",
                    "Bhunox",
                    "Sizhut",
                    "Uzopoc",
                    "Fanguul",
                    "Thustu",
                    "Nusdaanval",
                    "Monowor",
                    "Lusnul",
                    "Munbuunwor",
                    "Shilnowor",
                    "Lisdu",
                    "Simdunvaal",
                    "Nannim",
                    "Raslaaval",
                    "Sasnaal",
                    "Thonoval",
                    "Cinmin",
                    "Talgys",
                    "Mallikk",
                    "Ez'eks",
                    "Ugzex",
                    "Fal'aih",
                    "Hikur",
                    "Narreox",
                    "Phihlai",
                    ""
                }
            },
            {
                Culture.AFRICAN, new List<string>()
                {
                    "African Surname 1",
                    "African Surname 2"
                }
            },
            {
                Culture.ASIAN, new List<string>()
                {
                    "Asian Surname 1",
                    "Asian Surname 2"
                }
            },
            {
                Culture.WESTERN, new List<string>()
                {
                    "Western Surname 1",
                    "Western Surname 2"
                }
            },
            {
                Culture.VAMPIRE, new List<string>()
                {
                    "Vampire Surname 1",
                    "Vampire Surname 2"
                }
            },
            {
                Culture.OCCULT, new List<string>()
                {
                    "Occult Surname 1",
                    "Occult Surname 2"
                }
            },
            {
                Culture.MIDDLE_EASTERN, new List<string>()
                {
                    "Middle-Eastern Surname 1",
                    "Middle-Eastern Surname 2"
                }
            },
            {
                Culture.RUSSIAN, new List<string>()
                {
                    "Russian Surname 1",
                    "Russian Surname 2"
                }
            },
        };
        //THIS IS A DUMMY DATABASE, ALSO VERY LAZY, ALSO DUMB
        public static Dictionary<Culture, Dictionary<Gender, List<string>>> names = new Dictionary<Culture, Dictionary<Gender, List<string>>>() 
        {
            {
                Culture.ALIEN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Zork",
                            "Cyth",
                            "Caelum",
                            "Cygnus",
                            "Neptune",
                            "Xabiere",
                            "Xadrian",
                            "Guxthaph",
                            "Xan",
                            "Xanthos",
                            "Zaden",
                            "Zadox",
                            "Zakai",
                            "Zaragosa",
                            "Zaviero",
                            "Zephyr",
                            "Raxmuzh",
                            "Mykaehl",
                            "Taariq",
                            "Xanadu",
                            "Zailor",
                            "Xias",
                            "Xabeqa",
                            "Zharor",
                            "Nipunus",
                            "Izar",
                            "Xiryus",
                            "Zenith",
                            "Xabiq",
                            "Zynyx",
                            "Eelyo",
                            "Acrux",
                            "Anzhul",
                            "Belanozh",
                            "Ulyx",
                            "Lynxar",
                            "Anakin",
                            "Atreyu",
                            "Gaius",
                            "Xavier",
                            "Kylo",
                            "Morpheus",
                            "Zonor",
                            "Azoux",
                            "Aphyx",
                            "Dzek",
                            "Credo",
                            "Hallox",
                            "Izix",
                            "Ion",
                            "Xyphen"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Alyxa",
                            "Canopa",
                            "Celestia",
                            "Geleexa",
                            "Nebula",
                            "Neoma",
                            "Olexa",
                            "Ozma",
                            "Eldredth",
                            "Gilina",
                            "Kreia",
                            "Luminara",
                            "Natira",
                            "Noranti",
                            "Rinya",
                            "Ziona",
                            "Zhora",
                            "Starlee",
                            "Rexalla",
                            "Xannon",
                            "Xandria",
                            "Xanthippe",
                            "Zagorka",
                            "Zea",
                            "Lyra",
                            "Andromeda",
                            "Trella",
                            "Alpha",
                            "Adhara",
                            "Ascella",
                            "Asterope",
                            "Astra",
                            "Aurora",
                            "Cassiopeia",
                            "Nashira",
                            "Benexia",
                            "Cytherea",
                            "Delyth",
                            "Eilonwy",
                            "Illyria",
                            "Ferelith",
                            "Mireia",
                            "Octavia",
                            "Nymeria",
                            "Sayyadina",
                            "Zephyr",
                            "Zephyrine",
                            "Zathura",
                            "Xyndrela",
                            "Orithina"
                        }
                    },
                }
            },
            {
                Culture.VAMPIRE, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>(){
                            "Vladimir",
                            "Cassius",
                            "Lazarus",
                            "Sebastien",
                            "Kieran",
                            "Drake",
                            "Edward",
                            "Stephan",
                            "Damon",
                            "Godfrey",
                            "Zane",
                            "Darick",
                            "Zaros",
                            "Nikolas",
                            "Leon",
                            "Alaric",
                            "Cassius",
                            "Orpheus",
                            "Luther",
                            "Raul",
                            "Silas",
                            "Aleister",
                            "Athan",
                            "Demetrius",
                            "Dmitri",
                            "Mortimer",
                            "Rufus",
                            "Willfred",
                            "Magnus",
                            "Braeden",
                            "Draven",
                            "Jareth",
                            "Spike",
                            "Cleon",
                            "Donovan",
                            "Lucien",
                            "Fabian",
                            "Raphael",
                            "Marcel",
                            "Zachaeus",
                            "Frederick",
                            "Edwin",
                            "Valentine",
                            "Lancelot",
                            "Benedict",
                            "Isaiah",
                            "Maxwell",
                            "Gregory",
                            "Elijah",
                            "Theron",
                            "Zachariah"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Belladonna",
                            "Irina",
                            "Lilah",
                            "Lilith",
                            "Eleanor",
                            "Rosalyn",
                            "Jacqueline",
                            "Amber",
                            "Esme",
                            "Bianca",
                            "Judith",
                            "Edith",
                            "Ada",
                            "Agnes",
                            "Agatha",
                            "Blanche",
                            "Adelia",
                            "Clementine",
                            "Cordelia",
                            "Emmeline",
                            "Estelle",
                            "Ethel",
                            "Melita",
                            "Mildred",
                            "Penelope",
                            "Viola",
                            "Zadie",
                            "Myrtle",
                            "Mae",
                            "Irene",
                            "Effie",
                            "Arabella",
                            "Gertrude",
                            "Daphne",
                            "Temperance",
                            "Ruth",
                            "Eliza",
                            "Anne",
                            "Eve",
                            "Rosamund",
                            "Gillian",
                            "Millicent",
                            "Cornelia",
                            "Florence",
                            "Cecily",
                            "Joanne",
                            "Guenevere",
                            "Rosanna",
                            "Catherine",
                            "Rose",
                            "Isobel"
                        }
                    },
                }
            },
            {
                Culture.ASIAN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Asian Male 1",
                            "Asian Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Asien Female 1",
                            "Asien Female 2"
                        }
                    },
                }
            },
            {
                Culture.RUSSIAN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Russian Male 1",
                            "Russian Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Russian Female 1",
                            "Russian Female 2"
                        }
                    },
                }
            },
            {
                Culture.WESTERN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Western Male 1",
                            "Western Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Western Female 1",
                            "Western Female 2"
                        }
                    },
                }
            },
            {
                Culture.OCCULT, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Occult Male 1",
                            "Occult Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Occult Female 1",
                            "Occult Female 2"
                        }
                    },
                }
            },
            {
                Culture.AFRICAN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Afrian Male 1",
                            "Afrian Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Afrian Female 1",
                            "African Female 2"
                        }
                    },
                }
            },
            {
                Culture.MIDDLE_EASTERN, new Dictionary<Gender, List<string>>()
                {
                    {
                        Gender.MALE, new List<string>()
                        {
                            "Middle Eastern Male 1",
                            "Middle Eastern Male 2"
                        }
                    },
                    {
                        Gender.FEMALE, new List<string>(){
                            "Middle Eastern Female 1",
                            "Middle Eastern Female 2"
                        }
                    },
                }
            },
        };
        
    }

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

    public enum Age
    {
        TODDLER,
        CHILD,
        TEEN,
        YOUNG_ADULT,
        ADULT,
        ELDER
    }

    public enum Gender
    {
        FEMALE,
        MALE
    }
    public enum Culture
    {
        WESTERN,
        AFRICAN,
        ASIAN,
        RUSSIAN,
        ALIEN,
        VAMPIRE,
        OCCULT,
        MIDDLE_EASTERN
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
    public enum ToddlerTraits
    {
        ANGELIC,
        CHARMER,
        CLINGY,
        FUSSY,
        INDEPENDENT,
        INQUISITIVE,
        SILLY,
        WILD
    }
    public class Sim
    {
        string name;
        string lastName;
        Random random;
        Gender gender;
        Culture culture;
        List<Trait> traits = new List<Trait>();

        public Sim(int seed)
        {
            random = new Random(seed);
            
            traits = GetRandomNumTraits();
            gender = GetRandomGender();
            culture = GetRandomCulture();
            name = GetProceduralName();
            lastName = GetProceduralLastName();
        }

        private string GetProceduralLastName()
        {
            List<string> availableLastNames = NameStorage.lastNames[culture];
            return availableLastNames[random.Next(availableLastNames.Count)];
        }

        private string GetProceduralName()
        {
            List<string> availableNames = NameStorage.names[culture][gender];
            return availableNames[random.Next(availableNames.Count)];
        }

        private Culture GetRandomCulture()
        {
            Culture[] values = (Culture[])Enum.GetValues(typeof(Culture));
            return (Culture)values.GetValue(random.Next(values.Length));
        }

        private Gender GetRandomGender()
        {
            Gender[] values = (Gender[])Enum.GetValues(typeof(Gender));
            return (Gender)values.GetValue(random.Next(values.Length));
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
            /*int x = 2;
            string str = "hej";
            return $"my first value:{1} my second value {x} and also a string value {str}";*/
            return $"{name} {lastName}\n {gender}\n {culture}\n {string.Join(", ", traits).Replace("__", "-").Replace("_", " ").ToLower()}";
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