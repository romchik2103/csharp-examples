namespace Minecraft
{
    public class Entity
    {
        public int Id;
        public string Name;

        public Entity(string name, int id)
        {
            Id = id;
            Name = name;
        }

        public virtual void Destroy()
        {
            Id = -1;
        }

        public override string ToString()
        {
            return $"Entity(name=\"{Name}\", id={Id})";
        }
    }

    public class Mob : Entity
    {
        private const int InitialHealth = 20;
        public int Health;

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