using UnityEngine;
using System.Collections;

public class timers : MonoBehaviour {

    public Transform from;
    public Transform to;
    public float speed = 15.0F;
    float timeLeft = 10.0f;
    bool flipSwitch = true;
    bool daFlipSwitch = true;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        Debug.Log(timeLeft);
        if (timeLeft < 0)
        {
            if (flipSwitch)
            {
                if (tag == "red")
                {
                    Debug.Log("IN HERE");
                    transform.rotation = Quaternion.Lerp(new Quaternion(0,0,0,1), new Quaternion(0, 0, 180, 1), Time.time * speed);
                    timeLeft = 30.0f;
                    flipSwitch = false;
                }
            }
            else
            {
                if (tag == "blue")
                {
                    transform.rotation = Quaternion.Lerp(new Quaternion(0, 0, 0, 1), new Quaternion(0, 0, 180, 1), Time.time * speed);
                    timeLeft = 30.0f;
                    flipSwitch = true;
                }
            }
        }
    }
}
