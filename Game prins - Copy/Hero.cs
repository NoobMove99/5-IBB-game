using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_prins
{
    public class Hero
    {
        private weapons _weapon;
        private byte _health;
        private bool _inLoveWithPrincess;
        private string _name;
        private int _money;

        public string Name
        {
            get
            {
                 return _name;
            }

            set
            {
                _name = value;
            }
        }

        public bool InLoveWithPrincess
        {
            get
            {
                int love;
                Random R = new Random();
                love = R.Next(0,2);
                if (love==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            set
            {
                _inLoveWithPrincess = value;
            }
        }

        public byte Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }

        }

        public int Money
        {
            get
            {
                return _money;
            }

            set
            {
                _money = value;
            }
        }

        public weapons GetWeapon()
        {
            return _weapon;
        }

        public void SetWeapon(weapons xd)
        {
            int weapon;
            Random R = new Random();
            weapon = R.Next(0, 6);
            if (weapon==0)
            {
                _weapon = weapons.sword;
            }
            else if (weapon==1)
            {
                _weapon = weapons.axe;
            }
            else if (weapon==2)
            {
                _weapon = weapons.dagger;
            }
            else if (weapon==3)
            {
                _weapon = weapons.fist;
            }
            else if (weapon==4)
            {
                _weapon = weapons.Katana;
            }
            else if (weapon==5)
            {
                _weapon = weapons.poison_dagger;
            }
            
        }

        public bool SetStartHealth(byte health)
        {
            if (_health == 0)
            {
                _health = health;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void FindPotion()
        {
            int Potion;
            Random R = new Random();
            Potion = R.Next(0, 9);
            if (Potion==0)
            {
                _health += 20;
            }
            
        }

        public void Attack(Goblin g)
        {
            if (g.Health <= 0)
            {
                Console.WriteLine("Deze goblin is al dood");
            }
            else
            {
                if (_weapon == weapons.sword)
                {
                    g.Health -= 10;
                    
                }
                else if (_weapon == weapons.axe)
                {
                    g.Health -= 15;
                    
                }
                else if (_weapon == weapons.dagger)
                {
                    g.Health -= 7;
                    
                }
                else if (_weapon == weapons.fist)
                {
                    g.Health -= 3;
                    
                }
                else if (_weapon == weapons.Katana)
                {
                    g.Health -= 40;
                    
                }
                else if (_weapon==weapons.poison_dagger)
                {
                    g.Health -= 50;
                    
                }
            }
        }
        public void AttackBeer(Beer b)
        {
            if (b.Health <= 0)
            {
                Console.WriteLine("Deze beer is al dood");
            }
            else
            {
                if (_weapon == weapons.sword)
                {
                    b.Health -= 10;

                }
                else if (_weapon == weapons.axe)
                {
                    b.Health -= 15;

                }
                else if (_weapon == weapons.dagger)
                {
                    b.Health -= 7;

                }
                else if (_weapon == weapons.fist)
                {
                    b.Health -= 3;

                }
                else if (_weapon == weapons.Katana)
                {
                    b.Health -= 40;

                }
                else if (_weapon == weapons.poison_dagger)
                {
                    b.Health -= 50;

                }
            }
        }

        public void Defence(int armor,Goblin g)
        {
            if (armor==10)
            {
                g.Health += 10;
            }
            else if (armor==20)
            {
                g.Health += 20;
            }
            else if (armor==30)
            {
                g.Health += 30;
            }
            
        }
    }

    public class Goblin
    {
        private string _name;
        private weapons _weapon;
        private string _huidskleur;
        private byte _health;
        private types _type;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public byte Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }

        }

        public types Type
        {
            get
            {
                return _type;
            }

            set
            {
                int gob;
                Random R = new Random();
                gob = R.Next(0, 3);
                if (gob == 0)
                {
                    _type = types.normal_goblin;
                }
                else if (gob == 1)
                {
                    _type = types.huge_goblin;
                }
                else if (gob == 2)
                {
                    _type = types.deadly_goblin;
                }
            }
        }

        public weapons GetWeapon()
        {
            return _weapon;
        }

        public void SetWeapon()
        {
            int weapon;
            Random R = new Random();
            weapon = R.Next(0, 5);
            if (weapon == 0)
            {
                _weapon = weapons.sword;
            }
            else if (weapon == 1)
            {
                _weapon = weapons.axe;
            }
            else if (weapon == 2)
            {
                _weapon = weapons.dagger;
            }
            else if (weapon == 3)
            {
                _weapon = weapons.fist;
            }
            else if (weapon == 4)
            {
                _weapon = weapons.Katana;
            }
        }

        public bool SetStartHealth(byte health)
        {
            if (_health == 0)
            {
                _health = health;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public enum weapons
    {
        sword = 10,
        dagger = 7,
        axe = 15,
        fist = 3,
        Katana = 40,
        poison_dagger=50
    }

    public enum types
    {
        normal_goblin,
        huge_goblin,
        deadly_goblin
    }

    public class Prinses
    {
        private string _name;
        private bool _inLoveWithHero;
        private int _leeftijd;
        private HairColors _haarKleur;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Leeftijd
        {
            get
            {
                return _leeftijd;
            }

            set
            {
                _leeftijd = value;
            }
        }

        public HairColors HairColor
        {
            get
            {
                return _haarKleur;
            }

            set
            {
                int haar;
                Random R = new Random();
                haar = R.Next(0, 4);
                if (haar == 0)
                {
                    _haarKleur = HairColors.Black;
                }
                else if (haar == 1)
                {
                    _haarKleur = HairColors.Blond;
                }
                else if (haar == 2)
                {
                    _haarKleur = HairColors.Brunette;
                }
                else if (haar == 3)
                {
                    _haarKleur = HairColors.Redhead;
                }
                {

                }

            }
        }        
    }

    public enum HairColors
    {
        Blond,
        Black,
        Brunette,
        Redhead
    }

    public class Beer
    {
        private string _name;
        private int _grootte;
        private int _health;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int grootte
        {
            get
            {
                return _grootte;
            }

            set
            {
                _grootte = value;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
            }
        }
    }
}