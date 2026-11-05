namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            Console.WriteLine(boiler1 == boiler2);


            boiler1.fill();
            boiler2.boil();

            Console.WriteLine("Boiler is empty: " + boiler2.IsEmpty);
            Console.WriteLine("Boiler is boiled: " + boiler2.IsBoiled);

            boiler2.drain();

            Console.WriteLine("Boiler is empty: " + boiler1.IsEmpty);
        }
    }
}