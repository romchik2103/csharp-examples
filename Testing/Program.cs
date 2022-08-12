using System;
using System.Collections.Generic;
using Minecraft;

namespace Testing
{
    class Program
    {
        private static Random _rand = new();
        private static List<Entity> _globalEntities = new();

        static void Main()
        {
            Mob mob = new("Mob 1", 99, 15);
            Mob mob2 = new("Mob 2", 98);
            Entity tnt = new("TNT", 5);

            _globalEntities.Add(mob);
            _globalEntities.Add(mob2);
            _globalEntities.Add(tnt);
            SpawnRandomMob();
            SpawnRandomMob();

            foreach (var e in _globalEntities)
            {
                Console.WriteLine($"  {e}");
            }

            Console.WriteLine();
            DespawnAll();
            Console.WriteLine();

            foreach (var e in _globalEntities)
            {
                Console.WriteLine($"  {e}");
            }
        }

        private static void SpawnRandomMob()
        {
            var r = _rand.Next(0, 3);

            if (r == 0)
                _globalEntities.Add(new Mob("Zombie", 10, 15));
            else if (r == 1)
                _globalEntities.Add(new Mob("Skeleton", 11, 10));
            else if (r == 2)
                _globalEntities.Add(new Mob("Spider", 12, 10));
        }

        private static void DespawnAll()
        {
            foreach (var entity in _globalEntities)
            {
                entity.Destroy();
            }
        }
    }
}