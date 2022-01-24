using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        string ProjectDescription();

        [OperationContract]
        Task<List<string>> PlayerOwnedGames(string playerName);
    }
}