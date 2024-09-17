namespace paraClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            plane plane = new plane();
            plane.Move();
            Console.WriteLine("Hello, World!");
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            
        }

    }
}

