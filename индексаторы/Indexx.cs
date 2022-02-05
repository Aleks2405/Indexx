﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ind
{

    class Ind
    {
        //public string Name { get; set; }
        public string Book { get; set; }

        //public int Number { get; set; } 

        private string[] arr;
        private int size;

        public Ind() { }

        public Ind(int size)                /*конструктор */
        {
            this.size = size;
            arr = new string[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
        }
        public string Print(string s)                /*   печать*/
        {
                for (int i = 0; i < arr.Length; i++)
                {
                     s += arr[i];
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

       

        public string this[int index]                /*индексатор*/
        {
            get { return arr[index]; }

            set { arr[index] = value; }
        }


    }
}
