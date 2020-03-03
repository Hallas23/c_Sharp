using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    class SortKlasse
    {

        public int[] array { get; set; }

        public SortKlasse(int[] array)
        {
            this.array = array;
        }

        public static void bubbleSort(int[] arr)
        {
            {
                int i, j, temp;
                bool swapped;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    swapped = false;
                    for (j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            // swap arr[j] and arr[j+1] 
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                            swapped = true;
                        }
                    }

                    // IF no two elements were  
                    // swapped by inner loop, then break 
                    if (swapped == false)
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            int[] intArray = { 5, 67, 45, 23, 99, 44, 56, 12, 3, 44 };
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            bubbleSort(intArray);
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}

