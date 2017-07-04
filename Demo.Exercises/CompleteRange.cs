using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exercises
{
    public class CompleteRange
    {
        public static IEnumerable<int> Build(IEnumerable<int> input)
        {
            var sortedList = input.OrderBy(x => x);
            var lastNumber = sortedList.LastOrDefault();
            for (int i = 1; i <= lastNumber; i++)
                yield return i;
        }
    }
}
