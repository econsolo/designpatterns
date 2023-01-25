namespace Interpreter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var roman = "MCMXXVIII";

            var context = new Context(roman);

            var expressions = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new DozenExpression(),
                new UnitExpression()
            };

            foreach (var expression in expressions)
            {
                expression.Interpreter(context);
            }

            Console.WriteLine($"{roman} = {context.Output}");
        }
    }
}