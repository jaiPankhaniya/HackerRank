using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    public static void Main(string[] args)
    {
        printTableWithFor(Convert.ToInt32(Console.ReadLine().Trim()));
        // printTableWithWhile(Convert.ToInt32(Console.ReadLine().Trim()));
        // printTableWithDoWhile(Convert.ToInt32(Console.ReadLine().Trim()));
    }
    public static void printTableWithFor(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
    public static void printTableWithWhile(int n)
    {
        int i=1;
        while(i <= 10)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
            i++;
        }
    }
    public static void printTableWithDoWhile(int n)
    {
        int i=0;
        do
        {
            i++;
            if(i>0 && i<=10)
                  Console.WriteLine(n + " x " + i + " = " + (n * i));

        }while(i <= 10);
    }
}
