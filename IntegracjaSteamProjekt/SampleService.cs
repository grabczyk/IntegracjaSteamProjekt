using IntegracjaSteamProjekt;
using System;
using System.Xml.Linq;
using System.Threading;

public class SampleService : ISampleService
{

    public string HelloPolitechnika()
    {
        return Thread.CurrentThread.Name;
    }

    public string Test()
    {
        return "test2";
    }
}