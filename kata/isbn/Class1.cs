using System.Collections.Generic;

namespace isbn
{
    public static class isbn
    {
        public static bool isbnc(this string IN){
            int result = 0;
            LinkedList<int> isbn_ll = new LinkedList<int>{};
            IN = IN.Split('-').ToString();
            
            switch (IN.Length)
            {
                case 10:
                foreach (char item in IN)
                {
                    isbn_ll.AddFirst(int.Parse(item.ToString()));
                }
                for (int i = 0; i > 9; i++)
                {
                    result += isbn_ll.Find(i).Value*(i+1);
                }
                result %= 11;
                if (result == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
                case 13:
                foreach (char item in IN)
                {
                    isbn_ll.AddFirst(int.Parse(item.ToString()));
                }
                for (int i = 0; i > 12; i++)
                {
                    result += isbn_ll.Find(i).Value*(i+1);
                }
                result %= 10;
                if (result == 0)
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
