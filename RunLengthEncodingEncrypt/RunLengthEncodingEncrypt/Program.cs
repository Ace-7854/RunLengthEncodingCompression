using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncodingEncrypt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = TempSplit(Console.ReadLine());
            string[,] rle = new string[items.Length+1, 2];

            int indOfRle = 0;

            for (int i = 0; i < items.Length; i++)
            {
                if (rle[indOfRle,0] == items[i])
                {
                    int tmp = int.Parse(rle[indOfRle, 1]);
                    tmp++;
                    rle[indOfRle, 1] = tmp.ToString();
                }
                else if (rle[indOfRle,0] != items[i])
                {
                    if (rle.Length > 2)
                    indOfRle++;//logic problem Cant go up if there is a lack of indexes. 
                    
                    rle[indOfRle,0] = items[i];
                    rle[indOfRle, 1] = "1";
                }
            }
            
            for (int i = 0;i < rle.Length;i++)
            {
                try
                {
                    if (rle[i,0] != null && rle[i,1] != null)
                    Console.WriteLine($"{rle[i, 0]} {rle[i, 1]}");
                }
                catch (Exception) { }
                
            }
            Console.ReadKey();
        }

        static string[] TempSplit(string inp)
        {
            string[] items = new string[inp.Length];
         
            for (int i = 0; i < inp.Length; i++)
                items[i] = inp[i].ToString();

            return items;
        }
    }
}
