using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Commands
{
    public void Show(string value)
    {
        Console.WriteLine($"\n{value}\n");
    }

    public void ShowStartingContent()
    {
        Console.WriteLine("............Calculator App.................");
    }

    public void ShowOperationOptions()
    {

        Console.WriteLine("Select Operation");

        Console.WriteLine("\n a: Addition,\n m: Multiplicaction,\n s:Substraction,\n d: Division,\n r: Divide with Remenider \n");
    }
}
