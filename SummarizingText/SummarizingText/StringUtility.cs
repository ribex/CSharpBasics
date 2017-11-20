using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingText
{
    public class StringUtility
    {
        public static string SummarizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
            {
                return text;
            }
            // sentence.Substring(0, maxLength); // this might chop a word
            // break sentence into words
            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
                summaryWords.Add(word); // instructor had this before the totalCharacters length but this could allow a really long word to go far beyond the maxLength limit
            }

            return String.Join(" ", summaryWords) + "...";

        }

    }
}
