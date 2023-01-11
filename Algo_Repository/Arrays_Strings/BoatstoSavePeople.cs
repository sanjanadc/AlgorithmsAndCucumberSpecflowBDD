using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    internal class BoatstoSavePeople
    {
        public static int NumRescueBoats(int[] people, int limit)
        {
            Array.Sort(people);
            int i = 0, j = people.Length - 1;
            int ans = 0;

            while (i <= j)
            {
                ans++;
                if (people[i] + people[j] <= limit)
                {
                    i++;
                    j--;
                }
                else
                {
                    j--;
                }
            }

            return ans;
        }
        //public static void Main()
        //{
        //    int[] people = { 1, 2 ,3};
        //    int limit = 3;
        //    NumRescueBoats(people, limit);
        //}

    }
    
}
