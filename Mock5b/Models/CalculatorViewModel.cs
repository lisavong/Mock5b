namespace Mock5b.Models
{
    public class CalculatorViewModel
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }
        public string Operation { get; set; }
        public double Add => (Num1 + Num2);
        public double Minus => (Num1 - Num2);
        public double Multiply => (Num1 * Num2);
        public double Divide => (Num1 / Num2);
    }
}
