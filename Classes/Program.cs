namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car dreamCar = new Car()
                { Make = "Nissan Skyline",
                    Model = "GT‑R R34",
                    Year = 2002
                    
                };
            
            dreamCar.Drive();
        }
    }
}
