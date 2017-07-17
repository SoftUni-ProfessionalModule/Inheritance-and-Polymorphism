﻿namespace Manking
{
    using System;

    public class Manking
    {
        public static void Main()
        {
            var studentInfo = Console.ReadLine().Split();
            var workerInfo = Console.ReadLine().Split();

            try
            {
                var student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                var worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}