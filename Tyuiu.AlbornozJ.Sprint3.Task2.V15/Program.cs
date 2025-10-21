using Tyuiu.AlbornozJ.Sprint3.Task2.V15.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");


double value = 0.5;
int startValue = 1;
int stopValue = 20;

Console.WriteLine("Переменная a = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");


Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
Console.ReadKey();