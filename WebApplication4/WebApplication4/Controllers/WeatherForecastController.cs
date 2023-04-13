using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace Homework
{
    [ApiController]
    [Route("[controller]")]
    public class SorterController : ControllerBase
    {
        [HttpPost("Sortt")]
        public int[] Sort(int[] arr)
        {
            Sorter sorter = new Sorter();
            return sorter.Sort(arr);
        }
    }
    public class Sorter
    {
        public int[] Sort(int[] notSortedArray)
        {
            int[] sortedArray = notSortedArray;
            int temp;
            string notSortedString;

            for (int j = 0; j <= sortedArray.Length - 2; j++)
            {
                for (int i = 0; i <= sortedArray.Length - 2; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        temp = sortedArray[i + 1];
                        sortedArray[i + 1] = sortedArray[i];
                        sortedArray[i] = temp;
                    }
                }
            }

            return sortedArray;
        }
        public double[] Sort(double[] notSortedArray)
        {
            double[] sortedArray = notSortedArray;
            double temp;

            for (int j = 0; j <= sortedArray.Length - 2; j++)
            {
                for (int i = 0; i <= sortedArray.Length - 2; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        temp = sortedArray[i + 1];
                        sortedArray[i + 1] = sortedArray[i];
                        sortedArray[i] = temp;
                    }
                }
            }
            return sortedArray;
        }
        public char[] Sort(char[] notSortedArray)
        {
            char[] sortedArray = notSortedArray;
            char temp;
            for (int j = 0; j <= sortedArray.Length - 2; j++)
            {
                for (int i = 0; i <= sortedArray.Length - 2; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        temp = sortedArray[i + 1];
                        sortedArray[i + 1] = sortedArray[i];
                        sortedArray[i] = temp;
                    }
                }
            }
            return sortedArray;
        }
        public string Sort(string notSortedArray)
        {
            var chars = notSortedArray.ToCharArray();
            return string.Join("", Sort(chars));
        }
    }

}