namespace Interface_realization
{


    interface IWeapon
    {
  
        void Fire();
    }

    interface IThrowingWeapon : IWeapon 
    {
        void Throw();
    }

    interface IInterface : IWeapon
    { 
    
    }

    interface IInterfaceMy : IWeapon, IInterface
    {

    }


    abstract class Weapon :  IWeapon
    {

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}");
        }

    }

    class LaserGun : Weapon
    {


        public override void Fire()
        {
            Console.WriteLine("Laser fire");
        }
    }

    class Bow : Weapon
    {


        public override void Fire()
        {
            Console.WriteLine("Bow fire");
        }
    }



    class Gun : IWeapon
    {

        public  void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Fire!");
        }
    }

    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void Throw(IThrowingWeapon throwingWeapon)
        {
            throwingWeapon.Throw();
        }
    }

    class Knife : IThrowingWeapon
    {

        public  void Fire()
        {
            Console.WriteLine($"{GetType().Name}: Fire");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name}: Throw");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IWeapon[] inventory = { new Gun(), new LaserGun(), new Knife()};

            foreach (var item in inventory)
            {
                
                player.Fire(item);
                Console.WriteLine();
            }

            player.Throw(new Knife());

        }
    }
}