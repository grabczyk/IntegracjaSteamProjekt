using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace IntegracjaSteamProjekt
{
    /// <summary>
    /// Intersejs funkcji soapAPI
    /// </summary>
    [ServiceContract]
    public interface ISoapApiService
    {
        [OperationContract]
        string ProjectDescription();

        [OperationContract]
        Task<List<string>> PlayerOwnedGames(string playerName);
    }
}