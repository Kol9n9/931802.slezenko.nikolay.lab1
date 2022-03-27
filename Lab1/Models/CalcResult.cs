namespace Lab1.Models
{
    /// <summary>
    /// Результат вычисления
    /// </summary>
    public class CalcResult
    {
        public int FirstValue { get; }
        public int SecondValue { get; }
        public string Name { get; }
        public string Operation { get; }
        public string Result { get; private set; }

        public CalcResult(int firstValue, int secondValue, string name, string operation)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            Name = name;
            Operation = operation;
            Calc();
        } 

        public string Print()
        {
            return $"{FirstValue} {Operation} {SecondValue} = {Result}";
        }

        private void Calc()
        {
            switch (Operation)
            {
                case "+":
                    {
                        Result = (FirstValue + SecondValue).ToString();
                        break;
                    }
                case "-":
                    {
                        Result = (FirstValue - SecondValue).ToString();
                        break;
                    }
                case "*":
                    {
                        Result = (FirstValue * SecondValue).ToString();
                        break;
                    }
                case "/":
                    {
                        if(SecondValue == 0)
                        {
                            Result = "Attempt to divide by zero";
                        }
                        else
                        {
                            Result = (FirstValue / SecondValue).ToString();
                        }
                        break;
                    }
            }
        }
    }
}
