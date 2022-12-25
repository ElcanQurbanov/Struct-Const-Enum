using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CalculateService : ICalculateService
    {
        public int Calculate(int[] arr)
        {
            int result = 1;

            foreach (var item in arr)
            {
                if (arr[item] < 20 && arr[item]>1)
                {
                    result = arr[item] * result; 
                }
            }
            return result;
        }

        public int GetCalculate(int[] arr)
        {

            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 2==0)
                {
                    sum = sum+item;
                    sum= sum*sum;
                }
            }
            return sum;

        }
    }
}
