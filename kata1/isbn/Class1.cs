using System.Collections.Generic;
using System.Linq;

namespace isbn
{
    public static class Class1
    {
        public static bool isbnc(this string IN){
            if (IN.Contains("-"))
                IN = IN.Replace("-",string.Empty);

            int result = 0;
            LinkedList<int> isbn_ll = new LinkedList<int>{};

            switch (IN.Length)
            {
                case 10:
                    foreach (char item in IN)
                        isbn_ll.AddFirst(int.Parse(item.ToString()));

                    for (int i = 0; i <= 9; i++)
                        result += isbn_ll.ElementAt(i)*(i+1);

                    result %= 11;
                    if (result == 0)
                        return true;
                    else
                        return false;

                case 13:
                    foreach (char item in IN)
                        isbn_ll.AddFirst(int.Parse(item.ToString()));

                    for (int i = 0; i <= 12; i++)
                        result += isbn_ll.ElementAt(i)*(i+1);

                    result %= 10;
                    if (result == 0)
                        return true;
                    else
                        return false;

                default:
                    return false;
            }
        }
    }
}
