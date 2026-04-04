namespace ConsoleChessProject
{
    internal class Program
    {
        public static Tuple<double, double> MapPosition(string position)
        {
            double x, y;
            char[] chars = position.ToCharArray();
            y = 8 - char.GetNumericValue(chars[1]);
            switch (char.ToLower(chars[0]))
            {
                case 'a': x = 0; return new Tuple<double, double>(x, y);
                case 'b': x = 1; return new Tuple<double, double>(x, y);
                case 'c': x = 2; return new Tuple<double, double>(x, y);
                case 'd': x = 3; return new Tuple<double, double>(x, y);
                case 'e': x = 4; return new Tuple<double, double>(x, y);
                case 'f': x = 5; return new Tuple<double, double>(x, y);
                case 'g': x = 6; return new Tuple<double, double>(x, y);
                case 'h': x = 7; return new Tuple<double, double>(x, y);

            }
            return new Tuple<double, double>(-1.0, -1.0);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine(MapPosition("h1"));
            var game = new Game();
            game.Start();
        }

    }
}
