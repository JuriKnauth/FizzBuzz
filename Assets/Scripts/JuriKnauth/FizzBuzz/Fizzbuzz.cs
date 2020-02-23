using System.Text;

namespace JuriKnauth.FizzBuzz
{
    public class FizzBuzz
    {
        private readonly BuzzWord[] _buzzWords;
        private readonly int _checkNumbersCount;
        private string[] _stringResults;

        private readonly StringBuilder _curStringBuilder;

        private bool hasBuzzWord;

        public FizzBuzz(BuzzWord[] buzzWords, int checkNumbersCount)
        {
            _buzzWords = buzzWords;

            _stringResults = new string[_checkNumbersCount];

            _curStringBuilder = new StringBuilder();

            hasBuzzWord = false;

            CalculateStringResults();
        }

        public void CalculateStringResults()
        {
            for (int stringResultIndex = 0; stringResultIndex < _stringResults.Length; stringResultIndex++)
            {
                _stringResults[stringResultIndex] = ReturnFizzBuzz(stringResultIndex);
            }
        }

        public string ReturnFizzBuzz(int stringResultIndex)
        {
            _curStringBuilder.Clear();

            hasBuzzWord = false;

            for (int buzzWordIndex = 0; buzzWordIndex < _buzzWords.Length; buzzWordIndex++)
            {
                if ((stringResultIndex % _buzzWords[buzzWordIndex].Number) == 0)
                {
                    hasBuzzWord = true;

                    _curStringBuilder.Append(_buzzWords[buzzWordIndex].Word);
                }
            }

            if (!hasBuzzWord)
            {
                _curStringBuilder.Append(stringResultIndex.ToString());
            }

            return _curStringBuilder.ToString();
        }
    }
}