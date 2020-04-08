namespace FizzBuzzCmdLine
{
    internal class FizzBuzzEvaluator
    {
        public string Evaluate(int i)
        {
            return i.ToString().Contains("3") ? "lucky" :
                    i % 3 == 0 && i % 5 == 0 ? "fizzbuzz" :
                    i % 3 == 0 ? "fizz" :
                    i % 5 == 0 ? "buzz" :i.ToString();
        }
    }
}
