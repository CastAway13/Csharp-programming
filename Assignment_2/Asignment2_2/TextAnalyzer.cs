using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment2_2
{
    class TextAnalyzer
    {
        const string src = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private string text;

        public TextAnalyzer ()
        {
        }

        public string GetText()
        {
            return text;
        }
        public void InitializeText(out string text)
        {
            int length = 50;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            text = sb.ToString();
            this.text = text;
        }

        public SortedList<char,int> AddToCollection()
        {
            SortedList<char, int> text = new SortedList<char, int>();
            foreach (char c in this.text) { 
                if (!text.ContainsKey(c))
                    text.Add(c, 1);
                else
                    text[c] = text[c] + 1;
            }
            return text;
        }
    }
}
