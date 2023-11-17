using System;

namespace Convertie_binara
{
    internal class Program
    {
        static string Above9(long a)
        {
            string L = "A";
            switch (a)
            {
                case 0: L = "0"; break;
                case 1: L = "1"; break; 
                case 2: L = "2"; break;
                case 3: L = "3"; break;
                case 4: L = "4"; break;
                case 5: L = "5"; break;
                case 6: L = "6"; break;
                case 7: L = "7"; break;
                case 8: L = "8"; break;
                case 9: L = "9"; break;  
                case 10: L = "A"; break;
                case 11: L = "B"; break;
                case 12: L = "C"; break;
                case 13: L = "D"; break;
                case 14: L = "E"; break;
                case 15: L = "F"; break;
            }
            return L;
        }
        static sbyte Convert(char a)
        {
            sbyte L = 0;
            switch (a)
            {
                case (char)48: L = 0; break;
                case (char)49: L = 1; break;
                case (char)50: L = 2; break;
                case (char)51: L = 3; break;
                case (char)52: L = 4; break;
                case (char)53: L = 5; break;
                case (char)54: L = 6; break;
                case (char)55: L = 7; break;
                case (char)56: L = 8; break;
                case (char)57: L = 9; break;
                case (char)65: L = 10; break;
                case (char)66: L = 11; break;
                case (char)67: L = 12; break;
                case (char)68: L = 13; break;
                case (char)69: L = 14; break;
                case (char)70: L = 15; break;
            }
            return L;
        }
        static void Main()
        {
            Console.WriteLine("Introduceti 2 baze");
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul ");
            if (b1 < b2 && b1 < 10)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                        long b10 = 0;
                        int pu = 0, p = 1;
                        while (n != 0)
                        {
                            b10 += n % 10 * (long)Math.Pow(b1, pu);
                            n /= 10;
                            pu++;
                        }
                        long bi10 = b10;
                        while (bi10 != 0)
                        {
                            p++;
                            bi10 /= b2;
                        }
                        int p1 = p;
                        string[] i = new string[100];
                        while (b10 != 0)
                        {
                            i[p - 1] = $"{Above9(b10 % b2)}";
                            p--;
                            b10 /= b2;
                        }
                        Console.Write($"Numarul {n} din baza {b1} in baza {b2} este: ");
                        for (p = 0; p < p1; p++)
                            Console.Write(i[p]);
                        Console.WriteLine();
                }
                else
                {
                   long b10 = 0;
                   double bii10 = 0;
                   int pu = 0, p = 1, pu1 = 0;
                   n1 -= n;
                   while ((float)n1 != (long)n1)
                   {
                        pu1--;
                        n1 *= 10;
                   }
                    while (pu1 != 0)
                   {
                        bii10 += ((long)n1) % 10 * Math.Pow(b1, pu1);
                        n1 = (long)n1/10;
                        pu1++;
                   }
                   while (n != 0)
                   {
                       b10 += n % 10 * (long)Math.Pow(b1, pu);
                       n /= 10;
                       pu++;
                   }
                    bii10 += b10;
                   long bi10 = (long)bii10;
                    float biii10 = (float)((float)bii10 - (int)bii10);
                    while (bi10 != 0)
                   {
                       p++;
                       bi10 /= b2;
                   }
                   int p1 = p;
                   string[] i = new string[100];
                   while (b10 != 0)
                   {
                       i[p - 1] = $"{Above9(b10 % b2)}";
                       p--;
                       b10 /= b2;
                   }
                    p = 1;
                   string[] ii = new string[100];
                    while ((biii10 != 0 && p < 30) && biii10 != 0)
                    {
                        ii[p] = $"{Above9((long)(biii10 * b2))}";
                        p++;
                        biii10 =(biii10 * b2) - (int)(biii10 * b2);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                       Console.Write(i[p]);
                   Console.Write(".");
                   for (p = 0; p < p2; p++)
                       Console.Write(ii[p]);
                   Console.WriteLine();
                }
            }    
            if (b1 > 10)
            {
                string s = Console.ReadLine();
                if (s.Contains("."))
                {
                    Console.WriteLine(s);
                    double b10 = 0;
                    int pu = 0, p = 1;
                    bool t = false;
                    foreach (char c in s)
                    {
                        if (c == 46)
                        {
                            t = true;
                        }
                        if (t) break;
                        else pu++;
                    }
                    pu--;
                    foreach (char c in s)
                    {
                        if (c == 46) continue;
                        b10 += Convert(c) * (Math.Pow(b1, pu));
                        pu--;
                    }
                    long bi10 = (long)b10, bii10=bi10;
                    b10 = b10 - bi10;
                    while (bi10 != 0)
                    {
                        p++;
                        bi10 /= b2;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (bii10 != 0)
                    {
                        i[p - 1] = $"{Above9(bii10 % b2)}";
                        p--;
                        bii10 /= b2;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((b10 != 0 && p < 20) && b10 != 0)
                    {
                        ii[p] = $"{Above9((long)(b10 * b2))}";
                        p++;
                        b10 = (b10 * b2) - (int)(b10 * b2);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {s} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
                else
                {
                    long b10 = 0;
                    int pu = s.Length - 1, p = 1;
                    foreach (char c in s)
                    {
                        b10 += Convert(c) * (long)(Math.Pow(b1, pu));
                        pu--;
                    }
                    long bi10 = b10;
                    while (bi10 != 0)
                    {
                        p++;
                        bi10 /= b2;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (b10 != 0)
                    {
                        i[p - 1] = $"{Above9(b10 % b2)}";
                        p--;
                        b10 /= b2;
                    }
                    Console.Write($"Numarul {s} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.WriteLine();
                }
            }
            if (b1 < b2 && b1 == 10)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                int p = 1;
                long bi10 = n;
                while (bi10 != 0)
                {
                    p++;
                    bi10 /= b2;
                }
                int p1 = p;
                string[] i = new string[100];
                while (n != 0)
                {
                    i[p - 1] = $"{Above9(n % b2)}";
                    p--;
                    n /= b2;
                }
                Console.Write($"Numarul {n} din baza {b1} in baza {b2} este: ");
                for (p = 0; p < p1; p++)
                    Console.Write(i[p]);
                Console.WriteLine();
                }
                else
                {
                    int p = 1;
                    float n3 = (float)((float)n1 - (int)n1);
                    long n4 = n;
                    while (n4 != 0)
                    {
                        p++;
                        n4 /= b2;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (n != 0)
                    {
                        i[p - 1] = $"{Above9(n % b2)}";
                        p--;
                        n /= b2;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((n3 != 0 && p < 20) && n3 != 0)
                    {
                        ii[p] = $"{Above9((long)(n3 * b2))}";
                        p++;
                        n3 = (n3 * b2) - (int)(n3 * b2);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
            }
            if (b1 > b2 && b1 < 10)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                    long b10 = 0, p = 1, nr = 0;
                    int pu = 0;
                    while (n != 0)
                    {
                        b10 += n % 10 * (long)(Math.Pow(b1, pu));
                        n /= 10;
                    }
                    while (b10 != 0)
                    {
                        nr = (b10 % b2) * p + nr;
                        p *= 10;
                        b10 /= b2;
                        Console.WriteLine(b10);
                    }
                    Console.WriteLine($"Numarul {n} din baza {b1} in baza {b2} este: {nr}");
                }
                else
                {
                    long b10 = 0;
                    double bii10 = 0;
                    int pu = 0, p = 1, pu1 = 0;
                    n1 -= n;
                    while ((float)n1 != (long)n1)
                    {
                        pu1--;
                        n1 *= 10;
                    }
                    while (pu1 != 0)
                    {
                        bii10 += ((long)n1) % 10 * Math.Pow(b1, pu1);
                        n1 = (long)n1 / 10;
                        pu1++;
                    }
                    while (n != 0)
                    {
                        b10 += n % 10 * (long)Math.Pow(b1, pu);
                        n /= 10;
                        pu++;
                    }
                    bii10 += b10;
                    long bi10 = (long)bii10;
                    float biii10 = (float)((float)bii10 - (int)bii10);
                    while (bi10 != 0)
                    {
                        p++;
                        bi10 /= b2;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (b10 != 0)
                    {
                        i[p - 1] = $"{b10 % b2}";
                        p--;
                        b10 /= b2;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((biii10 != 0 && p < 30) && biii10 != 0)
                    {
                        ii[p] = $"{(long)(biii10 * b2)}";
                        p++;
                        biii10 = (biii10 * b2) - (int)(biii10 * b2);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
            }
            if (b1 > b2 && b1 == 10)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = n1;
                long n = (long)n1;
                if (n1 == n)
                {
                    long nr = 0, p = 1;
                    while (n != 0)
                    {
                        nr = (n % b2) * p + nr;
                        p *= 10;
                        n /= b2;
                    }
                    Console.WriteLine($"Numarul {n2} din baza {b1} in baza {b2} este: {nr}");
                }
                else
                {
                    int p = 1;
                    float n3 = (float)((float)n1 - (int)n1);
                    long n4 = n;
                    while (n4 != 0)
                    {
                        p++;
                        n4 /= b2;
                    }
                    int p1 = p;
                    string[] i = new string[100];
                    while (n != 0)
                    {
                        i[p - 1] = $"{n % b2}";
                        p--;
                        n /= b2;
                    }
                    p = 1;
                    string[] ii = new string[100];
                    while ((n3 != 0 && p < 30) && n3 != 0)
                    {
                        ii[p] = $"{(long)(n3 * b2)}";
                        p++;
                        n3 = (n3 * b2) - (int)(n3 * b2);
                    }
                    int p2 = p;
                    Console.Write($"Numarul {n2} din baza {b1} in baza {b2} este: ");
                    for (p = 0; p < p1; p++)
                        Console.Write(i[p]);
                    Console.Write(".");
                    for (p = 0; p < p2; p++)
                        Console.Write(ii[p]);
                    Console.WriteLine();
                }
            }
        }
    }
}
