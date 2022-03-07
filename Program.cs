using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortedListKoleksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList ogrenciler=new SortedList(); //Sortedlist Nesnesi Oluşturma.

            ogrenciler.Add(368,"Ahmet"); //Koleksiyona Veri Ekleme.

            ogrenciler.Remove(368);  //Koleksiyondan Veri Silme.

            ogrenciler[368] = "Mehmet";  //Koleksiyonda Veri Güncelleme.

            foreach (DictionaryEntry eleman in ogrenciler) //DictionaryEntry İsimde Bir Sınıf Kullanarak Hem Key Hem de Value Değerlerine Erişim Sağlanabilir.
            {
                Console.WriteLine(eleman.Key+"-"+eleman.Value);
            }
            Console.ReadKey();
        }
        //Ekran Çıktısı;
        //368-Mehmet
    }
}
