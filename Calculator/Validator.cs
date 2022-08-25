using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Validator
{
    Calculate calculate = new Calculate();

    public void HandleCalculation(string choice)
    {

        switch (choice)
        {
            case "a":
                calculate.DoAddition();
                break;
            case "d":
                calculate.DoDivision();
                break;
            case "s":
                calculate.DoSubstraction();
                break;
            case "m":
                calculate.DoMultiplication();
                break;
            case "r":
                calculate.DoDivisionAndReminider();
                break;
        }
    }

    public void OperationVidlation(string choice, out bool success)
    {
        success = true;
        switch (choice)
        {
            case "a":
                break;
            case "d":
                break;
            case "s":
                break;
            case "m":
                break;
            case "r":
                break;
            default:
                success = false;
                break;
        }
    }

    public bool ValidateInput(string input, out double data)
    {
        var success = double.TryParse(input, out data);

        return success;
    }
}
