using System;
using System.Numerics;

namespace LAB3_1;

public static class Program
{
    static void Main(string[] args)
    {
        var num1 = 1.2d;
        var num2 = 1f;
        System.Console.WriteLine($"num1 + num2 = {num1} + {num2} = {Addition(num1, num2)}");
        System.Console.WriteLine($"num1 - num2 = {num1} - {num2} = {Subtraction(num1, num2)}");
        System.Console.WriteLine($"num1 x num2 = {num1} x {num2} = {Multiplication(num1, num2)}");
        System.Console.WriteLine($"num1 : num2 = {num1} : {num2} = {Division(num1, num2)}");
    }

    static T Addition<T>(T num1, T num2) where T : IComparable, INumberBase<T>
    {
        dynamic _num1 = num1;
        dynamic _num2 = num2;
        return _num2 + _num1;
    }

    static T Subtraction<T>(T num1, T num2) where T : IComparable, INumberBase<T>
    {
        dynamic _num1 = num1;
        dynamic _num2 = num2;
        return _num2 - _num1;
    }

    static T Multiplication<T>(T num1, T num2) where T : IComparable, INumberBase<T>
    {
        dynamic _num1 = num1;
        dynamic _num2 = num2;
        return _num2 * _num1;
    }

    static T Division<T>(T num1, T num2) where T : IComparable, INumberBase<T>
    {
        dynamic _num1 = num1;
        dynamic _num2 = num2;
        return (_num2 is 0) ? default(T) : _num2 / _num1;
    }
}