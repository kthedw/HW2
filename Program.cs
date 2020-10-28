using System;
using System.IO;

class Employee
{
    public static void Main()
    {
        string path = @"c:\_kthedw\VS_projects\HW2\Employee.csv";
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}