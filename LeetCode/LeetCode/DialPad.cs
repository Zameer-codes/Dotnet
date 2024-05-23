using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class DialPad
    {
        public IList<string> LetterCombinations(string digits)
        {
            string[] map = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            IList<string> result = new List<string>();
            result = dfs(result, map, digits);
            return result;
        }
        private IList<string> dfs(IList<string> result, string[] map, string digits)
        {
            if (digits.Length == 0) return result;
            IList<string> aux = new List<string>();
            var test = map[digits[0] - '0'];
            var test1 = digits[0] - '0';
            foreach (char c in map[digits[0] - '0'])
            {
                if (result.Count == 0)
                {
                    aux.Add(c.ToString());
                }
                else
                {
                    foreach (string r in result)
                        aux.Add(r + c);
                }
            }

            result = dfs(aux, map, digits.Remove(0, 1));

            return result;
        }
    }
}
