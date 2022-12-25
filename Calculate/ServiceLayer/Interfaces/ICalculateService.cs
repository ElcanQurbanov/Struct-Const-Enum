using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface ICalculateService
    {
        public int Calculate(int[] arr);
        public int GetCalculate(int[] arr);
    }
}
