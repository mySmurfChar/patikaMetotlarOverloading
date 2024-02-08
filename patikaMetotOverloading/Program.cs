namespace patikaMetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;
            bool sayiTespit = int.TryParse(sayi, out outSayi);
            if (sayiTespit )
            {
                Console.WriteLine("işlem başarılı");
                Console.WriteLine(outSayi.GetType);
                Console.WriteLine(sayi);
            }
            else
            {
                Console.WriteLine("işlem başarısız");
            }
            Topla(4, 5, out int toplam);
            Console.WriteLine(toplam);
            ekranaYazdir(12);
            ekranaYazdir("Merhaba Dünya");


        }

        public static void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public static void ekranaYazdir(string a)
        {
            Console.WriteLine(a);
        }
        public static void ekranaYazdir(int a)
        {
            Console.WriteLine(a);
        }

    }
}
