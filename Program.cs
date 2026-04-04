namespace ConsoleChessProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine(MapPosition("h1"));
            var game = new Game();
            game.Start();
        }

    }
}
