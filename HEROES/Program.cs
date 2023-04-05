using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES
{
    public class Item
    {
        public string Sword { get; set; }
        public string Axe { get; set; }
        public string Knife { get; set; }
        public string Staff { get; set; }
        public Item(string sword, string axe, string knife, string staff)
        {
            Sword = sword;
            Axe = axe;
            Knife = knife;
            Staff = staff;
        }
    }
    public class Hero : Item
    {
        public int Health { get; protected set; }
        public int Damage { get; protected set; }

        public virtual void Hit(Hero hero)
        {
            hero.Health -= Damage;
        }
        public Hero(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }
        
    }

    public class Bard : Hero
    {
        public Bard() : base(10, 20)
        {
        }

        public bool GetSword(Item i)
        {
            //Item
            return false;
        }
    }

    public class Barbarian : Hero
    {
        public Barbarian() : base(50, 30)
        {
        }

        public void Jump()
        { }
    }

    public class Paladin : Hero
    {
        public Paladin() : base(100, 10)
        {
        }
    }

    public class Mage : Hero
    {
        public Mage() : base(10, 15)
        {
        }

        //public override void Hit(Hero hero)
        //{
        //    Health += 10;
        //    base.Hit(hero);
        //}

        public new void Hit(Hero hero)
        {
            Health += 10;
            base.Hit(hero);
        }
    }



    public class Team
    {
        public Hero[] Heroes;

        public Team(Hero hero1, Hero hero2)
        {
            this.Heroes = new Hero[]
            {
                hero1, hero2
            };
        }
    }

    public class Battlefield
    {
        public Team team1;
        public Team team2;

        public Battlefield(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        public void StartFight()
        {
            team1.Heroes.First().Hit(team2.Heroes.First());
        }
    }



    internal class Program
    {
        public static void Main(string[] args)
        {
            Hero h = new Hero(1, 50);
            Hero barbarian = new Barbarian();
            Hero bard = new Bard();

        }
    }
}
