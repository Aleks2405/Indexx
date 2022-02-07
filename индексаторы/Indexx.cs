using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind
{

    class Ind
    {
       // public string Book { get; set; }    // так и не придумал как в программе правильно воспользоваться (((((
             
        private string[] arr;
        private int size;

        public Ind(int size)                /*конструктор */
        {
            this.size = size;
            arr = new string[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            //throw new IndexOutOfRangeException();  

        }
        public string Print()                /*   печать*/
        {
             string s = null;
                for (int i = 0; i < arr.Length; i++)
                {
                     s += arr[i] + " ";
               
                }
           
            return s;
        }

        public string Check(string s)              /* проверка есть ли указанная строки или нет */
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == s)
                {
                    return "True";
                }
                else
                {
                    return "False";
                }

            }
            return s;

        }
        public void Del(int size)             /* удаление элемента*/
        {
            List<string> tmp = new List<string>(arr);
            tmp.RemoveAt(size);
            arr = tmp.ToArray();
            //throw new IndexOutOfRangeException();   // сам выбивал ошибку для проверки работы исключения
        }
        public void Dob(int size, string a) {  // добавим элемент
            Array.Resize(ref arr, size);
            arr[size - 1] = a;
       }

        public string this[int index]                /*индексатор*/
        {
            get { return arr[index]; }

            set { arr[index] = value; }
        }


    }
}
