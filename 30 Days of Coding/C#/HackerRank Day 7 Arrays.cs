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
        //commented code is for performing the operations for the dynamic number of arrays.
        /*int numOfArray = Conver.ToInt32(Console.ReadLine().Trim());
        for(int i = 0;i<=numOfArray;i++)
        {
           int n = Convert.ToInt32(Console.ReadLine().Tim());
           string[] arr_temp[] = Console.ReadLine().Split(' ');
           array(arr_temp,n);
        } */

        int n = Convert.ToInt32(Console.ReadLine().Trim());		//Taking Number of elements for Array
        string[] arr_temp = Console.ReadLine().Split(' ');      //Taking elements of Array
        array(arr_temp,n);
    }
	//Function to print array in reverse.
    public static void array(string[] tmp_arr,int n)
    {
        int[] arr = Array.ConvertAll(tmp_arr,Int32.Parse);
        for (var i = n - 1; i > -1; i--)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
