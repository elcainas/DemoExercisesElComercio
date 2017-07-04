using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exercises
{
    public class ChangeString
    {
        private static readonly List<char> Alphabet = new List<char>{
        'a','b','c','d','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s','t','u','v','w','x','y','z'
        };
        public static string Build(string input)
        {
            var output = string.Empty;
            foreach (var letter in input)
            {
                var currentLetter = char.ToLower(letter);
                var nextLetterIndex = Alphabet.IndexOf(currentLetter) + 1;
                if (!Alphabet.Contains(currentLetter))
                {
                    output += letter;
                    continue;
                }
                if (nextLetterIndex >= Alphabet.Count)
                    continue;
                var nextLetter = Alphabet[nextLetterIndex];
                output += letter.Equals(currentLetter) ? nextLetter : char.ToUpper(nextLetter);
            }
            return output;
        }
    }
}
