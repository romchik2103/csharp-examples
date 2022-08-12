using System;

namespace Minecraft
{
    public class Entity
    {
        protected int Id;
        protected readonly string Name;

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
        private int _health;

        public Mob(string name, int id, int health) : base(name, id)
        {
            _health = health;
        }

        public Mob(string name, int id) : base(name, id)
        {
            _health = InitialHealth;
        }

        public int Damage(int dmg)
        {
            _health -= dmg;
            if (_health <= 0)
            {
                Destroy();
            }

            return _health;
        }

        public override void Destroy()
        {
            base.Destroy();
            _health = 0;
            Console.WriteLine("Mob.Destroy got called");
        }

        public override string ToString()
        {
            return $"Mob(name=\"{Name}\", id={Id}, health={_health})";
        }
    }
}