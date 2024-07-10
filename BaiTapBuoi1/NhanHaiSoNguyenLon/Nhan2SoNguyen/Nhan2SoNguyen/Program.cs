using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class NhanSoNguyenLon
{
    static void Main(string[] args)
    {
        string soThuNhat = "122236789";
        string soThuHai = "987612321";
        Console.OutputEncoding = Encoding.UTF8;
        string ketQua = Nhan(soThuNhat, soThuHai);
        Console.WriteLine("Số thứ nhất: {0}", soThuNhat);
        Console.WriteLine("Số thứ hai: {0}", soThuHai);
        Console.WriteLine("Kết quả: {0}", ketQua);
        Console.ReadLine();

    }

    static string Nhan(string soThuNhat, string soThuHai)
    {
        if (soThuNhat.Length == 0 || soThuHai.Length == 0)
        {
            return "0";
        }

        int nho = 0;
        string ketQua = "";

        for (int i = soThuHai.Length - 1; i >= 0; i--)
        {
            int tich = 0;
            for (int j = soThuNhat.Length - 1; j >= 0; j--)
            {
                tich += (int)(soThuHai[i] - '0') * (int)(soThuNhat[j] - '0');
                tich += nho;

                nho = tich / 10;
                tich %= 10;
            }

            ketQua = (char)(tich + '0') + ketQua;
        }

        if (nho > 0)
        {
            ketQua = (char)(nho + '0') + ketQua;
        }

        return ketQua;
    }
}
