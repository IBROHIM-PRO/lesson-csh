int x1 = 3, x2 = 2, x3 = 7, y1 = 4, y2 = 12, y3 = 6;
double a = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2-y1),2));
double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
double p = (a + b + c) / 2;
double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
Console.WriteLine($"P = {p}; s = {s}"); 