using System;

namespace Const_ve_Readonly_arasında_ki_fark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sabitlerConst.pi);
            sabitlerReadonly nesne=new  sabitlerReadonly();
            Console.WriteLine(nesne.pi);
            /*
             * Const ve readonly arasında readonly nesne olarak kabul edlilir const değişken olarak
             * bir class içerisinde ise illaki türetilmesi gerekli
             * Bir diğer fark ise const ta ilk değer vermek zorunlu readonly de ise değer sonradan verilip sabitlenir
             * örneğin programın çalıştığı adres yada veri tabanı adresi yada veri tabanında kayıtlı bir şifrenin tekrar tekrar çekilmemesi gibi
             * şimdi bir dizi olarak yada enum olarak tanımlanır mı ona bakalım
            */
        }
    }
    class sabitlerConst
    {
        internal const double pi = 3.14;
    }
    class sabitlerReadonly
    {
        internal readonly double pi;
        internal readonly enum  keyler;
    }
}
