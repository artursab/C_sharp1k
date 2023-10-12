

namespace polimorph_abstract
{
    abstract class Weapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
        
    }

    class LaserGun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Laser fire");
        }
    }

    class Bow : Weapon
    {
        public override int Damage => 3();

        public override void Fire()
        {
            Console.WriteLine("Bow fire");
        }
    }

    class Gun : Weapon
    {
        public override int Damage { get { return 5; } }

        public override void Fire()
        {
            Console.WriteLine("Fire!");
        }
    }

    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Weapon[] inventory = { new Gun(), new LaserGun(), new Bow() };

            foreach (var item in inventory) 
            { 
                player.CheckInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }

        }
    }
}