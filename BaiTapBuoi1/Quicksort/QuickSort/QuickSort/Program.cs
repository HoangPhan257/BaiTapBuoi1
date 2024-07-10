using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ThuatToanQuicksort
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("đây là thuật toán QuíckSort:");
        int[] mangSo = { 5, 2, 4, 6, 1, 3 };
        Console.WriteLine("Mảng ban đầu:");
        HienThiMang(mangSo);

        Quicksort(mangSo, 0, mangSo.Length - 1);

        Console.WriteLine("\nMảng sau khi sắp xếp:");
        HienThiMang(mangSo);
        Console.ReadLine();
    }

    static void Quicksort(int[] mangSo, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(mangSo, left, right);

            Quicksort(mangSo, left, pivot - 1);
            Quicksort(mangSo, pivot + 1, right);
        }
    }

    static int Partition(int[] mangSo, int left, int right)
    {
        int pivot = mangSo[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (mangSo[j] <= pivot)
            {
                i++;
                Swap(mangSo, i, j);
            }
        }

        Swap(mangSo, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] mangSo, int i, int j)
    {
        int temp = mangSo[i];
        mangSo[i] = mangSo[j];
        mangSo[j] = temp;
    }

    static void HienThiMang(int[] mangSo)
    {
        for (int i = 0; i < mangSo.Length; i++)
        {
            Console.Write(mangSo[i] + " ");
        }
    }
}
