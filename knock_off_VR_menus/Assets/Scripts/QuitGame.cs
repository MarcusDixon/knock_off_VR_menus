using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.Quit();
        }
    }
}

