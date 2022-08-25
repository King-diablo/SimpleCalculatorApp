using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorAppliaction
    {
        Input input = new Input();
        Commands command = new Commands();
        Validator validator = new Validator();

        public bool runApp = true;
        public bool success = false;
        public void StartApplication()
        {
            var input1 = 0d;
            var input2 = 0d;
            var choice = "a";
            var quitInput = "N";

            while (runApp)
            {
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

                HandleApplicationQuitting(quitInput);

                Console.Clear();
            }
        }

        private void HandleApplicationQuitting(string quitInput)
        {
            command.Show("Y/N to Quit");

            quitInput = input.InputData();

            if (quitInput == "Y" || quitInput == "y")
            {
                runApp = false;
            }
            else if (quitInput == "N" || quitInput == "n")
            {
                runApp = true;
            }
            else
            {
                HandleApplicationQuitting(quitInput);
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
