using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class BtMergeSort
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Thuật toán MergaSort");
        int[] mangSo = { 5, 2, 4, 6, 1, 3 };
        Console.WriteLine("Mảng ban đầu:");
        HienThiMang(mangSo);

        mangSo = MergeSort(mangSo);

        Console.WriteLine("\nMảng sau khi sắp xếp:");
        HienThiMang(mangSo);
        Console.ReadLine();
    }

    static int[] MergeSort(int[] mangSo)
    {
        if (mangSo.Length <= 1)
        {
            return mangSo;
        }

        int mid = mangSo.Length / 2;
        int[] trai = new int[mid];
        int[] phai = new int[mangSo.Length - mid];

        Array.Copy(mangSo, 0, trai, 0, mid);
        Array.Copy(mangSo, mid, phai, 0, mangSo.Length - mid);

        trai = MergeSort(trai);
        phai = MergeSort(phai);

        return Merge(trai, phai);
    }

    static int[] Merge(int[] trai, int[] phai)
    {
        int[] mangKetQua = new int[trai.Length + phai.Length];
        int i = 0, j = 0, k = 0;

        while (i < trai.Length && j < phai.Length)
        {
            if (trai[i] <= phai[j])
            {
                mangKetQua[k] = trai[i];
                i++;
            }
            else
            {
                mangKetQua[k] = phai[j];
                j++;
            }
            k++;
        }

        while (i < trai.Length)
        {
            mangKetQua[k] = trai[i];
            i++;
            k++;
        }

        while (j < phai.Length)
        {
            mangKetQua[k] = phai[j];
            j++;
            k++;
        }

        return mangKetQua;
    }

    static void HienThiMang(int[] mangSo)
    {
        for (int i = 0; i < mangSo.Length; i++)
        {
            Console.Write(mangSo[i] + " ");
        }
    }
}
