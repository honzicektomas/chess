namespace chess
{
    internal class Program
    {
        static Board b;
        
        static void Main(string[] args)
        {
            b = new Board();
            Console.CursorVisible = false;

            while (true)
            {
                Console.Clear();
                b.Draw();
                
                ConsoleKeyInfo info = Console.ReadKey(true);
                if (info.Key == ConsoleKey.Escape)
                    break;

                b.HandleKey(info.Key);
            }
        }
    }
    
}
