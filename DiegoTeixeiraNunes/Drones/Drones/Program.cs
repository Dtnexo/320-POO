namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            List<Drone> rec = new List<Drone>();    
            Drone drone = new Drone("Joe", 100, 100);
            building bat = new building(34, 54, 100, 200, "red");
            Rectangle r1 = new Rectangle(10, 10, 100, 150);
            Rectangle r2 = new Rectangle(30, 100, 150, 100);
            Rectangle r3 = new Rectangle(200, 300, 50, 50);
            r1.IntersectsWith(r2); // true
            r1.IntersectsWith(r3); // false
            fleet.Add(drone);
            Random random = new Random();
            try
            {
                for(int i = 0; i < 10 ; i++)
                {
                    int x = random.Next(0,1000);
                    int y = random.Next(0,1000);
                    Drone drone1 = new Drone("Joe", x, y);
                    fleet.Add(drone1);
                }
                if (fleet.Count > 10)
                {
                    throw new ArgumentException("salut");
                }            
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
            // Démarrage
            Application.Run(new AirSpace(fleet));
            
        }
    }
}