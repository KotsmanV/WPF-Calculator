using BusinessLogic;
using System;
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

        internal void SquareRoot()
        {
            if (Operation == null)
            {
                Result = calc.SquareRoot(Result);
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                NumberOne = calc.SquareRoot(NumberOne);
                textBoxTemp.Text = NumberOne.ToString();
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

        public void RaiseToPower(double y)
        {
            if (y == 2)
            {
                Result = calc.Power(Result, 2);
                textBoxTemp.Text = Result.ToString();
            }
            else
            {

            }
        }

        public void PlusMinus()
        {
            if (Operation == null)
            {
                Result *= -1;
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                NumberOne *= -1;
                textBoxTemp.Text = NumberOne.ToString();
            }

        }
        internal void ClearAll()
        {
            NumberOne = 0;
            Result = 0;
            Operation = null;
            textBoxTemp.Text = "0";
            textBoxFinal.Text = "0";
        }
        internal void ClearEntry()
        {
            if (Operation == null)
            {
                Result = 0;
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                NumberOne = 0;
                textBoxTemp.Text = NumberOne.ToString();
            }
        }

        //TODO: Fix Backspace
        internal void Backspace()
        {
            if (Operation == null)
            {
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                textBoxTemp.Text = NumberOne.ToString();
            }
        }

        //TODO: Fix Dot
        internal void Dot()
        {
            if (Operation == null)
            {
                if (Result%1==0)
                {
                    Result /= 10;
                    textBoxTemp.Text = Result.ToString();
                }
            }
            else
            {
                if (NumberOne % 1 == 0)
                {
                    NumberOne /= 10;
                    textBoxTemp.Text = NumberOne.ToString();
                }

            }
        }

        //TODO: Fix Percentage
        internal void Percentage()
        {
            if (Operation==null)
            {
                Result /= 100;
                textBoxTemp.Text = Result.ToString();
            }
            else
            {
                NumberOne /= 100;
                textBoxTemp.Text = Result.ToString();
            }
        }


    }
}
