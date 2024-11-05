using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSpinningMyWords
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            var words = sentence.Split(' ');
            var returnSentence = "";
            foreach(var word in words)
            {
                if(word.Length > 4)
                {
                    var charArray = word.ToCharArray();
                    Array.Reverse(charArray);
                    returnSentence += new string(charArray) + " ";
                    continue;
                }
                returnSentence += word + " ";
            }

            returnSentence = returnSentence.TrimEnd(' ').ToString();
           
            return returnSentence;
        }
    }
}
