using System;
using System.Collections.Generic;
using System.Text;

namespace HMController
{
    public class AhorcadoController : IAhorcadoController
    {

        #region Properties

        private StringBuilder Word = new StringBuilder();

        private List<char> WordResult = new List<char>();

        private int _totalAttempts = 8;

        private int _counter = 8;

        private int _wins = 0;

        #endregion

        public void AddWord(string word)
        {
            foreach (var letter in word)
            {
                this.Word.Append(letter);
                this.WordResult.Add(' ');
            }
        }

        public TestResult TestLetter(char letter)
        {
            if (Word.Length == 0)
                throw new Exception("No hay palabra para el test.");

            var testResult = new TestResult();

            if (IsLetterUsedBefore(letter))
            {
                testResult.Message = "Ya utilizó esa letra!.";
                --_counter;
                return testResult;
            }

            int _oldwins = _wins;

            for (int i = 0; i < Word.Length; i++)
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
            return _wins > 0 && _wins == Word.Length;

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
