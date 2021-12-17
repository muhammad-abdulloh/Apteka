using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Client;
using Apteka.Dorilar;

namespace Apteka.Dorilar
{
    internal class DataBaseDorilar 
    {
        // Dorilarni saqlash uchun list
        public List<DoriModeli> dataDori = new List<DoriModeli>();
        

        // Dorilarni kiritish

        public void InputDoriDate()
        {
            while (true)
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Dorining nomi:  ");
                string name = Console.ReadLine();
                decimal DoriNarx = 0;
                int doriSoni = 0;
                try
                {
                    Console.Write("Dorining narxi:  ");
                    DoriNarx = decimal.Parse(Console.ReadLine());

                    Console.Write("Dorining soni:  ");
                    doriSoni = int.Parse(Console.ReadLine());

                    dataDori.Add(new DoriModeli(id, name, DoriNarx, doriSoni));
                }
                catch
                {
                    Console.WriteLine("Faqat son kiriting");
                }

                Console.WriteLine("\n1-Yana qo'shish\t\t\t0-Orqaga");
                try
                {
                    int son = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (son == 1) continue;
                    else if (son == 0)
                    {
                        Console.Clear();
                        break;
                    }
                    else Console.WriteLine("Bunday buyruq mavjud emas");
                }
                catch
                {
                    Console.WriteLine("Faqat son kiriting");
                }
            }
        }





        // Dorilarni ekranga chiqarish uchun method
        public  void OutputDoriDate(List<DoriModeli> dataDori)
        {
            foreach (var data in dataDori)
            {
                Console.WriteLine("Id: {0}, Name: {1},  Narxi: {2},  Soni: {3} ", data.ID, data.Name, data.Narxi, data.Soni);
            }
        }


        // berilgan indexdagi dorilarni o'chirish uchun method
        public void RemoveDate(int inputDelIdAll, List<DoriModeli> dataDori)
        {

            int index = dataDori.FindIndex(v => v.ID == inputDelIdAll);
            
            dataDori.RemoveAt(index);

        }

        

    
    }
}
