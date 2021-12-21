using System;
using System.Collections.Generic;

namespace inputReturner
{
    public class boolExp
    {
        private string exp { get; set; }

        // Constructors
        public boolExp() { }
        public boolExp(string exprerssion)
        {
            exp = exprerssion;
        }

        // Methods - Functions
        public void set(string expression)
        {
            exp = expression;
        }

        // Get input variables
        public string RetIn()
        {
            string ret = "";
            List<char> list = new List<char> { };
            foreach (char letter in exp) if (char.IsLetter(letter) && !list.Contains(letter)) list.Add(letter);
            for (int i = 0; i < list.Count; i++) ret += LineTable(list[i], list.Count, i + 1);
            return ret;
        }

        // Calculate per variable
        private string LineTable(char car, int terms, int index)
        {
            int id_modded = index * 2;
            if (index > 3) id_modded = (int)System.Math.Pow(index, 2);
            string ret = car + " | ";
            int total = (int)Math.Pow(2, terms);
            int eval = total / id_modded;

            for (int i = 0, b = 1, c = 0; i < total; i++, b++)
            {
                if (c == 0)
                {
                    ret += "0 ";
                    if (b == eval) { c = 1; b = 0; }
                }
                else
                {
                    ret += "1 ";
                    if (b == eval) { c = 0; b = 0; }
                }
            }

            return ret + "\n";
        }
    }
}
