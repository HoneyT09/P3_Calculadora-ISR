using System;
using MyCompany.Intranet.Core.Entities;
using MyCompany.Intranet.Core.Enums;
using MyCompany.Intranet.Core.Managers;
using MyCompany.Intranet.Core.Services;


namespace MyCompany.Intranet.Console;

public static class Program {
    public static void Main(string[] args){

        float sueldo = 0;

        System.Console.WriteLine("Sueldo");
        Single.TryParse(System.Console.ReadLine(), out sueldo);

        var person = new Person{sueldo = sueldo};

        var service = new ISRService();
        var managers = new ISRManager(service);

        ISR isr = managers.Calculator(person);

        System.Console.WriteLine($"Total a pagar ${isr.Impuestos}");

    }
}