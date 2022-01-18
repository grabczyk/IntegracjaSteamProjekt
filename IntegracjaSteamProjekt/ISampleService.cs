using System.ServiceModel;
namespace IntegracjaSteamProjekt
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string Test();
        [OperationContract]
        string HelloPolitechnika();
    }
}