using System;
using MyApp.EnumDemo;

// // Integer (Integral) types
// byte b = 255;               // 8-bit unsigned
// sbyte sb = -128;            // 8-bit signed
// short s = -32768;           // 16-bit signed
// ushort us = 65535;          // 16-bit unsigned
// int i = 2147483647;         // 32-bit signed
// uint ui = 4294967295;       // 32-bit unsigned
// long l = 9223372036854775807L; // 64-bit signed
// ulong ul = 18446744073709551615UL; // 64-bit unsigned

// Console.WriteLine("Integer types:");
// Console.WriteLine($"byte: {b}, sbyte: {sb}");
// Console.WriteLine($"short: {s}, ushort: {us}");
// Console.WriteLine($"int: {i}, uint: {ui}");
// Console.WriteLine($"long: {l}, ulong: {ul}");

// // Floating-point types
// float f = 3.14f;            // 32-bit floating-point
// double d = 3.14159265358979; // 64-bit floating-point
// decimal m = 3.141592653589793238m; // 128-bit decimal (high precision)

// Console.WriteLine("\nFloating-point types:");
// Console.WriteLine($"float: {f}");
// Console.WriteLine($"double: {d}");
// Console.WriteLine($"decimal: {m}");

// // bool
// bool isActive = true;
// bool isFalse = false;
// Console.WriteLine($"bool: {isActive}");
// Console.WriteLine($"bool: {isFalse}");

// // char (single Unicode character)
// char letter = 'A';
// Console.WriteLine($"char: {letter}");
// Console.WriteLine($"char Unicode code point: {(int)letter}");

class Program
{
    static void Main()
    {
        EnumDemoRunner.Run();
    }
}
