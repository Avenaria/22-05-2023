using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_05_2023
{
    internal class Program
    {
        static void Print(string text, int[] arr)
        {
            Console.WriteLine(text + ":");
            foreach (int i in arr)
            {
                Console.Write(i + "");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //int a =  int.Parse(Console.ReadLine());//ввод с консоли  , приведение к значению инт 1 метод// любой обьект перенаправляет в строку 
            //int b = Convert.ToInt32(Console.ReadLine()) ;// обращение к классу для конвертации принятой информации 
            //if( a>b)
            //{
            //    int temp = a;
            //    a = b;
            //    b = temp;
            //}
            //for(int i = a; i <=b ; i++)
            //{
            //    if (i % 2 == 0) { Console.WriteLine(i);// вывод в консоль в одну строку WriteLine, с переносом на новую строку 

            //    }
            //}
            //Console.ReadKey();//тормозит консоль WriteLine(i+"\n") дополнительный отступ или передать пустой 

            //обьявление массива
            //одномерный тип_элемента[] имя массива
            int[] intarr;
            string[] arr = new string[10];//инициализация массива
            intarr = new int[3];//инициализация массива

            //инициализация массива
            int[] intarey = new int[10] { 5, 3, 3, 6, 6, 10, 5, 5, 7, 9 };
            int[] arr2 = new int[] { 5, 6, 8, };//программа сама решит размер массива исходя из занесенных данных
            int[] arr3 = { 6, 9, 6, 8, };//программа сама решит размер массива исходя из занесенных данных
            for (int i = 0; i < intarey.Length; i++)
            {
                Console.WriteLine(intarey[i] + " ");//вывод массива на экран 
            }

            foreach (int i in arr2)
            {

                Console.WriteLine(arr[i] + " ");
                //пройтись по коллекции от начала до конца, i не индекс массива а элемент,то есть само число 
                //значение поменять нельзя, только чтение

            }
            /*
             GetLengt()//количесво элементов массива, по заддоному измерению
            CopyTo()// копирует все лементы одного в другой начиная с заданной позиции
            Сlone() поверхтностоное копирование массива, копия возвращается в качестве Object[]// базовый класс от которого наследуются все.
            Array.BinarySesrch() -поиск необходимого элемента в массиве или диапозоне, двоичный поиск 

             Array.Clear()-удаляет элементы и задает значения по умолчанию, будут запонены 0
            Array.IndexOff-значение первого элемента 
             Array.LastIndexOff- поиск происходит с конца 
            Array.Resize( изменить размер массива )Reverse ( переворачивает масив) Sort(соритирует по возрастанию)
             length- возвращает  размер массива
            Rank- количество измерений массива
             */
            //много мерные масивы 1 тип 
            //количество запятых обозначаетр двумерность массива
            int[] arr4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Print("Mass Arr4", arr4);
            int[] temp = (int[])arr4.Clone();
            Array.Reverse(arr4, 3, 4);

            Print("Mass Arr4 после переворота ", arr4);
            arr4 = temp;


            int[] Arr2 = new int[20];
            Print("Массива 2", Arr2);
            arr4.CopyTo(Arr2, 5);
            Print("Массива 2 после копирования ", Arr2);
            Array.Clear(Arr2, 0, Arr2.GetLength(0));//нужно передать размер массива
            Print("Массива 2 после Чистки  ", Arr2);
            Array.Resize(ref Arr2, 10);// реф аналог ссылки на массив
            Print("Массива 2 после изменения массива   ", Arr2);
            Arr2 = new int[] { 5, 8, 9, 12, 7 };
            Array.Sort(Arr2);
            Print("Массива 2 после сортировки  массива   ", Arr2);
            Console.WriteLine("Макс -" + Arr2.Max());

            //Зубчатый массив
            int[][] r = new int[3][];
            r[0] = new int[5];
            r[1] = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(r[1][2]);//вывести контретный  эелемент зубчатого массива, 1  указывается измеренение, 2 индек элемента
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] b = new int[,] { { 1, 5, 8 }, { 8, 9, 7 } };
            int [][]a2 = new int[3][]//инициализация зубчатого массива
            {
                new int[3] { 1, 2, 3 },
                new int[] {6,9},
                new int [] {7}

            };
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            foreach(int i in b)
            {
                Console.WriteLine(i);
            }
            for(int i = 0; i < a2.Length; i++)
            {
                foreach(int j in a2[i])
                {
                    Console.WriteLine(j+ " ");
                  
                }
            }
       
        }
    }
}

