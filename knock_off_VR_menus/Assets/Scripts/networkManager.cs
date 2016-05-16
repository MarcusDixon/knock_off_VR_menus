using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class networkManager : NetworkManager {

    public void StartupServer()
    {
        SetIPAddress();
        SetPort();
        NetworkManager.singleton.StartServer();
    }

    public void JoinGame()
    {
        SetIPAddress();
        SetPort();
        NetworkManager.singleton.StartClient();
    }

    void SetPort()
    {
        NetworkManager.singleton.networkPort = 7778;
    }

    void SetIPAddress()
    {
        string ipAddress = "192.168.1.127";
        NetworkManager.singleton.networkAddress = ipAddress;
    }
}
