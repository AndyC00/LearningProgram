﻿using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using LearningProgram;
using System.Collections;
using System.Collections.Generic;

class Program
{
    enum Days
    {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
    }

    static void Main(string[] arg)
    {
    //list & arraylist:
    someLists myList = new someLists();
    Console.WriteLine(myList.list01[0]);
    Console.WriteLine(myList.list01[7]);
    myList.list01.Add("The 8th element");
    Console.WriteLine(myList.list01[8]);
    int count = myList.list01.Count;
    Console.WriteLine("There are " + count + " elements in this list");
    myList.list01.RemoveAt(1);
    myList.list01.Remove(5);
    myList.list01.Insert(1, "the second element");

    int count2 = myList.list02.Count;
    Console.WriteLine("The second list has " + count2 + " elements");

    //loop:
    foreach (var element in myList.list01)
    {
        Console.Write(element);
        Console.Write("\t");
    }
    Console.WriteLine(" ");

    foreach (object item in myList.list02)
    {
        Console.Write(item);
        Console.Write("\t");
    }
    Console.Write("\n");
    
    //sorting the list:
    List<float> listFloat = new List<float>();
    for(int i = 0; i < count2; i++)
    {
        if(myList.list02[i] is int)
        {
            listFloat.Add((float)myList.list02[i]);
        }
        else if(myList.list02[i] is float)
        {
            listFloat.Add((float)myList.list02[i]);
        }
    }
    listFloat.Sort();
    foreach(float item in listFloat)
    {
        Console.Write(item + "\t");
    }

    //enum:
        int x = (int)Days.Sunday;
        int y = (int)Days.Friday;
        Console.WriteLine("Sun = {0}",x);
        Console.WriteLine("Fri = {0}",y);
        Console.WriteLine("\n");

    //class:
        Person someone = new Person();
        someone.ID = 1;
        someone.Name = "Lily";
        someone.Age = 20;

        string msg = "Do you want to hire me?";
        string judge = "superman";
        someone.Say(judge, msg);

        Console.WriteLine("\n");

    //sub-class:
        Student stu1 = new Student();
        stu1.Name = "Micheal";
        stu1.Age = 16;
        stu1.ID = 2;
        stu1.Major = "Math";
        stu1.Study();
        string University = "AUT";
        stu1.Study(University);
        stu1.Study("UoA");
        stu1.Say("Batman", "Are you clown?");

        Console.WriteLine("\n");

    //Interface:
        IUser player1 = new user();
        player1.Name = "A random user 001";
        player1.Age = 100;
        player1.aMethod();

        Console.WriteLine("\n");

    //a simple calculator:
    Console.WriteLine("Please enter 2 integers and a operator");
    Console.WriteLine("Press ‘“’Enter‘”’ to input the next character");

    float a = Convert.ToSingle(Console.ReadLine());
    float b = Convert.ToSingle(Console.ReadLine());
    string op = Convert.ToString(Console.ReadLine());

    //switch:
    switch (op)
    {
        case "+":
            Console.WriteLine("The result is " + (a+b));
            break;
        case "-":
            Console.WriteLine("The result is " + (a-b));
            break;
        case "*":
            Console.WriteLine("The result is " + (a*b));
            break;
        case "/":
            if(b==0)
            {
                Console.WriteLine("Error! The denominator can not be 0");
            }
            else
            {
                Console.WriteLine("The result is " + (a/b));
            }
            break;
        case "%":
            Console.WriteLine("The result is " + (a%b));
            break;
        default:
            break;
    }

    Console.ReadLine();
    }
}