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
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        string[] arr_temp = Console.ReadLine().Split(' ');
        array(arr_temp,n);
    }
    public static void array(string[] tmp_arr,int n)
    {
        int[] arr = Array.ConvertAll(tmp_arr,Int32.Parse);
        for (var i = n - 1; i > -1; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
