using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TongPhanTuTrongMang
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khai báo biến để lưu trữ tổng
            int sum = 0;

            // Nhập số lượng phần tử trong mảng
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());

            // Khai báo và khởi tạo mảng a
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }

            // Tính tổng các phần tử trong mảng
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }

            // Hiển thị kết quả
            Console.WriteLine("Tổng các phần tử trong mảng là: {0}", sum);
            Console.ReadLine();
        }
    }

}
