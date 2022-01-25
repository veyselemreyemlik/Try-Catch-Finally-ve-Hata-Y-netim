using System;

namespace Try_Catch_HataYönetimi
{
    internal class Program
    {
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz...");

                int sayi = int.Parse(Console.ReadLine());

                Console.WriteLine("Girdiniz Sayı : " + sayi);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İŞLEM TAMAMLANDI.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000");
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok Küçük veya Çok Büyük Bir Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            
        }
    }
}
