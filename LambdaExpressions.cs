namespace Name
{
    class LambdaExpressions
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"answer: {Mul([2, 3, 4, 5])}");
            Console.WriteLine($"answer: {Div([2, 3, 4, 5])}");
            Console.WriteLine($"answer: {Plus([2, 3, 4, 5])}");
            Console.WriteLine($"answer: {Minus([2, 3, 4, 5])}");
            Console.WriteLine($"answer: {Power([2, 3, 2])}");
            Console.WriteLine($"answer: {Mod([2, 3, 4, 5])}");
        }
        public static double Plus(double[] numbers) => numbers.Aggregate(0.0, (x, y) => x + y);
        public static double Minus(double[] numbers) => numbers.Aggregate(0.0, (x, y) => x - y);
        public static double Mul(double[] numbers) => numbers.Aggregate(1.0, (x, y) => x * y);
        public static double Div(double[] numbers) => numbers.Aggregate(1.0, (x, y) => x / y);
        public static double Power(double[] numbers) => numbers.Skip(1).Aggregate(numbers.First(), (x, y) => Math.Pow(x, y));
        public static double Mod(double[] numbers) => numbers.Skip(1).Aggregate(numbers.First(), (x, y) => x % y);
    }
}
// lambda expressions
