using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_prins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Hero Alec = new Hero();
            Alec.SetStartHealth(150);
            Alec.Name = "Alec";
            Alec.SetWeapon(weapons.fist);
            Alec.Money = 0;

            Goblin Niels = new Goblin();
            Niels.SetStartHealth(110);
            Niels.Name = "Niels";
            Niels.Type = types.normal_goblin;

            Prinses Anneleen = new Prinses();
            Anneleen.Name = "Anneleen";
            Anneleen.Leeftijd = 17;
            Anneleen.HairColor = HairColors.Brunette;

            Beer Bruno = new Beer();
            Bruno.Name = "Bruno";
            Bruno.Health = 350;
            Bruno.grootte = 250;

            List<string> rugzak = new List<string>();
            string ravioli = "ravioli";

            Console.WriteLine("Welkom bij Hero's and Goblins.");
            Console.WriteLine("Wilt u een nieuw spel starten?(ja of nee)");
            string start = Console.ReadLine();
            if (start == "ja")
            {
                Console.WriteLine("Geef de naam in van je held: ");
                Alec.Name = Console.ReadLine();
                Console.WriteLine(Alec.Name + " gaat op weg.");
                Console.WriteLine(Alec.Name + " komt een goblin tegen op de weg. Hoe wil je hem noemen?");
                Niels.Name = Console.ReadLine();
                Console.WriteLine("Wilt u "+Niels.Name+" aanvallen?(typ ja of nee)");
                string aanval = Console.ReadLine().ToLower();

                if (aanval == "ja" && Niels.Health >= 1)
                {
                    Alec.Attack(Niels);
                    Console.WriteLine(Alec.Name + " valde " + Niels.Name + " aan en nu heeft " + Niels.Name + " nog " + Niels.Health + " HP over.");
                }
                else if (aanval == "ja" && Niels.Health == 0)
                {
                    Console.WriteLine(Alec.Name + " begroef de goblin " + Niels.Name + " en liet hem zo eindelijk tot rust komen.");
                }
                else if (aanval == "nee")
                {
                    Console.WriteLine("Ze staren elkaar aan...");
                }
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(Niels.Name+" is bang en loopt weg.");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine(Alec.Name + " vervolgd zijn weg");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(Alec.Name + " komt aan bij een kasteel en klopt op de grote houten poort.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("De poort gaat open en voor " + Alec.Name + " staat een schone prinses.");
                Console.WriteLine("Hoe heet deze prinses?");
                Anneleen.Name = Console.ReadLine();
                Console.WriteLine(Anneleen.Name + " vraagt of je wilt blijven eten.(ja of nee)");
                string eten = Console.ReadLine();
                if (eten == "ja")
                {
                    Console.WriteLine(Alec.Name + " gaat binnen en krijgt een HP-Boost");
                    Alec.Health += 50;
                    Console.WriteLine(Alec.Name + " heeft nu een Hp van: " + Alec.Health);
                }
                else if (eten == "nee")
                {
                    Console.WriteLine(Alec.Name + " verlaat het kasteel.");
                }
                Console.WriteLine(Alec.Name + " komt aan een kruispunt en hij heeft drie opties(rechtdoor,links,rechts).");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Welke weg wil je inslaan?");
                string weg = Console.ReadLine();
                if (weg == "rechtdoor")
                {
                    Console.WriteLine(Alec.Name + " stapt rechtdoor.");
                    Console.WriteLine(Alec.Name + " komt in een bos en ziet in de verte een hutje staan.");
                    Console.WriteLine("Wilt u binnengaan?(ja of nee)");
                    string enter = Console.ReadLine();
                    if (enter == "ja")
                    {
                        Console.WriteLine(Alec.Name + " gaat binnen en ziet een oude man in een stoel zitten.");
                        Console.WriteLine("De oude man begint te vertellen...");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("Othmane's lore");
                    }
                    else if (enter == "nee")
                    {
                        Console.WriteLine(Alec.Name + " stapt langs het huisje en valt in een diepe put.");
                        Console.WriteLine(Alec.Name + " sterft van de dorst.");
                        System.Threading.Thread.Sleep(2500);
                        Environment.Exit(0);
                    }
                }
                else if (weg == "links")
                {
                    Console.WriteLine(Alec.Name + " gaat naar links.");
                    Console.WriteLine("Hij komt aan een groot meer.");
                    Console.WriteLine("Wil je erdoor zwemmen of eromheen gaan?(z of e)");
                    string meer = Console.ReadLine().Substring(0, 1).ToUpper();
                    if (meer == "Z")
                    {
                        Console.WriteLine(Alec.Name + " komt veilig aan de overkant.");
                    }
                    else if (meer == "E")
                    {
                        Console.WriteLine("Op de weg staat er een beer van " + Bruno.grootte + " en met een HP van " + Bruno.Health);
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine(Alec.Name + " wordt aangevallen door de beer.");
                        Console.WriteLine("Wilt u aanvallen?(ja of nee)");
                        string beer = Console.ReadLine();
                        if (beer == "ja")
                        {
                            Alec.AttackBeer(Bruno);
                            Console.WriteLine(Alec.Name + " valt de beer aan.");
                            System.Threading.Thread.Sleep(2500);
                            Console.WriteLine("De beer heeft nu nog " + Bruno.Health + " HP over.");
                            Console.WriteLine("De beer is geschrokken van jouw moed en loopt weg.");
                            Console.WriteLine(Alec.Name + " rust even uit en stapt dan weer verder.");

                        }
                        else if (beer == "nee")
                        {
                            Console.WriteLine(Alec.Name + " wordt opgegeten door de beer.");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (weg == "rechts")
                {
                    Console.WriteLine(Alec.Name + " gaat naar rechts.");
                    Console.WriteLine(Alec.Name + " ziet een chest liggen.");
                    Console.WriteLine("Wil je deze chest openmaken?(ja of nee)");
                    string chest = Console.ReadLine();
                    if (chest == "ja")
                    {
                        Console.WriteLine(Alec.Name + " vindt 500 euro.");
                        Alec.Money += 500;
                    }
                    else if (chest == "nee")
                    {
                        Console.WriteLine(Alec.Name + " vervolgt zijn weg.");
                    }
                }
                Console.WriteLine("Je komt aan een klein stadje met een paar huizen en een paar winkeltjes.");
                Console.WriteLine("Wat wil je eerst doen?(supermarkt of wapenwinkel)");
                string winkel = Console.ReadLine();
                if (winkel=="supermarkt")
                {
                    Console.WriteLine("Je koopt wat eten.");
                    Console.WriteLine("Wil je het nu opeten?");
                    string supermarkt = Console.ReadLine();
                    if (supermarkt=="ja")
                    {
                        Console.WriteLine(Alec.Name + " krijgt een HP-boost");
                        Alec.Health += 50;
                        Console.WriteLine(Alec.Name + " zijn HP is nu " + Alec.Health + " HP.");
                    }
                    else if (supermarkt=="nee")
                    {
                        Console.WriteLine("Je stopt het eten in de voedselzak van je rugzak.");
                        rugzak.Add(ravioli);
                    }
                }
                else if (winkel=="wapenwinkel")
                {
                    Console.WriteLine("Welk wapen wil je kopen?(sword,axe,dagger,geen wapen,katana of poison dagger)");
                    string nieuwwapen = Console.ReadLine();
                    Console.WriteLine("Je hebt nu een " + nieuwwapen + ".");
                }
                Console.WriteLine(Alec.Name + " ziet een hotel staan. Wil je er overnachten?");
                string hotel = Console.ReadLine();
                if (hotel=="ja")
                {
                    Console.WriteLine("Een kamer kost 50 euro. Wil je hier overnachten?");
                    string kamer = Console.ReadLine();
                    if (kamer=="ja")
                    {
                        Console.WriteLine(Alec.Name + " betaalt 50 euro en gaat op zijn bed liggen.");
                        Alec.Money -= 50;
                    }
                    else if (kamer=="nee")
                    {
                        Console.WriteLine(Alec.Name + " verlaat het hotel en gaat terug op weg...");
                        Console.WriteLine(Alec.Name + " valt van de vermoeidheid op de grond in slaap.");
                        Console.WriteLine("'s nachts wordt hij overvallen en hij is 100 euro kwijt.");
                        Alec.Money -= 100;
                        Console.WriteLine(Alec.Name + " heeft nu nog " + Alec.Money + " over.");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Wilt u afsluiten?(ja of nee)");
                string sluit = Console.ReadLine();
                if (sluit == "ja")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("U done fucked up.");
                    Console.WriteLine("System shutdown in 3,2,1,...");
                    System.Threading.Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
            Console.Read();
        }            
     }
            
  }
    


