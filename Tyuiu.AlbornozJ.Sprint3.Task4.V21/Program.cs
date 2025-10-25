using Tyuiu.AlbornozJ.Sprint3.Task4.V21.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение ряда = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();
