using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresParkingSimulation
{
    public class Otopark
    {
        Stack stack = new Stack(15);
        LinkedList linkedList = new LinkedList();
        Queue queue = new Queue(30);
        Random rastgeleRenk = new Random();
        string strSonAraba = "";

        public string OtoparkArabaEkle() //Bodrum ve 2. Kata 15'er araba ekler
        {
            string rastgeleRenk = "";
            string strListe = "";
            int eklenenArabaSayisi = 0;
            for (int i = 0; i < 30; i++)
            {
                rastgeleRenk = RastgeleArabaRenkBelirle();
                if (i < 15)
                {
                    StackeEkleme(rastgeleRenk, i + 1);
                    eklenenArabaSayisi++;
                }
                else
                {
                    LinkedListeEkleme(rastgeleRenk, i + 1);
                    eklenenArabaSayisi++;
                }
            }
            if (eklenenArabaSayisi == 30)
            {
                strListe = "Tüm Arabalar Otoparka Eklenmiştir";
            }
            else
            {
                strListe = "Arabalar Otoparka Eklenirken Bir Hata Oluştu";
            }
            return strListe;
        }

        private void StackeEkleme(string renk, int arabaNo) //Bodrum Kat.
        {
            Araba araba = new Araba();
            araba.Numara = arabaNo;
            araba.Renk = renk;
            araba.BulunduguKat = "Bodrum Kat";
            stack.Push(araba);
        }

        private void LinkedListeEkleme(string renk, int arabaNo) //2. Kat.
        {
            Araba araba = new Araba();
            araba.Numara = arabaNo;
            araba.Renk = renk;
            araba.BulunduguKat = "2. Kat";
            if (linkedList.Head == null)
            {
                linkedList.InsertFirst(araba);
            }
            else
            {
                linkedList.InsertLast(araba);
            }
        }

        public string ArabaListeleme() //Otoparktaki Arabaları Listele
        {
            string strListe = "     Bodrum Kattaki Arabalar :" + Environment.NewLine;
            foreach (Araba a in stack.PeekArray())
            {
                strListe += "" + a.Numara + " Numaralı Arabanın --> Rengi : " + a.Renk + " -- Bulunduğu Kat : " + a.BulunduguKat + Environment.NewLine;
            }
            strListe += linkedList.DisplayElements();
            return strListe;
        }

        public string OtoparktanCikis() //2. ve Bodrum Kattki Arabalar; -> 1. kattaki kuyruğa eklenir. -> Arabalar Stack ve LinkedListten silinir.
        {
            Random cikisRandom = new Random();
            Araba araba = new Araba();
            string strBilgi = "";
            int cikisOnceligi = 0;
            int bodrumdanCikanSayisi = 0, ikinciKatCikanSayisi = 0;
            int cikanArabaSayisi = 0;
            for (int i = 0; i < 30; i++)
            {
                if ((bodrumdanCikanSayisi < 15) && (ikinciKatCikanSayisi < 15))
                {
                    cikisOnceligi = cikisRandom.Next(0, 2); //cikisOnceligi değişkeni ->0 ise Bodrum kattan (Stack), ->1 ise 2. kattan (LinkedList) araba kuyruğa eklenir. (%50 olasılık böylece sağlanmış olur)
                    if (cikisOnceligi == 0)
                    {
                        araba = (Araba)stack.Peek();
                        QueueArabaEkleme(araba);
                        stack.Pop();
                        bodrumdanCikanSayisi++;
                        cikanArabaSayisi++;
                    }
                    else
                    {
                        araba = (Araba)linkedList.GetElement(0).Data;
                        if (ikinciKatCikanSayisi == 14)
                        {
                            strSonAraba = "2. Katta Son Kalan Arabanın -- > Numarası : " + araba.Numara + "-- Rengi: " + araba.Renk + "-- Çıkış Yaptığı Kat: " + araba.BulunduguKat + Environment.NewLine;
                        }
                        QueueArabaEkleme(araba);
                        linkedList.DeleteFirst();
                        ikinciKatCikanSayisi++;
                        cikanArabaSayisi++;
                    }
                }
                else if ((bodrumdanCikanSayisi < 15) && (ikinciKatCikanSayisi == 15))
                {
                    araba = (Araba)stack.Peek();
                    QueueArabaEkleme(araba);
                    stack.Pop();
                    bodrumdanCikanSayisi++;
                    cikanArabaSayisi++;
                }
                else if ((bodrumdanCikanSayisi == 15) && (ikinciKatCikanSayisi < 15))
                {
                    araba = (Araba)linkedList.GetElement(0).Data;
                    if (ikinciKatCikanSayisi == 14)
                    {
                        strSonAraba = "2. Katta Son Kalan Arabanın -- > Numarası : " + araba.Numara + "-- Rengi: " + araba.Renk + "-- Çıkış Yaptığı Kat: " + araba.BulunduguKat + Environment.NewLine;
                    }
                    QueueArabaEkleme(araba);
                    linkedList.DeleteFirst();
                    ikinciKatCikanSayisi++;
                    cikanArabaSayisi++;
                }
            }
            if (cikanArabaSayisi == 30)
            {
                strBilgi += "   --> Otoparktaki Tüm Arabalar Çıkış Kuyruğuna Eklenmiştir. Çıkış İşlemleri Devam Etmektedir. <--";
            }
            else
            {
                strBilgi = "Arabalar Kuyruğa Eklenirken Beklenmedik Hata Oluştu";
            }
            return strBilgi;
        }

        private void QueueArabaEkleme(Araba araba) //1.Kattaki Çıkış Kuyruğu.
        {
            queue.Insert(araba);
        }

        public string QueueArabaListele()
        {
            int i = 1;
            string strListe = "   --> Çıkış Kuruğundaki Araçlar :" + Environment.NewLine;
            foreach (Araba a in queue.Peek())
            {
                strListe += "Kuyruktaki " + i++ + ". Araç  -->  Numarası : " + a.Numara + " -- Rengi : " + a.Renk + " -- Çıkış Yaptığı Kat : " + a.BulunduguKat + Environment.NewLine;
            }
            return strListe;
        }

        public string QueueArabaÇıkarma() //Otoparktan Çıkış Kuyruğunu Boşaltır
        {
            Araba silinenAraba;
            string strListe = "   --> Otoparktan Çıkan Araçlar :" + Environment.NewLine;
            for (int i = 1; i <= 30; i++)
            {
                silinenAraba = (Araba)queue.Remove();
                strListe += "Otoparktan Çıkan " + i + ". Aracın  -->  Numarası : " + silinenAraba.Numara + " -- Rengi : " + silinenAraba.Renk + " -- Çıkış Yaptığı Kat : " + silinenAraba.BulunduguKat + Environment.NewLine;
                if (i == 30)
                {
                    strListe += strSonAraba;
                }
            }
            if (queue.IsEmpty())
            {
                strListe += "	--> Otoparktan Çıkış İşlemleri Başarıyla Gerçekleşmiştir. <--";
            }
            else
            {
                strListe = "	--> Otopark Boşaltma İşleminde Beklenmedik Hata Oluştu. <--";
            }
            return strListe;
        }

        private string RastgeleArabaRenkBelirle() //Arabalar için random renk üretir
        {
            string[] diziRenk = { "Füme", "Siyah", "Beyaz", "Kırmızı", "Mavi", "Açık Mavi", "Mor", "Sarı", "Kahverengi" };
            return diziRenk[rastgeleRenk.Next(0, 9)];
        }
    }
}
