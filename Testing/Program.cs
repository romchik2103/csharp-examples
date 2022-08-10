using System;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            var mob = new Minecraft.Mob("Mob 1", 99, 15);
            var mob2 = new Minecraft.Mob("Mob 2", 98);
            
            Console.WriteLine(mob);
            Console.WriteLine(mob.Damage(10));
            Console.WriteLine(mob);
            Console.WriteLine(mob.Damage(7));
            Console.WriteLine(mob);
            
            Console.WriteLine();
            
            Console.WriteLine(mob2);
            mob2.Destroy();
            Console.WriteLine(mob2);
        }
    }
}