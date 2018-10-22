using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMController
{
    public class AhorcadoController : IAhorcadoController
    {
        private List<char> Word = new List<char>();

        private List<char> WordResult = new List<char>();

        private int _totalAttempts = 8;

        private int _counter = 8;

        private int _wins = 0;

        public void AddWord(string word)
        {
            foreach (var letter in word)
            {
                this.Word.Add(letter);
                this.WordResult.Add(' ');
            }
        }

        public TestResult TestLetter(char letter)
        {
            if (Word.Count == 0)
                throw new Exception("No hay palabra para el test.");

            var testResult = new TestResult();

            if (IsLetterUsedBefore(letter))
            {
                testResult.Message = "Ya utilizó esa letra!.";
                --_counter;
                return testResult;
            }

            int _oldwins = _wins;

            for (int i = 0; i < Word.Count; i++)
            {
                if (letter == Word[i])
                {
                    testResult.Success = true;
                    WordResult[i] = letter;
                    _wins++;
                }
            }

            _counter = _oldwins == _wins ? --_counter : _counter;

            testResult.Letters = WordResult;

            return testResult;
        }

        private bool IsLetterUsedBefore(char letter)
        {
            return WordResult.Contains(letter);
        }

        public bool PayerHasWon()
        {
            return _wins > 0 && _wins == Word.Count;

        }

        public int GetAvailableAttempts()
        {
            return _counter;
        }


        public int TotalAttempts()
        {
            return _totalAttempts;
        }

        public void ResetController()
        {
            _counter = _totalAttempts;
            _wins = 0;
            Word.Clear();
            WordResult.Clear();
        }
    }
}
