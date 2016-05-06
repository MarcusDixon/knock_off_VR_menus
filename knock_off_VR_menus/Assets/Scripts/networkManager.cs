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
        NetworkManager.singleton.networkPort = 7777;
    }

    void SetIPAddress()
    {
        string ipAddress = "192.168.1.144";
        NetworkManager.singleton.networkAddress = ipAddress;
    }









    public void startTheClient()
    {
        StartClient();
    }

    public void startTheServer()
    {
        StartServer();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    }
}
