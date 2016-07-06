using Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaterProduct
{
    public class Calculater
    {
        private ArrayList Result = new ArrayList();

        public int[] CalculateSum(int NumInGroup, List<Order> Products, string DataType)
        {
            int Count = 0;
            int Sum = 0;
            foreach (var item in Products)
            {
                Count++;
                Sum = Sum + (int)item.GetType().GetProperty(DataType).GetValue(item);

                if (Count == NumInGroup)
                {
                    Result.Add(Sum);
                    Count = 0;
                    Sum = 0;
                }
            }
            Result.Add(Sum);

            return (int[])Result.ToArray(typeof(int));
        }
    }
}