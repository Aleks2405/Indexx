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
            try
            {
               
                int size = 5;
                int ykaz = 3;                //переменная для замены строки 
                string vvod = "da";
                string strig = "odna is book";

                var a = new Ind(size);
                Console.WriteLine();

                if (vvod == "net")
                {
                    Console.WriteLine("книгу по каким номером необходимо перезаписать");
                    a[ykaz] = Console.ReadLine();  // работает поправок вносить не нужно                               
                }
                 a.Del(0);
                a.Dob(size, strig);   // добавляю в конец думаю что логично, т.к если нужно в начало стоит воспользовать индексатором!!!!

                Console.WriteLine(a.Print());
            }                                           
            catch (IndexOutOfRangeException e)  // решил ловить исключение выход за границы по всей программе. делал исключение самостояятельно оно работает 
            {
                Console.WriteLine("Ошибочкааа");
            }
        }
    }
}

