﻿Console.Clear();

Console.WriteLine("Введите значение К1");

double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение B1");

double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение К2");

double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение B2");

double b2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

double y = k1 * x + b1;

Console.WriteLine($"Координаты пересечения ({x}, {y})");
