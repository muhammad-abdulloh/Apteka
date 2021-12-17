using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Apteka.Dorilar;
using Apteka.Client;

namespace Apteka
{
    internal class Program : ClientDataBase
    {
        public Program(string Login, string Password, string Name, decimal ClientSumma, DateTime WhenAdded) : base(Login, Password, Name, ClientSumma, WhenAdded)
        {
        }

        static void Main(string[] args)
        {
            // Umumiy dorilar bazasidan object olyabmiz
            DataBaseDorilar dataBaseDorilar = new DataBaseDorilar();
            
            // database da bor dorilarni ko'rib olyabmiz
            dataBaseDorilar.OutputDoriDate(dataBaseDorilar.dataDori);          
           

            //// o'chirmoqchi bo'lgan dorimizning ID qiymatini kiritamiz
            //Console.WriteLine("Qaysi Id dagi dorini o'chirmoqchisiz");
            //int delId = int.Parse(Console.ReadLine());

            //// Kiritgan ID imizdagi dorini o'chirib yuboryabmiz
            //dataBaseDorilar.RemoveDate(delId , dataBaseDorilar.dataDori);


            // va qolgan dorilarni ko'rib olyabmiz
            Console.WriteLine("----------------------");
            dataBaseDorilar.OutputDoriDate(dataBaseDorilar.dataDori);


        }


    }
}
