using System;
using System.IO;


namespace AssignmentFILEclass;

internal class Program
{
    static void Main(string[] args)
    {
        // File.Create("student.txt");
        // Console.WriteLine("File Created successfully");


        // using (FileStream fs = File.Create("student.txt"))
        // {
        //     Console.WriteLine("File Created Successfully");
        // }




        // string data = "Name: Durga\nAge: 24\nCity: Pune";
        // File.WriteAllText("student.txt", data);
        //
        // Console.WriteLine("Data Written  Successfully");
        
        
        
        // string data = File.ReadAllText("student.txt");
        // Console.WriteLine(data);
        
        // File.AppendAllText("student.txt","\nCourse: PG-DAC");
        // Console.WriteLine(File.ReadAllText("student.txt"));
        
        
        
        string[] lines = File.ReadAllLines("student.txt");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
        Console.WriteLine(lines[0]);
        Console.WriteLine(lines[1]);
        
        
        
        File.Move("student.txt", "newstudent.txt");

        Console.WriteLine("File moved successfully!");
        
        
        
        // FOR DELETE
        
        if (File.Exists("newstudent.txt"))
        {
            File.Delete("newstudent.txt");

            Console.WriteLine("File deleted successfully!");
        }
    }
}