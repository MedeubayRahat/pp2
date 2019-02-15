using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string aaa = "Hello!";

            string path2 = @"C:\Users\PChelper\Desktop\qwerty\output.txt";
            StreamWriter file = new StreamWriter(@"C:\Users\PChelper\Desktop\qwerty\qwert\Test.txt");
            file.Write(aaa);
            file.Close();
            string path = @"C:\Users\PChelper\Desktop\qwerty\qwert\Test.txt";
            if (File.Exists(path2))
            //Проверяем есть ли существующий файл , типо , Метод Move нельзя использовать для перезаписи существующего файла.
            //Exists(file): определяет, существует ли файл
            {
                File.Delete(path2);     //Если есть ,то удаляем.
                File.Move(path, path2);    //После файл с path перемещяем в path2
                                           //Move: перемещает файл в новое место

            }
        }
    }
}
