using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomework
{
    [Serializable]
    class Book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book(string name, int price, string author, int year)
        {
            Name = name; Price = price; Author = author; Year = year;
        }

        public void Show()
        {
            Console.WriteLine($"Название: {Name}" +
                $"\nАвтор: {Author}" +
                $"\nГод: {Year}" +
                $"\nЦена: {Price} \n");
        }
    }
}
/*1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. 
 * Создать коллекцию элементов Book и заполнить тестовыми данными. С помощью класса BinaryFormatter сохранить 
 * состояние приложения в двоичный файл.*/
