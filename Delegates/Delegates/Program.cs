using Delegates;
using System;

var ClassFuncion = new ClassFuncion();

Delegado suma = ClassFuncion.Sumar;

Console.WriteLine($"El resultado es {suma(1,2)}");

public delegate string Delegado(int arg1, int arg2);

