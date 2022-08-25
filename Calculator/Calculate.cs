using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculate
{
    public static double Input1 { get; set; }
    public static double Input2 { get; set; }

    public void DoAddition()
    {
        var ans = Input1 + Input2;

        Console.WriteLine($"\n{Input1} + {Input2} = {ans}");
    }
    public void DoSubstraction()
    {

        var ans = Input1 - Input2;

        Console.WriteLine($"\n{Input1} - {Input2} = {ans}");
    }

    public void DoMultiplication()
    {

        var ans = Input1 * Input2;

        Console.WriteLine($"\n{Input1} * {Input2} = {ans}");
    }

    public void DoDivision()
    {
        var ans = Input1 / Input2;

        if (Input1 > 0 && Input2 == 0)
        {
            Console.WriteLine($" {Input1} Cannot be divided by {Input2}");
        }
        else
            Console.WriteLine($"\n{Input1} / {Input2} = {ans}");
    }

    public void DoDivisionAndReminider()
    {
        var ans = Input1 / Input2;
        var rem = Input1 % Input1;
        if (Input1 > 0 && Input2 == 0)
        {
            Console.WriteLine($" {Input1} Cannot be divided by {Input2}");
        }
        else
            Console.WriteLine($"\n{Input1} / {Input1} = {ans} remenider {rem}");
    }
}
