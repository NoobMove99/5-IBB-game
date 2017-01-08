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
            Goblin shmet = new Goblin();
            shmet.SetStartHealth(120);
            shmet.Type = types.normal_goblin;
            Hero Alec = new Hero();
            Alec.Name = "Alec The Great and Powerfull, he who wields the allmighty sword of anti autism also known as 'Das bruut hé'";
            Alec.SetStartHealth(120);
            Console.WriteLine(Alec.Name+" Je start hp is: " + Alec.Health);
            Alec.SetWeapon(weapons.sword);
            Hero Othmane = new Hero();
            Othmane.Name = "Othmane the almighty willy-slayer he who holds the power of the Yasuo-skills also known as 'The immortal Fucker of justice'";
            int value = (int)Alec.GetWeapon();
            Console.WriteLine("Je wapen is een " + Alec.GetWeapon());
            Alec.InLoveWithPrincess = true;
            if (Othmane.SetStartHealth(110))
            {
                Console.WriteLine(Othmane.Name+" Je HP is ingesteld op " + Othmane.Health + ".");
            }
            else
            {
                Console.WriteLine("Mislukt. HP was al ingesteld");
            }
            if (Othmane.SetStartHealth(110))
            {
                Console.WriteLine("HP ingesteld op " + Othmane.Health + ".");
            }
            else
            {
                Console.WriteLine("Mislukt. HP was al ingesteld");
            }
            Othmane.SetWeapon(weapons.Katana);
            Console.WriteLine("Je wapen is een "+Othmane.GetWeapon());
            Alec.Attack(shmet, 40);
            Console.WriteLine("Alec valt shmet(de goblin) aan.");
            Console.WriteLine("De goblin heeft nu nog " + shmet.Health);
            Console.Read();
        }
    }
}
