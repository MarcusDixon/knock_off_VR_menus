using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{

    public void loadScene(string level)
    {
        SceneManager.LoadScene(level);
    }

/*
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            loadScene("level");
        }
    }*/ 
}
