using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class Audio_books
    {
        public static int[] find(int[] cha, int[] book)
        {
            int k = 0;
            HashSet<int> result = new HashSet<int>();
            int i = 0;
            while(i<cha.Length)
            {
                
                    if (book[k] <= cha[i])
                    {
                    if (!result.Contains(i))
                    {
                        result.Add(i);
                        i = 0;
                    }
                            
                        k++;
                    i++;
                }
                
            }
            return result.ToArray();
        }

        //public static void Main()
        //{
        //    int[] chapters = { 0, 100, 200, 300, 400 };
        //    int[] bookmarks = { 80, 110, 190, 390 };
        //    Console.WriteLine(find(chapters, bookmarks));
        //}

    }
}
