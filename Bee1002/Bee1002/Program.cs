﻿using System;
using System.Globalization;

double n = 3.14159;
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double area = n * Math.Pow(raio, 2);

Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
