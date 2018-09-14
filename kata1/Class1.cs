using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata1
{
    public class Class1
    {
        public static int Persistence(long n)
        {
            String num = Convert.ToString(n);
            var array = num.ToCharArray();
            long tmp = 1;
            int l = 0;
            while (array.Length > 1)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    tmp = tmp * (int)Char.GetNumericValue(array[i]);
                }
                array = Convert.ToString(tmp).ToCharArray();
                tmp = 1;
                l++;
            }
            return l;
        }
    }
}
