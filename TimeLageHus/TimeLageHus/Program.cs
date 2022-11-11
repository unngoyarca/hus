namespace TimeLageHus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Huset huset = new Huset();
            LivingRom living = new LivingRom(20, 40);
            //Furniture furniturer = new List<Furniture>();

            huset.doorOpen();


        }
    }
}