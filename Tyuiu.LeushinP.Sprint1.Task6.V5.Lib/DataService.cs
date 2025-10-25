using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LeushinP.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";

            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\t', '\n', '\r' };
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> symmetricalWords = new List<string>();

            foreach (string word in words)
            {
                if (IsSymmetrical(word))
                {
                    symmetricalWords.Add(word);
                }
            }


            return string.Join(", ", symmetricalWords);
        }

        private bool IsSymmetrical(string word)
        {
            if (word.Length < 2)
                return false;


            string lowerWord = word.ToLower();

            for (int i = 0; i < lowerWord.Length / 2; i++)
            {
                if (lowerWord[i] != lowerWord[lowerWord.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}