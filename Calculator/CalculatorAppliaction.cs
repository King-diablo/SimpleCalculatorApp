using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorAppliaction
    {
        public static int AmountUsed;

        Input input = new Input();
        Commands command = new Commands();
        Validator validator = new Validator();

        public bool runApp = true;
        public bool success = false;
        public string quitInput = "";
        public void StartApplication()
        {
            var input1 = 0d;
            var input2 = 0d;
            var choice = "a";

            while (runApp)
            {
                Console.WriteLine($"{DateTime.Now.ToString()}\n");
                AmountUsed++;

                Console.WriteLine($"Calculator Was Used {AmountUsed} Times\n");
                command.ShowStartingContent();

                command.Show("Input A Number");
                success = validator.ValidateInput(input.InputData(), out input1);
                RestartCheck("Not A Number");

                command.ShowOperationOptions();
                choice = input.InputData();
                validator.OperationVidlation(choice, out success);
                RestartCheck("Wrong Command");


                command.Show("Input Another  Number");
                success = validator.ValidateInput(input.InputData(), out input2);
                RestartCheck("Not A Number");

                Calculate.Input1 = input1;
                Calculate.Input2 = input2;


                validator.HandleCalculation(choice);

                HandleApplicationQuitting();

                Console.Clear();
            }
        }

        private void HandleApplicationQuitting()
        {
            command.Show("Y/N to Quit");

            quitInput = input.InputData();

            if (quitInput == "Y" || quitInput == "y")
            {
                Console.Clear();
                Console.WriteLine("Last Result\n");
                foreach (var result in Calculate.lastCalculation)
                {
                    Console.WriteLine(result.questionAndAnswer);
                }
                command.Show("Press Enter To Exit");
                Console.ReadLine();
                runApp = false;
            }
            else if (quitInput == "N" || quitInput == "n")
            {
                runApp = true;
            }
            else
            {
                HandleApplicationQuitting();
            }
        }

        public void RestartCheck(string value)
        {
            if(!success)
            {
                command.Show(value);
                Console.WriteLine("Press Enter To Restart");
                Console.ReadLine();
                Console.Clear();
                StartApplication();
            }
        }
    }
}
