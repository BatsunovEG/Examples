﻿int a = 4;
int b = 2;
int c = 7;
int d = 10;
int e = 8;
int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);