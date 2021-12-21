using System.Collections.Generic;

namespace lexic8
{
    public class lexico
    {
        private HashSet<string> Words { get; set; }

        public lexico()
        {
            Words = new HashSet<string> { };
        }
        public void getFrom(string text)
        {
            if (text.Length > 0)
            {
                // Cleansing + Separation
                string[] temp = text.ToLower().Replace(";", "").Replace(".", "").Replace(",", "").Replace(":", "").Replace("`", "").Replace("'", "").Replace("(", "").Replace(")", "").Replace("?", "").Replace("¿", "").Replace("-", "").Replace("¡", "").Replace("!", "").Replace("\n"," ").Split(' ');

                foreach (string word in temp)
                {
                    // Adding
                    Words.Add(word);
                }
            }
            else
            {
                throw new System.Exception("The String is Empty");
            }
            
        }

        // Count
        public int count()
        {
            return Words.Count;
        }
    }
}
