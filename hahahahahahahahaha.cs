using System;

namespace rzd_eban_pogromist {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int nomer_vagona = 0;
            bool eban = true;
            do {
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("    Вагон № {0:00}", nomer_vagona);
                Console.Write("туалет свободен ●");
                nomer_vagona++;
                if (nomer_vagona == 31)
                    nomer_vagona = 0;
            }
            while (eban);
        }
    }
}
