using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BtTimKiemNhiPhan
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] mangSo = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
        int soCanTim =72;

        int viTri = TimKiemNhiPhan(mangSo, soCanTim);
        HienThiMang(mangSo);
        Console.WriteLine();
        Console.WriteLine("số cần tìm là:" + soCanTim);

        if (viTri != -1)
        {
            Console.WriteLine("Số {0} nằm ở vị trí {1} trong mảng.", soCanTim, viTri);
        }
        else
        {
            Console.WriteLine("Không tìm thấy số {0} trong mảng.", soCanTim);
        }
        Console.ReadLine();
    }

    static int TimKiemNhiPhan(int[] mangSo, int soCanTim)
    {
        int left = 0;
        int right = mangSo.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mangSo[mid] == soCanTim)
            {
                return mid;
            }
            else if (mangSo[mid] < soCanTim)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }
    static void HienThiMang(int[] mangSo)
    {
        for (int i = 0; i < mangSo.Length; i++)
        {
            Console.Write(mangSo[i] + " ");
        }
    }
}


