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

public class Solution
{
    public static void Main(string[] args)
    {
        int input = Convert.ToInt32(Console.ReadLine().Trim());
        calcTable(input);
    }
    public static void calcTable(int input)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(input + " x " + i + " = " + (input * i));
        }
    }
}
