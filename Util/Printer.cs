using System;
using System.Collections.Generic;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool.Util

{
    public class Printer
    {
        public static void PrintArrays(List<Course> coursePrint)
        {
            foreach (var item in coursePrint)
            {
                WriteTittle(item.NameCourse);
                foreach (var std in item.Students)
                {
                    WriteLine(std.NameStudent);
                    foreach (var tst in std.Test)
                    {
                        string printSubject = $"Subject Name: {tst.SubjectName}";
                        DrawLine(printSubject.Length);
                        WriteLine(printSubject);
                        WriteLine($"Test: {tst.NameTest}, Score: {tst.Score}");
                    }
                }
            }
        }

        public static void DrawLine(int sizeLine = 10)
        {
            WriteLine("".PadLeft(sizeLine, '='));
        }

        public static void WriteTittle(string title)
        {
            var titlePrint = $"\n| {title} |";
            DrawLine(titlePrint.Length);
            WriteLine(titlePrint);
            DrawLine(titlePrint.Length);
        }

        public static void Beep(int hz = 2000, int timeBeep = 1000, int quantity = 3)
        {
            while (quantity > 0)
            {
                Console.Beep(hz, timeBeep);
                quantity--;
            }
        }

        public static void BeepInitial()
        {

            Console.Beep();

        }

    }

}

