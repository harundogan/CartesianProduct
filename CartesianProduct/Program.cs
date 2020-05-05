using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {26,-99,-94,17,22,80,62,60,60,-38,18,-42,-95,-37,20,-73,-10,18,72,63,95,52,-85,10,-62,-21,-91,51,-41,
                          -83,-68,12,90,42,-78,48,-95,52,-18,-65,26,-25,83,-84,-65,47,-27,82,39,14,-74,74,13,48,-83,-57,-9,59,
                          -64,71,-91,-80,8,23,-63,79,16,-45,55,-37,-92,6,-46,70,23,24,-2,84,-1,-65,1,-35,44,48,6,6,-56,6,-52,27,
                          -49,-86,88,-8,35,49,54,-28,99 };

            int[] arr2 = {-26,23,32,11,76,-63,-35,89,71,81,-94,91,99,-6,18,-42,54,-4,67,-91,-71,10,63,16,-81,55,-46,53,11,-19,-60,
                          -84,-13,7,-60,-85,23,-55,38,98,32,33,42,-28,-96,-1,-85,-22,38,-92,-54,85,62,49,-44,-32,86,86,15,-89,89,50,
                          -89,-20,-24,-81,-9,-57,-69,-99,13,39,-52,-48,-12,-57,31,-30,72,80,76,55,-16,77,6,-43,13,-87,-39,-76,-61,68,
                          14,-62,-60,83,76,82,25 };

            FindPoints(arr1, arr2);

            Console.ReadLine();
        }

        static void FindPoints(int[] arr1, int[] arr2)
        {
            int counter = 0; //Toplam kaç tane doğru olduğunu bulmak için sayaç oluşturduk.
            List<int> points = new List<int>(); //Aynı doğruda kesişen noktaları içine atmak için liste oluşturduk.
            for (int i = 0; i < arr2.Length; i++) 
                /*Burada arr2 isimli dizinin birinci elemanından başlayarak tek tek eşleşen var mı diye diziyi kontrol
                etmek için döngü kurduk.*/
                for (int j = i + 1; j < arr2.Length; j++) 
                    /*İkinci for i elemanının eşleştiği bir sayı var mı diye tek tek dizi elemanlarını kontrol ediyor. */
                    if (arr2[i] == arr2[j]) 
                        /*i. eleman ile j.eleman eşleşiyorsa listede bu eleman var mı diye kontrol ediyoruz.
                         * Listede yoksa ekleyeceğiz. */
                        if (points.Contains(arr2[i]) == false)
                        {
                            points.Add(arr2[j]);
                            counter++;
                        }

            foreach (var item in points)
                Console.WriteLine(item);

            Console.WriteLine("X eksenine paralel olan {0} tane doğru vardır.", counter);
        }
    }
}
