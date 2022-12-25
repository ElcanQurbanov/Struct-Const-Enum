using DomainLayer.Models;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CustomerAge : ICustomerAge
    {
        public double GetAge(Customer[] arr)
        {
            int count = 0;

            foreach (var item in arr)
            {
                if (item.Age>25 && item.Age<30)
                {
                    count++;
                }
            }

            return count;

        }

        public int GetAgeCustomer(Customer[] arr)
        {
            int count = 0;
            int sum = 0;
            int result = 0;

            foreach (var item in arr)
            {
                sum+= item.Age;
            }
            result= sum/arr.Length;
            return result;
        }
    }
}
