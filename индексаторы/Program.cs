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
           // Ind a = new Ind();
            Console.WriteLine("Количество книг");
            for (int i = 0; i < 2; i++)
            {
                Ind a = new Ind() { Name = Console.ReadLine(), Book = Console.ReadLine() };
                //Ind b = new Ind() { Name = Console.ReadLine(), Book = Console.ReadLine() };
                Console.WriteLine(a.Name + "i = " + i);
            }
           

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"{a.Name[i]} ");
            //    Console.WriteLine(a.Book[i]);
            //}



            //a[0] = new Ind { Name = "Dostoevsckui", Book = "Idiot" };
            //a[1] = new Ind { Name = "Dostoevsckui1", Book = "Idiot1" };
            //a[2] = new Ind { Name = "Dostoevsckui2", Book = "Idiot2" };
            //a[3] = new Ind { Name = "Dostoevsckui3", Book = "Idiot3" };
            //a[4] = new Ind { Name = "Dostoevsckui4", Book = "Idiot4" };

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write($"{a[i].Name} ");
            //    Console.WriteLine(a[i].Book);
            //}
        }
    }
}
