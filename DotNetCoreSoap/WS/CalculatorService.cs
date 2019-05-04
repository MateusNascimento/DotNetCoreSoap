namespace DotNetCoreSoap.WS
{
    public class CalculatorService : ICalculatorService
    {
        public double Add(double numberA, double numberB)
        {
            return numberA + numberB;
        }

        public double Sub(double numberA, double numberB)
        {
            return numberA - numberB;
        }

        public double Mul(double numberA, double numberB)
        {
            return numberA * numberB;
        }

        public double Div(double numberA, double numberB)
        {
            return numberA / numberB;
        }
    }
}
