using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace Alıştırma_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable sozluk = new Hashtable();
            string kullaniciSecim;
            string kullaniciSecim2;
            string key;
            string value;
            string value2;
            int sayi;
            do
            {
                Console.WriteLine("Yeni kayıt eklemek istiyor musunuz? E/H");
                Console.WriteLine("Çıkmak için X'e basın");
                kullaniciSecim = Console.ReadLine().ToLower();
                Console.Clear();
                switch (kullaniciSecim)
                {
                    case "e":

                        do
                        {
                            Console.WriteLine("İngilizce değer giriniz");
                            key = Console.ReadLine();

                            bool kontrol = sozluk.ContainsKey(key);

                            if (kontrol)
                            {
                                Console.WriteLine($"Girmek istediğiniz {key} değeri sözlükte bulunmakta olup karşılığı {sozluk[key].ToString()}'dır. ");
                                Console.WriteLine("Bu değere yeni bir karşılık eklemek ister misiniz? E/H");
                                string cevap = Console.ReadLine().ToUpper();

                                if ( cevap == "E")
                                {
                                    Console.WriteLine("Yeni karşılığı giriniz:");
                                    value2 = Console.ReadLine();
                                    sozluk[key] = value2;   
                                    Console.Clear() ;
                                    Console.WriteLine("Yeni değer kaydedilmiştir");
                                    System.Threading.Thread.Sleep(1500);
                                }
                                else
                                {
                                    break;
                                }
                            }

                            else
                            {
                                Console.WriteLine("Türkçe karşılığını giriniz.");
                                value = Console.ReadLine();
                                sozluk.Add(key, value);
                                Console.Clear();
                                Console.WriteLine("Eklemek istediğiniz değer eklenmiştir.");
                                System.Threading.Thread.Sleep(1500);
                                Console.Clear();
                            }

                            Console.WriteLine("Yeni değer eklemek istiyor musunuz? E/H");
                            kullaniciSecim2 = Console.ReadLine().ToUpper();


                        
                        } while (kullaniciSecim2 == "E");
                        break;

                    case "h":

                        // Burada bütün değerleri yazmak için ya if ya da foreach döngüsü kullanacağız. Foreach döngüsü için içeride
                        // item olarak tanımlanacak değerin veri tipinin bulunması gerekecektir. Bunu bulmak için yazacağımız foreach
                        // döngüsüne (item'i var/object değişkenine tanımladıktan sonra) "Console.WriteLine(item.GetType().Name);"
                        // yazmamız gerekecektir. Veri tipini aldıktan sonra (bizim durumumuzda DictionaryEntry) foreach döngüsünü yeniden
                        // kurmamız gerekir.

                        foreach (var item in sozluk.Keys) // burada önemli olan item'in sozluk HashTable listesi içinde key mi
                                                          // value mu değerini alaccağını tanımlamaktır. Aksi takdirde item
                                                          // değeri null kalacaktır ve kod çalışmayacaktır. Burada item'in veri
                                                          // tipini var ya da object olarak girdiğimiz için özel olarak DictionaryEntry
                                                          // olarak tanımlamamıza aslında gerek yoktur (çünkü object ve var birden fazla
                                                          // veri tipinin karşılığını alabilirler) ancak ileriki durumlarda kullanacağımız item
                                                          // geçici değişkeninin veri tipini bilmenin önemli olacağı durumlar olacaktır.
                        {
                            Console.WriteLine($"{item} : {sozluk[item]}");
                        }
                        break;


                    default:
                        break;
                }


            } while (true);

        }
    }
}
