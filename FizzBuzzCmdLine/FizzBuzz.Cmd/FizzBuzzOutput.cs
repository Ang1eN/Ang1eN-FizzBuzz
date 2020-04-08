using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FizzBuzzCmdLine
{
    public class FizzBuzzOutput
    {
        private FizzBuzzEvaluator _evaluator;
        private FizzBuzzResultTracker _tracker;

        public FizzBuzzOutput()
        {
            _evaluator = new FizzBuzzEvaluator();
            _tracker = new FizzBuzzResultTracker();
        }

        public string ProcessFizzBuzz(int start, int end)
        {
            //var results = Enumerable.Range(start, end).Select(_evaluator.Evaluate);
            
            var sb = new StringBuilder();

            for (var currentIndex = start; currentIndex <= end; currentIndex++)
            {
                var result = _evaluator.Evaluate(currentIndex);
                sb.Append($"{result} ");
                _tracker.TrackResult(result);
            }

            sb.Append(_tracker.PublishResult());

            return sb.ToString();
        }
    }
}
