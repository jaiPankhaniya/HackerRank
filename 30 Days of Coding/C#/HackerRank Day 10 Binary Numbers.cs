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
        Console.WriteLine(BinaryNumbers(n));
    }
    private static int BinaryNumbers(int n)
    {
        var sum = 0;
        var max = 0;
        while(n>0)
        {
            if(n%2==1)
            {
                sum++;
                if(sum>max)
                {
                    max=sum;
                }
            }
            else
            {
                sum=0;
            }
            n/=2;            
        }
        return max;
    }
}
