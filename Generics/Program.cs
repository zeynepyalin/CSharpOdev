using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler1 = new List<string>();
            sehirler1.Add("Ankara"); // buradaki add list'in fonksiyonlarından biri, gerçekten listeye ekler.

            MyList<string> sehirler = new MyList<string>();
            sehirler.Add("stray kids"); // buradaki add class içerisindeki fonksiyon, ekleme işlemi yazılmadıkça eklemez.
        }
    }
    class MyList<T>
    {
        T[] _array;
        T[] _tempArray; // geçici dizi
        public MyList()
        {
            // mylist ile oluşturulan listeye elemanların kaydedilebilmesi için burada öncelikle 0 elemanlı olarak yer ayırtma yaptık.
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            // önceki elemanları yeni diziye taşıdıktan sonra T item ile gelen yeni eleman dizinin son elemanı olarak diziye eklenir.
            _array[_array.Length - 1] = item;
        }
        // çağırıldığında arrayin eleman sayısını verecek
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
