using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCmdLine
{
    internal class FizzBuzzResultTracker
    {
        private IDictionary<string, int> _counter = new Dictionary<string, int>();

        public FizzBuzzResultTracker()
        {
            _counter.Add(new KeyValuePair<string, int>("fizz", 0));
            _counter.Add(new KeyValuePair<string, int>("buzz", 0));
            _counter.Add(new KeyValuePair<string, int>("fizzbuzz", 0));
            _counter.Add(new KeyValuePair<string, int>("lucky", 0));
            _counter.Add(new KeyValuePair<string, int>("integer", 0));
        }

        public void TrackResult(string result)
        {
            if (_counter.ContainsKey(result))
            {
                _counter[result]++;
            }
            else
            {
                _counter["integer"]++;
            }
        }

        public string PublishResult()
        {
            return string.Join(" ", _counter
                .Where(x => x.Value != 0)
                .Select(x => $"{x.Key}: {x.Value}"));
        }
    }
}
