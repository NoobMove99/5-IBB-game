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

            Hero h1 = new Hero();
            h1.SetStartHealth(150);
            h1.Name = "Alec";
            h1.SetWeapon(weapons.fist);
            h1.Money = 0;

            Goblin g1 = new Goblin();
            g1.SetStartHealth(110);
            g1.Name = "Niels";
            g1.Type = types.normal_goblin;

            Prinses p1 = new Prinses();
            p1.Name = "Anneleen";
            p1.Leeftijd = 17;
            p1.HairColor = HairColors.Brunette;

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
                h1.Name = Console.ReadLine();
                Console.WriteLine(h1.Name + " gaat op weg.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(h1.Name + " komt een goblin tegen op de weg. Hoe wil je hem noemen?");
                g1.Name = Console.ReadLine();
                Console.WriteLine("De goblin loopt op je af! Wilt u "+g1.Name+" aanvallen?(typ ja of nee)");
                string aanval = Console.ReadLine().ToLower();

                if (aanval == "ja" && g1.Health >= 1)
                {
                    h1.Attack(g1);
                    Console.WriteLine(h1.Name + " valde " + g1.Name + " aan en nu heeft " + g1.Name + " nog " + g1.Health + " HP over.");
                }
                else if (aanval == "ja" && g1.Health == 0)
                {
                    Console.WriteLine(h1.Name + " begroef de goblin " + g1.Name + " en liet hem zo eindelijk tot rust komen.");
                }
                else if (aanval == "nee")
                {
                    Console.WriteLine("Ze staren elkaar aan...");
                }
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(g1.Name+" is bang en loopt weg.");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine(h1.Name + " vervolgd zijn weg");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(h1.Name + " komt aan bij een kasteel en klopt op de grote houten poort.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("De poort gaat open en voor " + h1.Name + " staat een schone prinses.");
                Console.WriteLine("Hoe heet deze prinses?");
                p1.Name = Console.ReadLine();
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine(p1.Name + " vraagt of je wilt blijven eten.(ja of nee)");
                string eten = Console.ReadLine();
                if (eten == "ja")
                {
                    Console.WriteLine(h1.Name + " gaat binnen en krijgt een HP-Boost");
                    h1.Health += 50;
                    Console.WriteLine(h1.Name + " heeft nu een Hp van: " + h1.Health);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(h1.Name + " neemt afscheid van " + h1.Name + " en vervolgt zijn weg.");  
                }
                else if (eten == "nee")
                {
                    Console.WriteLine(h1.Name + " verlaat het kasteel.");
                }
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine(h1.Name + " komt aan een kruispunt en hij heeft drie opties(rechtdoor,links,rechts).");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Welke weg wil je inslaan?");
                string weg = Console.ReadLine();
                if (weg == "rechtdoor")
                {
                    Console.WriteLine(h1.Name + " stapt rechtdoor.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(h1.Name + " komt in een bos en ziet in de verte een hutje staan.");
                    Console.WriteLine("Wilt u binnengaan?(ja of nee)");
                    string enter = Console.ReadLine();
                    if (enter == "ja")
                    {
                        Console.WriteLine(h1.Name + " gaat binnen en ziet een oude man in een stoel zitten.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("De oude man begint te vertellen...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("Othmane's lore");
                    }
                    else if (enter == "nee")
                    {
                        Console.WriteLine(h1.Name + " stapt langs het huisje en valt in een diepe put.");
                        System.Threading.Thread.Sleep(5000);
                        Console.WriteLine(h1.Name + " sterft van de dorst.");
                        System.Threading.Thread.Sleep(2500);
                        Environment.Exit(0);
                    }
                }
                else if (weg == "links")
                {
                    Console.WriteLine(h1.Name + " gaat naar links.");
                    Console.WriteLine("Hij komt aan een groot meer.");
                    Console.WriteLine("Wil je erdoor zwemmen of eromheen gaan?(z of e)");
                    string meer = Console.ReadLine().Substring(0, 1).ToUpper();
                    if (meer == "Z")
                    {
                        Console.WriteLine(h1.Name + " komt veilig aan de overkant.");
                    }
                    else if (meer == "E")
                    {
                        Console.WriteLine("Op de weg staat er een beer van " + Bruno.grootte + " en met een HP van " + Bruno.Health);
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine(h1.Name + " wordt aangevallen door de beer.");
                        Console.WriteLine("Wilt u aanvallen?(ja of nee)");
                        string beer = Console.ReadLine();
                        if (beer == "ja")
                        {
                            h1.AttackBeer(Bruno);
                            Console.WriteLine(h1.Name + " valt de beer aan.");
                            System.Threading.Thread.Sleep(2500);
                            Console.WriteLine("De beer heeft nu nog " + Bruno.Health + " HP over.");
                            Console.WriteLine("De beer is geschrokken van jouw moed en loopt weg.");
                            Console.WriteLine(h1.Name + " rust even uit en stapt dan weer verder.");

                        }
                        else if (beer == "nee")
                        {
                            Console.WriteLine(h1.Name + " wordt opgegeten door de beer.");
                            System.Threading.Thread.Sleep(3000);
                            Environment.Exit(0);
                        }
                    }
                }
                else if (weg == "rechts")
                {
                    Console.WriteLine(h1.Name + " gaat naar rechts.");
                    Console.WriteLine(h1.Name + " ziet een chest liggen.");
                    Console.WriteLine("Wil je deze chest openmaken?(ja of nee)");
                    string chest = Console.ReadLine();
                    if (chest == "ja")
                    {
                        Console.WriteLine(h1.Name + " vindt 500 euro.");
                        h1.Money += 500;
                    }
                    else if (chest == "nee")
                    {
                        Console.WriteLine(h1.Name + " vervolgt zijn weg.");
                    }
                }
                System.Threading.Thread.Sleep(5000);
                Console.WriteLine("Je komt aan een klein stadje met een paar huizen en een paar winkeltjes.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Wat wil je eerst doen?(supermarkt of wapenwinkel)");
                string winkel = Console.ReadLine();
                if (winkel=="supermarkt")
                {
                    Console.WriteLine("Je koopt wat ravioli.");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Wil je het nu opeten?");
                    string supermarkt = Console.ReadLine();
                    if (supermarkt=="ja")
                    {
                        Console.WriteLine(h1.Name + " krijgt een HP-boost");
                        h1.Health += 50;
                        Console.WriteLine(h1.Name + " zijn HP is nu " + h1.Health + " HP.");
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
                Console.WriteLine(h1.Name + " ziet een hotel staan. Wil je er overnachten?");
                string hotel = Console.ReadLine();
                if (hotel=="ja")
                {
                    Console.WriteLine("Een kamer kost 50 euro. Wil je hier overnachten?");
                    string kamer = Console.ReadLine();
                    if (kamer=="ja")
                    {
                        Console.WriteLine(h1.Name + " betaalt 50 euro en gaat op zijn bed liggen.");
                        h1.Money -= 50;
                    }
                    else if (kamer=="nee")
                    {
                        Console.WriteLine(h1.Name + " verlaat het hotel en gaat terug op weg...");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine(h1.Name + " valt van de vermoeidheid op de grond in slaap.");
                        System.Threading.Thread.Sleep(2000);
                        Console.WriteLine("'s nachts wordt hij overvallen en hij is 100 euro kwijt.");
                        h1.Money -= 100;
                        Console.WriteLine(h1.Name + " heeft nu nog " + h1.Money + " over.");
                    }
                    Console.WriteLine(h1.Name + " stapt voor twee dagen aan één stuk en komt aan een splitsing.");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Welke weg wil je nemen(rechts of links)?");
                    string splitsing = Console.ReadLine();
                    if (splitsing=="rechts")
                    {
                        Console.WriteLine(h1.Name + " neemt het rechtse pad.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("lemao");
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
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("System shutdown in 3,2,1,...");
                    System.Threading.Thread.Sleep(3000);
                    Environment.Exit(0);
                }
            }
            Console.Read();
        }            
     }
            
  }
    


