using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Calculator.WPF
{
    public class BusinessLogic
    {
        readonly Calculation calc = new Calculation();
        public TextBox textBoxTemp = new TextBox();
        public TextBox textBoxFinal = new TextBox();


        private double NumberOne { get; set; }

        private double Result { get; set; }
        public string Operation { get; set; }

        public void GetNumber(string input)
        {
            if (Operation == null)
            {
                textBoxFinal.Text = "0";
                Result = (Result * 10) + double.Parse(input);
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                NumberOne = (NumberOne * 10) + double.Parse(input);
                textBoxTemp.Text = NumberOne.ToString();
            }
        }

        public void GetCalculation(string input)
        {

            if (Operation is null)
            {

                Operation = input;
                textBoxTemp.Text = "0";
            }
            else if (input.Equals("="))
            {
                Calculate();
                textBoxFinal.Text = Result.ToString();
                textBoxTemp.Text = "0";
                Result = 0;
                NumberOne = 0;
                Operation = null;
            }
            else
            {
                Calculate();
                textBoxFinal.Text = Result.ToString();
                NumberOne = 0;
                Operation = input;
                textBoxTemp.Text = "0";
            }
        }

        private void Calculate()
        {
            try
            {
                switch (Operation)
                {
                    case "+": Result = calc.Addition(Result, NumberOne); break;
                    case "-": Result = calc.Subtraction(Result, NumberOne); break;
                    case "*": Result = calc.Multiplication(Result, NumberOne); break;
                    case "/": Result = calc.Division(Result, NumberOne); ; break;
                }
            }
            catch (DivideByZeroException e)
            {
                textBoxTemp.Text = e.Message;
            }
        }
    }
}
