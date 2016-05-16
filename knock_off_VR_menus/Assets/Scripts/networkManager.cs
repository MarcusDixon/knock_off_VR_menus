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

    public void ShutdownServer()
    {
        LeaveGame();
        NetworkManager.singleton.StopServer();
    }

    public void JoinGame()
    {
        SetIPAddress();
        SetPort();
        NetworkManager.singleton.StartClient();
    }

    void LeaveGame()
    {
        NetworkManager.singleton.StartClient();
    }

    void SetPort()
    {
<<<<<<< HEAD
        NetworkManager.singleton.networkPort = 7888;
=======
        NetworkManager.singleton.networkPort = 7778;
>>>>>>> 0b09c37a2f216bee252d0946e9904d1475d777d5
    }


    void SetIPAddress()
    {
        string ipAddress = "192.168.1.127";
        NetworkManager.singleton.networkAddress = ipAddress;
    }
}
