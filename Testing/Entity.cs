using System;

namespace Minecraft
{
    public class Entity
    {
        protected int Id;

        public string Name
        {
            get
            {
                return _name;
            }
            protected set => _name = value.ToLower();
        }

        private string _name;
        
        public Entity(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public virtual void Destroy()
        {
            Id = -1;
            Console.WriteLine("Entity.Destroy got called");
        }

        public override string ToString()
        {
            return $"Entity(name=\"{Name}\", id={Id})";
        }
    }

    public class Mob : Entity
    {
        private const int InitialHealth = 20;

        public int Health
        {
            get => _health;
            protected set => _health = Math.Max(0, value);
        }

        private int _health;

        public Mob(string name, int id, int health) : base(name, id)
        {
            Health = health;
        }

        public Mob(string name, int id) : base(name, id)
        {
            Health = InitialHealth;
        }

        public int Damage(int dmg)
        {
            Health = Health - dmg;
            if (Health <= 0)
            {
                Destroy();
            }

            return Health;
        }

        public override void Destroy()
        {
            base.Destroy();
            Health = 0;
        }

        public override string ToString()
        {
            return $"Mob(name=\"{Name}\", id={Id}, health={Health})";
        }
    }
}