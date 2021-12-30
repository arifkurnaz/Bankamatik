using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Bankamatik
{
    class Bankamatik
    {
        public int secim;
        public string user = null;
        public ulong hesapNo;
        public string pass;
        public int limit = 0;
        public int havale;
        public string[] message ={
                             "BANKAMATİK OTOMASYONUNA HOSGELDİNİZ",
                             "Daha once bankamız müsterisi değilsiniz",
                             "Sistem yeni Müsteri kaydı oluşturacaktır",
                             "İşleminiz başarı ile gerçekleştirilmiştir",
                             "Sistemde bir hata oluştu lütfen daha sonra deneyiniz",
                             "Başka işlem yapmak istiyormusunuz ?",
                             "işlem Yapmak için  E çıkış yapmak icin Ç ye basınız",
                             "Başarı ile {0} havale yaptınız",
                             "İşlemi gerçekleştiremedik :-S Zannedercem CPU isyanlara bağladı",
                             "Şimdi {0} havale Yapıyorsunuz",
                             "Lütfen Bekleyiniz İşleminiz Yapılıyor",
                             "Kalan Bakiyeniz {0} TL dir",
                             " Mevcut Bakiyeniz {0} TL dir",
                             "Bilgileriniz Kontrol Ediliyor",
                             "Lütfen Bekleyiniz",
                             " Sayın {0} Lütfen Bir işlem Seciniz ",
                             "Yardım"
                             };
        public string[] islem ={
                              "Para Çekme",
                              "Para Yatırma",
                              "Şifre Degişikliği",
                              "Havale İşlemleri",
                              "Bakiye Öğren",
                              "Çıkış Yap"
                              };
        public string[] havaleIslem ={
                                     "Annenize",
                                     "Sevgilinize"
                                     };
        public void HspNoUret()
        {
            Random rnd = new Random();
            int gecici = rnd.Next(1, 99999999);
            int gecici1 = rnd.Next(0, 99999999);
            string yeni = gecici.ToString() + gecici1.ToString();
            this.hesapNo = ulong.Parse(yeni);
        }
        public void islemYapiliyor()
        {
            RenkYazi("sari");

            for (int i = 0; i < 25; i++)
            {
                Console.Write(".");
                Thread.Sleep(60);
            }
            Console.Clear();
            Console.WriteLine();
            RenkTemizle();

        }
        public void RenkYazi(string renk)
        {

            switch (renk)
            {

                case "mavi":

                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "siyah":

                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "koyumavi":

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case "koyugri":

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "koyuyesil":

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "koyumor":

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "koyukirmizi":

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "koyusari":

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gri":

                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "yesil":

                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "mor":

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "kirmizi":

                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "beyaz":

                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "sari":

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

            }
        }

        public void RenkArkaPlan(int renk)
        {

            switch (renk)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Yellow;

                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.White;

                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.Red;

                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Magenta;

                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Green;

                    break;
                case 6:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    break;
                case 7:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;

                    break;
                case 8:
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    break;
                case 9:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;

                    break;
                case 10:
                    Console.BackgroundColor = ConsoleColor.DarkGray;

                    break;
                case 11:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    break;
                case 12:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    break;
                case 13:
                    Console.BackgroundColor = ConsoleColor.Cyan;

                    break;
                case 14:
                    Console.BackgroundColor = ConsoleColor.Blue;

                    break;
                case 15:
                    Console.BackgroundColor = ConsoleColor.Black;

                    break;
                case 16:
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    break;

            }
        }
        public void RenkTemizle()
        {
            Console.ResetColor();
        }
        public void UserCheck()
        {
            if (this.user == null || this.user.Length < 2)
            {
                RenkYazi("mavi");
                Console.WriteLine("\n" + this.message[0] + "\n");
                for (int i = 1; i < 3; i++)
                {
                    RenkYazi("kirmizi");
                    Console.WriteLine("\n" + this.message[i] + "");

                }
                RenkTemizle();
                Console.WriteLine("\nAdınızı Yazınız:");
                this.user = Console.ReadLine();
                Console.WriteLine("\nŞifrenizi Giriniz:");
                this.pass = Console.ReadLine();
                Console.WriteLine("\t\n" + this.message[10] + "\t\n");
                islemYapiliyor();
                RenkYazi("yesil");
                Console.WriteLine("\t\n" + this.message[3] + "\t\n");
                RenkTemizle();
                Console.Clear();
                Console.WriteLine();
                // Console.WriteLine(message[3]);
                HspNoUret();
                this.user = this.user.ToUpper();
                Console.WriteLine(" {0} \n\nŞifreniz: '{1}'\nHesap Numaranız: {2}", this.user, this.pass, this.hesapNo);
                RenkYazi("koyumavi");
                Console.WriteLine("\nŞimdi Yönlendiriliyorsunuz\n");
                islemYapiliyor();
                RenkTemizle();
                //Console.ReadLine();
            }
            HspNoUret();
            Console.WriteLine("\n{0,10}\n", this.message[0]);
            RenkYazi("koyukirmizi");
            Console.WriteLine("\n{0,25}\nHSPNO:{1,25}\nBakiye: {2,10} TL dir ", this.user.ToUpper(), this.hesapNo, this.limit);
        }
        public void Bakiye()
        {

            Console.WriteLine("\n Sayın {0}\n {1} nolu hesabınızda\n{2} TL bakiye bulunmaktadır\n", this.user.ToUpper(), this.hesapNo, this.limit);
            Islemler();
        }
        public void ParaCekme()
        {
            Console.WriteLine("\n{0,10}\n", this.message[0]);
            RenkYazi("mavi");
            Console.WriteLine("\n{0}\n ", this.user.ToUpper());
            if (this.limit <= 0)
            {
                RenkYazi("kirmizi");
                Console.WriteLine("Hesabınızda Yeterli Miktarda Bakiye bulunmamaktadır \nLütfen Önce  Para Yatırmayı deneyin");
                Islemler();
            }
            else
            {
                RenkYazi("yesil");
                Console.Write("Lütfen Cekmek istediginiz Miktarı giriniz:");
                int para = int.Parse(Console.ReadLine());
                Console.WriteLine(message[10]);
                this.limit = this.limit - para;
                islemYapiliyor();
                RenkTemizle();
                Console.WriteLine("Lütfen Acılan Bölmeden paranızı ekran göründüğü gibi alın :P");
                RenkYazi("yesil");
                Console.WriteLine(message[3]);
                Console.ReadLine();
                Islemler();
            }
        }
        public void ParaYatirma()
        {
            Console.WriteLine("\n{0,10}\n", this.message[0]);
            RenkYazi("mavi");
            Console.WriteLine("\n{0}\n ", this.user.ToUpper());

            RenkYazi("yesil");
            Console.WriteLine("Açılan Bölmeye  Parayı Ekranda görüldüğü gibi yerleştir :D :");
            int para = int.Parse(Console.ReadLine());
            Console.WriteLine(message[10]);
            this.limit = this.limit + para;
            islemYapiliyor();
            RenkTemizle();
            Console.WriteLine();
            RenkYazi("yesil");
            Console.WriteLine("Tebrikler Başarı ile  Parayı Yatırdınız :P");
            Console.ReadLine();
            Islemler();
        }
        public void Havale()
        {
            Console.WriteLine("\n{0,10}\n", this.message[0]);
            RenkYazi("mavi");
            Console.WriteLine("\n{0}\n ", this.user.ToUpper());

            RenkYazi("yesil");
            Console.WriteLine("Havale yapabileceginiz Kişiler:");
            for (int i = 0; i < havaleIslem.Length; i++)
            {
                Console.WriteLine(i + 1 + "-" + havaleIslem[i]);
            }
            Console.Write("Kime havale yapacaksın: ");
            int kime = int.Parse(Console.ReadLine());
            Console.Write("Göndermek istediginiz  Miktarı giriniz:");
            int para = int.Parse(Console.ReadLine());
            Console.WriteLine(message[10]);
            this.limit = this.limit - para;
            islemYapiliyor();
            RenkTemizle();
            switch (kime)
            {
                case 1:
                    kime = 0;
                    break;
                case 2:
                    kime = 1;
                    break;
            }

            Console.WriteLine();
            RenkYazi("yesil");
            Console.WriteLine("Tebrikler Başarı ile {0}  {1}  Havale Yaptınız!!", havaleIslem[kime], para);
            Console.ReadLine();
            Islemler();
        }
        public void sifreDegistirme()
        {

        don: Console.Write("Yeni Şifrenizi Giriniz:");
            string sifre = Console.ReadLine();
            Console.Write("Yeni Sifreyi Tekrarlayın:");
            string sifre1 = Console.ReadLine();
            if (sifre != sifre1)
            {
                RenkYazi("kirmizi");
                Console.WriteLine("Sifreleriniz Uyuşmuyor");
                goto don;
            }
            else this.pass = sifre;
            RenkYazi("yesil");
            islemYapiliyor();
            Console.WriteLine("işleminiz başarı ile gerçekleştirilmiştir");
            Islemler();

        }
        public void Islemler()
        {
            RenkYazi("yesil");
            for (int j = 0; j < this.islem.Length; j++)
            {
                Console.WriteLine("\n{0}-{1}", j + 1, this.islem[j]);

            }
            Console.Write("\nyapmak istediginiz işlemin  numarasını giriniz: ");
            string ge = Console.ReadLine().Trim();
            this.secim = int.Parse(ge);

            islemYapiliyor();
            switch (this.secim)
            {
                case 1:
                    ParaCekme();
                    break;
                case 2:
                    ParaYatirma();
                    break;
                case 3:
                    sifreDegistirme();
                    break;
                case 4:
                    Havale();
                    break;
                case 5:
                    Bakiye();
                    break;
                case 6:
                    CikisYap();
                    break;
            }
        }
        public void CikisYap()
        {
            RenkYazi("kirmizi");
            string hata = "Kartınızı almayı unutmayınız".ToUpper();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("{0,25}", hata);
                Console.Beep(1900, 700);
                Console.Clear();
                Thread.Sleep(500);


            }
            Environment.Exit(0);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Bankamatik matik = new Bankamatik();
            Console.Write("Kullanıcı Adınızı Giriniz: ");
            matik.user = Console.ReadLine();
            Console.Write("Sİfrenizi Giriniz: ");
            matik.pass = Console.ReadLine();
            matik.islemYapiliyor();
            matik.UserCheck();
            matik.Islemler();

        }
    }
}
