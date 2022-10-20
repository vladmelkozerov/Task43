// Задача 43 Устройство для определения точек пересечения 2 прямых
Console.Clear();
double x=0;
double y=0;
Console.WriteLine("Введите число k1");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2=Convert.ToDouble(Console.ReadLine());
if (k1==k2)
    Console.WriteLine("Прямые параллельны");
else 
    {
    x=(b2-b1)/(k1-k2) ;
    y=k1*x+b1;
    Console.WriteLine("Точка с координатами ("+x+", "+y+") является пересечением прямых y="+k1+"*x+"+b1+" и y="+k2+"*x+"+b2);  
    }
