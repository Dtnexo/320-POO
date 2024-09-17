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
            List<building> batiment = new List<building>();
            Drone drone = new Drone("Joe", 100, 100);
            building bat = new building(34, 54, 100, 200, "red");
            fleet.Add(drone);
            batiment.Add(bat);

            // Démarrage
            Application.Run(new AirSpace(fleet, batiment));
        }
    }
}