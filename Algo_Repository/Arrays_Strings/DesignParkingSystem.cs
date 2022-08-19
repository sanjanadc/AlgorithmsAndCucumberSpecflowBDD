using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    public class ParkingSystem
    {
        int bigCnt, medCnt, smCnt;

        public ParkingSystem(int big, int medium, int small)
        {
            bigCnt = big;
            medCnt = medium;
            smCnt = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && bigCnt > 0)
            {
                bigCnt--;
                return true;
            }
            if (carType == 2 && medCnt > 0)
            {
                medCnt--;
                return true;
            }
            if (carType == 3 && smCnt > 0)
            {
                smCnt--;
                return true;
            }

            return false;
        }
    }

}
