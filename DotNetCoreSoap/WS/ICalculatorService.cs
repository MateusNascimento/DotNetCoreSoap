using System.ServiceModel;

namespace DotNetCoreSoap.WS
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double numberA, double numberB);

        [OperationContract]
        double Sub(double numberA, double numberB);

        [OperationContract]
        double Mul(double numberA, double numberB);

        [OperationContract]
        double Div(double numberA, double numberB);
    }
}
