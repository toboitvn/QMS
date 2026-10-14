using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.APIHelpers
{
    public class RandomHelpers
    {
        public static string RandomNumber(int numberRD)
        {
            //return "111111";
            string randomStr = "";
            try
            {

                int[] myIntArray = new int[numberRD];
                int x;
                //that is to create the random # and add it to uour string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception)
            {
                randomStr = "error";
            }
            return randomStr;
        }

        public static string RandomChar(int numberRD)
        {
            string randomStr = "";
            try
            {

                string[] myIntArray = new string[numberRD];
                int x;
                //that is to create the random # and add it to uour string
                Random autoRand = new Random();
                for (x = 0; x < numberRD; x++)
                {
                    myIntArray[x] = System.Convert.ToChar(System.Convert.ToInt32(autoRand.Next(65, 87))).ToString();
                    randomStr += (myIntArray[x].ToString());
                }
            }
            catch (Exception)
            {
                randomStr = "error";
            }
            return randomStr;
        }
    }
}
