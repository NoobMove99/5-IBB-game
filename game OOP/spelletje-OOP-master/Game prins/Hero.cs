using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_prins
{
    public class Hero
    {
        private weapons _weapon;
        private int _health;
        private bool _inLoveWithPrincess;
        private string _name;
        private int _attackdamage;
        private bool _miss;

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

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                
            }

        }

        public int AttackDamage
        {
            get
            {
                return _attackdamage;
            }

            set
            {
                _attackdamage = AttackDamage;
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
                _weapon = weapons.fists;
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

        public bool SetStartHealth(int health)
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
            else
            {
                
            }
        }

        public void Attack(Goblin g, int attackdamage)
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
                    attackdamage = 10;
                }
                else if (_weapon == weapons.axe)
                {
                    g.Health -= 15;
                    attackdamage = 15;
                }
                else if (_weapon == weapons.dagger)
                {
                    g.Health -= 7;
                    attackdamage = 7;
                }
                else if (_weapon == weapons.fists)
                {
                    g.Health -= 3;
                    attackdamage = 3;
                }
                else if (_weapon == weapons.Katana)
                {
                    g.Health -= 40;
                    attackdamage = 40;
                }
                else if (_weapon==weapons.poison_dagger)
                {
                    g.Health -= 55;
                    attackdamage = 50;
                }
            }
        }

        public void Defence(int armor)
        {
            if (armor<=10)
            {
                AttackDamage -=armor;
            }
            else if (armor<=20)
            {
                AttackDamage -= armor;
            }
            else if (armor<=30)
            {
                AttackDamage -= armor;
            }
            
        }
    }

    public class Goblin
    {
        private string _name;
        private weapons _weapon;
        private string _huidskleur;
        private int _health;
        private types _type;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = Name;
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

            }

        }

        public types Type
        {
            get
            {
                throw new System.NotImplementedException();
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
                _weapon = weapons.fists;
            }
            else if (weapon == 4)
            {
                _weapon = weapons.Katana;
            }
        }

        public bool SetStartHealth(int health)
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
        fists = 3,
        Katana = 40,
        poison_dagger=50
    }

    public enum types
    {
        normal_goblin,
        huge_goblin,
        deadly_goblin
    }
}