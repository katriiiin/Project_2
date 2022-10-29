using System;
using System.IO;


namespace Control_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("input.txt");
             string[] a = f.ReadToEnd().Split('\n');

             string[,] patr ={
            {"1", "0", a[0]},
            {"2", "1", a[1]},
            {"3", "2", a[2]},
            {"4", "2", a[3]},
            {"5", "3", a[4]},
            {"6", "3", a[5]},
            {"7", "3", a[6]},
            {"8", "1", a[7]},
            {"9", "2", a[8]},
            {"10", "2", a[9]},
            {"11", "2", a[10]},
            {"12", "3", a[11]},
            {"13", "1", a[12]},
            };
            Console.WriteLine("Входные даные:");
            foreach (string str in a)
                Console.WriteLine(str);
            Console.WriteLine("Выходные данные:");

            for (int i = 0; i < patr.GetLength(0); i++)
            {
                Console.WriteLine(StrokaArr(patr[i, 1], patr[i, 2], patr));
            }
            Console.ReadKey();
        }
        static public string StrokaArr(string id_patr, string strName, string [,] patr)//метод функция с рекурсией
        {
            if (id_patr == "0") return strName;
            else
            {
                for (int i = 0; i < patr.GetLength(0); i++)
                {
                    string id_patr_patr = "0";
                    if (patr[i, 0] == id_patr)
                    {
                        id_patr_patr = patr[i, 1];
                        strName = "-" + StrokaArr(id_patr_patr, strName,patr);
                    }
                }
            }
            return strName;
        }
    }
}