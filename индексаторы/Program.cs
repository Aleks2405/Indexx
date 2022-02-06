using System;

/*Создайте приложение «Список книг для прочтения». 
Приложение должно позволять добавлять книги в список, удалять книги из списка, проверять есть ли книга в 
списке, и т. д. Используйте механизм свойств, перегрузки 
операторов, индексаторов.*/
namespace ind
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string taq = " ";
            int size = 5;
            int ykaz = 3;                //переменная для замены строки 
            string vvod = "da";
            string strig = "odna is book";
            var a = new Ind(size);
            Console.WriteLine();

            if (vvod == "net")
            {
                a[ykaz] = Console.ReadLine();  // работает поправок вносить не нужно                               
            }
            a.del(2);
            a.dob(5, strig);

            a[0] = "asdda";
            Console.WriteLine(a.Print(taq) + "");
                                                                

        }
    }
}

