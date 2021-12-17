using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Client;
using Apteka.Dorilar;
using static System.Console;

namespace Apteka.Client
{
    
    internal class ClientDataBase : ClientModel 
    {
        // Cient haqida malumotlar to'planadigon list
        public List<ClientModel> clientData = new List<ClientModel>();
        public List<ClientModel> clientReport = new List<ClientModel>();


        public string oldLoginOne = "Komilov1";
        public string oldPasswordOne = "1234";

        public string oldLoginTwo = "oldlogin";
        public string oldPasswordTwo = "qwerty";

        public ClientDataBase(string Login, string Password, string Name, decimal ClientSumma, DateTime WhenAdded) : base(Login, Password, Name, ClientSumma, WhenAdded)
        {
            
        }


        // Userni ro'yxatdan o'tkazib data base ga ma'lumotlarini yozib qo'yish

        public void SignUp()
        {
            while (true)
            {
                try
                {
                    Write("Input Login: ");
                    string inputLogin = ReadLine();

                    Write("Input Password: ");
                    string inputPassword = ReadLine();

                    Write("Input Coniform Password: ");
                    string coniformPassword = ReadLine();

                    while (inputLogin == null || inputPassword == null || inputPassword != coniformPassword)
                    {
                        Clear();
                        WriteLine("Password ni yoki Loginni bo'sh qoldirish mumkin emas");
                        WriteLine("Kiritlayotgan ikkalovi password ham bir xil bo'lishi shart");

                        WriteLine("Password or Login is not exists");
                        WriteLine("Repeat password and login");
                        WriteLine("----------------------------------------------------------------------");
                        Write("Input Login: ");
                        string inputLogin1 = ReadLine();

                        Write("Input Password: ");
                        string inputPassword1 = ReadLine();

                        Write("Input Coniform Password: ");
                        string coniformPassword1 = ReadLine();

                        if (inputLogin1 != null && inputPassword1 != null && inputPassword1 == coniformPassword1)
                        {
                            inputLogin = inputLogin1;
                            inputPassword = inputPassword1;
                            Clear();
                            break;
                        }
                        else
                        {
                            Clear();
                            WriteLine("Password ni yoki Loginni bo'sh qoldirish mumkin emas");
                            WriteLine("Kiritlayotgan ikkalovi password ham bir xil bo'lishi shart");

                            WriteLine("Password or Login is not exists");
                            WriteLine("Repeat password and login");
                        }
                    }

                    Write("Input Name: ");
                    string name = ReadLine();
                    decimal clientSummaInput = 0;
                    while (true)
                    {
                        WriteLine("replenish the account: [Yes/y] or [No/n]");
                        string chack = ReadLine().ToLower();

                        try
                        {
                            if (chack == "y" || chack == "yes")
                            {
                                Write("Input Summa: ");
                                clientSummaInput = decimal.Parse(ReadLine());
                            }
                            else if (chack == "n" || chack == "no")
                            {
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Clear();
                            WriteLine("To'g'ri buyruqni kiriting: [Yes or y, or No or n] ");
                        }
                        Clear();


                    }

                    DateTime dateTimeNow = DateTime.Now;

                    clientData.Add(new ClientModel(inputLogin, inputPassword, name, clientSummaInput, dateTimeNow));
                    Clear();
                    break;

                }
                
                catch
                {
                    Clear();
                    WriteLine("Ma'lumotlarni kiritishda qandaydur hatolik bor qaytadan harakat qilib ko'ring :) ");
                }
                                
            }
        }

        // Userni saytga kirishi
        public void SignIn()
        {
            while (true)
            {
                Clear();
                // Istisno bo'lib qolishi mumkin shuning uchun try catch dan foydalanyabmiz
                try
                {

                    Write("Input Login: ");
                    string inputLogin = ReadLine();
                    Write("Input Password: ");
                    string inputPassword = ReadLine();

                    if (inputLogin == oldLoginOne && inputPassword == oldPasswordOne || inputLogin == oldLoginTwo && inputPassword == oldPasswordTwo)
                    {
                        // qaysi product ni sotib olishi
                        Write("Which product you want to buy:  ");
                        string whichProduct =  ReadLine();

                        // nechta sotib olishi
                        Write("How many products you want to buy:  ");
                        int howManyBuyProducts = int.Parse(ReadLine());

                        // dori sotib olgan vaqti
                        DateTime dateTime = DateTime.Now;

                        // Shu joyda database dan dorini summasi olinishi kerak 
                        // Men shunchaki default holatda summa berib qo'yyabman
                        decimal doriSumma = 12;

                        // haridorni hisobotini kiritib boramiz

                        // Clientni ismi yoziladi, o'sha dorini summasini , qaysi dorini sotvoldi, nechta sotvoldi, va qaysi paytda sotvoldi 
                        decimal pricePurchased = doriSumma * howManyBuyProducts;
                        clientReport.Add(new ClientModel(inputLogin, doriSumma, pricePurchased , whichProduct, howManyBuyProducts, dateTime));
                        Clear();
                        break;
                    }
                    else
                    {
                        Clear();
                        WriteLine("Login yoki password hato boshqatdan kiritib ko'ring");
                    }

                }
                catch 
                {
                    Clear();
                    WriteLine("Login or Password is not exists! \n" +
                              "Please repeat: Login and Password ");
                }
                Clear();

            }
        }

    }
}
