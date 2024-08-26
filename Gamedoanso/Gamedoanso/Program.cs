using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;

namespace Gamedoanso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
        //1.generate a random number 
        Luot_Choi:
            Random rnd = new Random ();
            int comp_num = rnd.Next(1, 100);
            int man_num = 0;
            Console.WriteLine("Chào mừng bạn đã gia nhập thế giới của những con số");
            int tien = 1000;
            Thread.Sleep(5000);
            Console.WriteLine("Bạn đang có trong tay:{0}", tien);
            Thread.Sleep(3000);
            Console.WriteLine("Máy tính đã sẵn sàng để đấu. Hãy chuẩn bị ngay nhé!");
            Thread.Sleep(2000);
            int i;
            int soluot;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Luot choi moi");
            for (i = 1;i < 8;i++)
            {
                //2.Ask user for number
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Đây là lượt chơi thứ {0}", i);
                Console.WriteLine("Hãy thử tài đoán của bạn bằng cách nhập vào con số mà bạn đang nghĩ tới");
                man_num= int.Parse("0"+ Console.ReadLine());
                //3. Checking for result
                if (man_num == comp_num)
                {
                    tien = tien + 500;
                    Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                    Console.WriteLine("Xin chúc mừng bạn! Với lượt chơi thứ {0}, bạn đã đoán chính xác", i);
                    Console.WriteLine("Số tiền mà bạn đang có: {0}", tien);
                    Console.WriteLine("Muahahaah you win");
                    goto You_Win;
                }
                else if (man_num > comp_num)
                {
                    tien = tien - 50;
                    Console.WriteLine("Số bạn đoán lớn hơn số tôi nghĩ");
                    Console.WriteLine("Số tiền mà bạn đang có: {0}", tien);
                    soluot = 8 - i;
                    Console.WriteLine("Bạn còn {0} lượt chơi", soluot);
                }
                else if (man_num < comp_num)
                {
                    tien = tien - 50;
                    Console.WriteLine("Số bạn đoán nhỏ hơn số tôi nghĩ");
                    Console.WriteLine("Số tiền mà bạn đang có: {0}", tien);
                    soluot = 8 - i;
                    Console.WriteLine("Bạn còn {0} lượt chơi", soluot);
                } 
                if (tien <= 0)
                {
                    Console.WriteLine("Het tien roi, bye nha");
                    break;
                }
            }
            goto You_Lose;
        You_Win:
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N)");
            string dapan = Console.ReadLine();
            if (dapan == "Y")
            {
                if (tien < 80)
                {
                    Console.WriteLine("Ban khong du tien.Bye bye");
                }
                else
                {
                    tien = tien - 80;
                    goto Luot_Choi;
                }
            }    
            else
            {
                Console.WriteLine("KẾT THÚC TRÒ CHƠI. BẠN THẮNG VỚI SỐ TIỀN {0}", tien);
            }
        You_Lose:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Bạn có thể đoán như thế nhưng muahahahaa u loser");
            Console.WriteLine("TẠM HOÃN TRÒ CHƠI. BẠN THUA VỚI SỐ TIỀN {0}", tien);
            Console.WriteLine("Bạn có muốn tiếp tục không? (Y/N)");
            string dap_an = Console.ReadLine();
            if (dap_an == "Y")
            {
                if (tien < 80)
                {
                    Console.WriteLine("Ban khong du tien.Bye bye");
                }
                else
                {
                    tien = tien - 80;
                    goto Luot_Choi;
                }
            }
            else
            {
                Console.WriteLine("KẾT THÚC TRÒ CHƠI. BẠN THUA VỚI SỐ TIỀN {0}", tien);
                Console.WriteLine("So may tinh doan, that ra la : {0}",comp_num);
            }
        Console.ReadKey();
        }
    }
}
