using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Book first = new Book( "Унесенные ветром", 5000, "Маргарет Митчелл", 2017 );
            Book second = new Book( "Записки юного врача", 4000, "Михаил Булгаков", 2013 );
            List<Book> list = new List<Book>();
            list.Add(first); list.Add(second);

            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream fs = File.Create("Books.txt"))
            {
                formatter.Serialize(fs, list);
            }

            using(FileStream fs = new FileStream("Books.txt", FileMode.Open))
            {
                List<Book> newList = (List<Book>)formatter.Deserialize(fs);

                foreach (var book in newList)
                {
                    book.Show();
                }
            }
        }
    }
}
/*1.	Объявить в консольном приложении класс Book с полями: название, стоимость, автор, год. 
 * Создать коллекцию элементов Book и заполнить тестовыми данными. С помощью класса BinaryFormatter сохранить 
 * состояние приложения в двоичный файл.*/

/*2.	На основании задания 1 восстановить состояние приложения из двоичного файла.*/
