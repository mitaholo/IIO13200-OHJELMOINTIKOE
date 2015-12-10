using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeTentti
{
   public static class LetterCounter
    {
        public static List<string> Count(string text)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzåäö";
            List<string> results = new List<string>();
            int uniqueLetters = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                string letter = "" + letters[i];
                int letterCount = (text.Length - text.Replace(letter, "").Length) + (text.Length - text.Replace(letter.ToUpper(), "").Length);
                if (letterCount > 0) uniqueLetters++;
                results.Add(letters[i] + " = " + letterCount);
            }

            results.Add("\nYhteensä " + text.Length + " merkkiä ja " + uniqueLetters + " eri kirjainta.");
            return results;
        }
    }
}
