namespace JuriKnauth.FizzBuzz
{
    public readonly struct BuzzWord
    {
        public readonly int Number;
        public readonly string Word;

        public BuzzWord(int number, string word)
        {
            Number = number;
            Word = word;
        }
    }
}