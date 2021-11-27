using System.Collections.Generic;
using System.Linq;

namespace isbn
{
    public static class Class1
    {
        public static bool isbnc(this string IN){
            IN = IN.Replace("-",string.Empty);
            int res = 0;
            LinkedList<int> isbn_ll = new LinkedList<int>{};
            foreach (char item in IN)
                {
                    isbn_ll.AddFirst(int.Parse(item.ToString()));
                }
            switch (isbn_ll.Count)
            {
                case 10:
                for (int i = 0; i < 9; i++)
                {
                    res+=isbn_ll.ElementAt(i)*(i+1);
                }
                res %= 11;
                if (res == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                case 13:
                for (int i = 0; i < 12; i++)
                {
                    res+=isbn_ll.ElementAt(i)*(i+1);
                }
                res %= 10;
                if (res == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
                default:
                return false;
            }
        }
    }
}
