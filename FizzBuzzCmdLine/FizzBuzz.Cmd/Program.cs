using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzCmdLine
{
    public class Program
    {
        private static FizzBuzzOutput _output;


        static void Main(string[] args)
        {
            _output = new FizzBuzzOutput();

            Console.WriteLine(_output.ProcessFizzBuzz(1, 20));
        }


        public static void BuildString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string trimmedString;

            //iterate through tand pass the current int to the evaluate method building the string
            //for (int i = 1; i < 21; i++)
            //{
            //    stringBuilder.Append(Evaluate(i) + " ");
            //}
            ////trim the white space
            //trimmedString = stringBuilder.ToString().TrimEnd() + ": ";

            ////append the counter values to the string
            //foreach (KeyValuePair<string, int> keyValuePair in Counter)
            //{
            //    trimmedString = trimmedString + (keyValuePair.Key + ":" + keyValuePair.Value.ToString() + " ");
            //}
            //Console.WriteLine(trimmedString);
        }


        //public static void EvaluateAndRecord(int i)
        //{
        //    var result = Evaluate(1);

        //    if (Counter.ContainsKey(result))
        //    {
        //        Counter[result]++;
        //    }
        //    else
        //    {
        //        Counter["integer"]++;
        //    }
        //}

        

        //public static string Evaluate(int i)
        //{
        //    if (i.ToString().Contains("3"))
        //    {
        //        counter["lucky"]++;
        //        return ("lucky");
        //    }
        //    else if ((i % 3 == 0) && (i % 5 == 0))
        //    {
        //        counter["fizzbuzz"]++;
        //        return ("fizzbuzz");
        //    }
        //    else if (i % 3 == 0)
        //    {
        //        counter["fizz"]++;
        //        return ("fizz");
        //    }
        //    else if (i % 5 == 0)
        //    {
        //        counter["buzz"]++;
        //        return ("buzz");
        //    }
        //    else
        //        counter["integer"]++;
        //    return (i.ToString());
        //}
    }
}

