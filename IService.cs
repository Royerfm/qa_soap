using System.ServiceModel;

[ServiceContract]
public interface IService
{
    [OperationContract]
    string HolaMundo();
}
