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
    public class Trait
    {
        public static List<Trait> traits = new List<SimsGenerator.Trait>()
        {
            new Trait(
                "Romantic",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Unflirty" }
            ),
            new Trait(
                "Unflirty",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Romantic" }
            ),
            new Trait(
                "Good",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Evil", "Mean", "Kleptomaniac" }
            ),
            new Trait(
                "Kleptomaniac",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Good" }
            ),
            new Trait(
                "Evil",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Good", "Childish" }
            ),
            new Trait(
                "Childish",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Evil", "Hates children", "Snob" }
            ),
            new Trait(
                "Mean",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Good" }
            ),
            new Trait(
                "Cheerful",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Gloomy", "Hot-headed" }
            ),
            new Trait(
                "Gloomy",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Cheerful", "Hot-headed" }
            ),
            new Trait(
                "Hot-headed",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Cheerful", "Gloomy" }
            ),
            new Trait(
                "Family-oriented",
                new List<Age>(){ Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Hates children", "Noncommittal" }
            ),
            new Trait(
                "Hates children",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Family-oriented", "Childish" }
            ),
            new Trait(
                "Noncommittal",
                new List<Age>(){ Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Family-oriented" }
            ),
            new Trait(
                "Goofball",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Snob" }
            ),
            new Trait(
                "Snob",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Childish", "Goofball" }
            ),
            new Trait(
                "Foodie",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Glutton" }
            ),
            new Trait(
                "Glutton",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Foodie", }
            ),
            new Trait(
                "Lazy",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Neat", "Ambitious", "Active" }
            ),
            new Trait(
                "Neat",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Lazy", "Slob" }
            ),
            new Trait(
                "Slob",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Neat" }
            ),
            new Trait(
                "Loner",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Outgoing" }
            ),
            new Trait(
                "Outgoing",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Loner" }
            ),
            new Trait(
                "Ambitious",
                new List<Age>(){ Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Lazy" }
            ),
            new Trait(
                "Active",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){ "Lazy" }
            ),
            new Trait(
                "Loves outdoors",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER },
                new List<string>(){}
            ),
            new Trait(
                "Materialistic",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Geek",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Vegetarian",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Creative",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Erratic",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Jealous",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Perfectionist",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Genius",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Self-assured",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Music lover",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Bookworm",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Art lover",
                new List<Age>(){ Age.CHILD, Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
            new Trait(
                "Bro",
                new List<Age>(){ Age.TEEN, Age.YOUNG_ADULT, Age.ADULT, Age.ELDER }
            ),
        };
        public List<Age> availableForAges;
        public List<string> collidesWithTraits;
        public Pack availableInPack;
        public string name;

        public Trait(string name, List<Age> availableForAges)
        {
            this.name = name;
            this.availableForAges = availableForAges;
            this.collidesWithTraits = new List<string>();
            this.availableInPack = Pack.BASE_GAME;
        }
        public Trait(string name, List<Age> availableForAges, List<string> collidesWithTraits)
        {
            this.name = name;
            this.availableForAges = availableForAges;
            this.collidesWithTraits = collidesWithTraits;
            this.availableInPack = Pack.BASE_GAME;
        }
        public Trait(string name, List<Age> availableForAges, Pack availableInPack)
        {
            this.name = name;
            this.availableForAges = availableForAges;
            this.collidesWithTraits = new List<string>();
            this.availableInPack = availableInPack;
        }
        public Trait(string name, List<Age> availableForAges, List<string> collidesWithTraits, Pack availableInPack)
        {
            this.name = name;
            this.availableForAges = availableForAges;
            this.collidesWithTraits = collidesWithTraits;
            this.availableInPack = availableInPack;
        }


    }
    
    public enum Pack
    {
        BASE_GAME,
        GET_TO_WORK,
        GET_TOGETHER,
        CITY_LIVING,
        CATS_AND_DOGS,
        SEASONS,
        GET_FAMOUS,
        ISLAND_LIVING,
        DISCOVER_UNIVERSITY,
        ECO_LIFESTYLE,
        SNOWY_ESCAPE,
        COTTAGE_LIVING,
        OUTDOOR_RETREAT,
        SPA_DAY,
        DINE_OUT,
        VAMPIRES,
        PARENTHOOD,
        JUNGLE_ADVENTURE,
        STRANGERVILLE,
        REALM_OF_MAGIC,
        STAR_WARS_JOURNEY_TO_BATUU,
        DREAM_HOME_DECORATOR
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
                /*if (!CheckTraitCompatibility(randomTrait, result))
                    continue;*/
                result.Add(randomTrait);
            }
            return result;
        }

        /*private bool CheckTraitCompatibility(Trait t1, List<Trait> result)
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
        }*/

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
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("==============" + "Enter the amount of Sims to be generated" + "==============");

                int amountOfSims = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Program.PrintPacksLegend();
                List<Pack> packsToUse = Console.ReadLine();
                /*
                Vi ska skapa en metod som tar emot console.readline
                metoden ska returnera en List<Pack> och lagra den i packsToUse
                Komma separerad input ska string splittas och konverteras till int32
                Sedan ska vi ha kul med vad vi får från metoden när vi genererar simmar :)
                */
                


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
        static void PrintPacksLegend()
        {
            foreach (int enumIndex in Enum.GetValues(typeof(Pack)))
            {
                String enumKey = Enum.GetName(typeof(Pack), enumIndex);
                Console.WriteLine($"{enumIndex}, {enumKey}");
                
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