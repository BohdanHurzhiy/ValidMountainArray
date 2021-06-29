using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidMountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 4, 2, 1 };
            int[] arr1 = new int[] { 0, 2, 3, 4, 5, 2, 1, 0 };
            int[] arr2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr3 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] arr4 = new int[] { 2, 0, 2 };
            int[] arr5 = new int[] { 0, 1, 2, 3, 4, 8, 9, 10, 11, 12, 11 };

            List<int[]> listArr = new List<int[]>();
            listArr.Add(arr);
            listArr.Add(arr1);
            listArr.Add(arr2);
            listArr.Add(arr3);
            listArr.Add(arr4);
            listArr.Add(arr5);

            foreach (var a in listArr) 
            {
                if (ValidMountainArray(a))
                {
                    Console.WriteLine("Mountain!!");
                }
                else
                {
                    Console.WriteLine("NotMountain");
                }
            }           
        }
        static public bool ValidMountainArray(int[] arr)
        {           
            int marker = 0;
            bool isChanges = false;

            if (arr.Length < 3)
            {
                return false;
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int difference = arr[i] - arr[i + 1];
                if (difference == 0) 
                {
                    return false;
                }
                if (difference < 0)
                {
                    if (isChanges)
                    {
                        return false;
                    }
                    isChanges = false;
                    marker++;
                }
                if(difference > 0)
                {              
                    isChanges = true;
                    marker--;
                }                
            }
            if (marker == (arr.Length - 1) || marker == -(arr.Length - 1))
            {
                return false;
            }
            return true;
        }
    }
}
