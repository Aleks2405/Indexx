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
            string[] arr = null;
            string taq = " "; 
            var a = new Ind(5);

            //  Console.WriteLine(a.Check("7") + "такой строки нет ");

            Console.WriteLine();
            
            Console.WriteLine(a.Print(taq));







            //a[0] = new Ind { Name = "Dostoevsckui", Book = "Idiot" };
            //a[1] = new Ind { Name = "Dostoevsckui1", Book = "Idiot1" };
            //a[2] = new Ind { Name = "Dostoevsckui2", Book = "Idiot2" };
            //a[3] = new Ind { Name = "Dostoevsckui3", Book = "Idiot3" };
            //a[4] = new Ind { Name = "Dostoevsckui4", Book = "Idiot4" };


        }
    }
}

