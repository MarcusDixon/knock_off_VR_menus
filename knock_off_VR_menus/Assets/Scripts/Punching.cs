using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Punching : NetworkBehaviour
{

    private bool punching = false;
    private FistControl fistcontrol;
    Vector3 punchDirection = Vector3.zero;

    void Start()
    {
        fistcontrol = GetComponent<FistControl>();
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        punchDirection = fistcontrol.getPunchDirection();
        if (!punching && Input.GetKey(KeyCode.JoystickButton7))
        {
            StartCoroutine(Punch(0.5f, 1.25f, punchDirection));
        }
    }

    IEnumerator Punch(float time, float distance, Vector3 direction)
    {
        punching = true;
        var timer = 0.0f;
        var orgPos = transform.position;
        direction.Normalize();
        Debug.Log("Above the loop");
        while (timer <= time)
        {
            Debug.Log("----");
            transform.position = orgPos + (Mathf.Sin(timer / time * Mathf.PI) + 1.0f) * direction;
            yield return null;
            timer += Time.deltaTime;
        }
        transform.position = orgPos;
        punching = false;
    }
}