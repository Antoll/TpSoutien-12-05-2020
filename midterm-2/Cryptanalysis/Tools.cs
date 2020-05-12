using System;
using System.Collections.Generic;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        int res = -1;
        if (c >= 65 && c <= 90)
        {
            res = Convert.ToInt32(c) - 65;
        }

        return res;
    }

    public static char RotChar(char c, int n)
    {
        char res = 'e';
        if (c <= 65 && c >= 90)
        {
            if (Convert.ToInt32(c) + n <= 90)
            {
                res = Convert.ToChar(Convert.ToInt32(c) + n);
            }
            else
            {
                int r = 90 - Convert.ToInt32(c);
                res = Convert.ToChar(64 + (n - r));
            }
        }

        if (c >= 97 && c <= 122)
        {
            if (Convert.ToInt32(c) + n <= 122)
            {
                res = Convert.ToChar(Convert.ToInt32(c) + n);
            }
            else
            {
                int r = 122 - Convert.ToInt32(c);
                res = Convert.ToChar(96 + (n - r));
            }
        }

        return res;
    }

    public static int[] Histogram(string str)
    {
        int[] hist = new int[26];
        int le = str.Length;
        for (int i = 0; i <= le ; i++)
        {
            if (LetterIndex(str[i]) != -1)
            {
                hist[LetterIndex(str[i])] += 1;
            }
        }

        return hist;
    }
    
    public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
