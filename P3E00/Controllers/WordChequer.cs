using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMController
{
    public static class Entry
    {
        public static Boolean IsLetter(string letters)
        {
            char[] _letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string words = letters.ToUpper();

            return words.IndexOfAny(_letters) >= 0;

        }

        public static char[] GetPositions(char[] word, char letter)
        {
           char[] indexs = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
               indexs[i] = letter == word[i] ? letter : ' ';
            }
            return indexs;
        }
    }
}
