using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apteka.Dorilar;
using Apteka.Client;
using static System.Console;

namespace Apteka.Client
{
    internal class ClientModel
    {
        private string clientLogin;

        public string login
        {
            get { return clientLogin; }
            set { clientLogin = value; }
        }

        private string clientPassword;

        public string  password
        {
            get { return clientPassword; }
            set { clientPassword = value; }
        }

        private string clientName;

        public string name
        {
            get { return clientName; }
            set { clientName = value; }
        }

        private decimal clientSumma;

        public decimal clientSummaNow
        {
            get { return clientSumma; }
            set { clientSumma = value; }
        }

        private string  ClientWhenAdded;

        // qachon ro'yxatdan o'tgan degan joyiga bu whenAdded
        public string  whenAdded
        {
            get { return ClientWhenAdded; }
            set { ClientWhenAdded = value; }
        }


        private string WhichProductBuyClient;

        public string whichPrduct
        {
            get { return WhichProductBuyClient; }
            set { WhichProductBuyClient = value; }
        }

        private int HowManyBuyProductInClient;

        public int howManyProduct
        {
            get { return HowManyBuyProductInClient; }
            set { HowManyBuyProductInClient = value; }
        }


        private string BuyProductTimeAtTheMoment;
        

        public string buyProductTime
        {
            get { return BuyProductTimeAtTheMoment; }
            set { BuyProductTimeAtTheMoment = value; }
        }

        public decimal PricePurchased { get; set; }






        public ClientModel(string Login, string Password, string Name, decimal ClientSumma, DateTime WhenAdded)
        {
            login = Login;
            password = Password;
            name = Name;
            clientSumma = ClientSumma;
            whenAdded = WhenAdded.ToString();

        }



        public ClientModel(string InputLogin, decimal DoriSumma, decimal pricePurchased , string WhichProduct, int HowManyBuyProduct, DateTime BuyProductTime)
        {
            login = InputLogin;
            clientSumma -= DoriSumma * HowManyBuyProduct;
            PricePurchased = pricePurchased; // bu hozir nechta dori sotvogan bo'sa o'sha dorilarni umumiy narxi
            whichPrduct = WhichProduct;
            howManyProduct = HowManyBuyProduct;
            buyProductTime = BuyProductTime.ToString();
        }

        public ClientModel(string inputLogin, string inputPassword, string name, DateTime dateTimeNow)
        {
            this.login = inputLogin;
            this.password = inputPassword;
            this.name = name;
            this.whenAdded = dateTimeNow.ToString();
        }
    }
}
