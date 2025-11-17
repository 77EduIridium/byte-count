// Суть этого задания - показать работу оператора sizeof в C#.
// sizeof возвращает размер типа данных в байтах.
// Это полезно для понимания того, сколько памяти занимает каждая переменная.

// Примеры для целочисленных типов:
Console.WriteLine("Размеры: sbyte, byte");
Console.WriteLine(sizeof(sbyte)); // 1 байт, знаковый (-128..127)
Console.WriteLine(sizeof(byte));  // 1 байт, беззнаковый (0..255)

Console.WriteLine("Размеры: short, ushort");
Console.WriteLine(sizeof(short));  // 2 байта, знаковый
Console.WriteLine(sizeof(ushort)); // 2 байта, беззнаковый

Console.WriteLine("Размеры: int, uint");
Console.WriteLine(sizeof(int));   // 4 байта, знаковый
Console.WriteLine(sizeof(uint));  // 4 байта, беззнаковый

Console.WriteLine("Размеры: long, ulong");
Console.WriteLine(sizeof(long));   // 8 байт, знаковый
Console.WriteLine(sizeof(ulong));  // 8 байт, беззнаковый

// Примеры для чисел с плавающей точкой:
Console.WriteLine("Размеры: float, double, decimal");
Console.WriteLine(sizeof(float));   // 4 байта, ~7 знаков точности
Console.WriteLine(sizeof(double));  // 8 байт, ~15 знаков точности
Console.WriteLine(sizeof(decimal)); // 16 байт, ~28 знаков точности
