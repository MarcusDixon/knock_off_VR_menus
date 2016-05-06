using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Fist : NetworkBehaviour
{

    public float punchPower = 20;
    private Rigidbody rb;
    Vector3 offset = new Vector3(0f, 0f, 0f);
    Vector3 playerPos = new Vector3(0f, 0f, 0f);
    public float punchDistance = 5.0f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerPos = transform.parent.transform.position;
        offset = transform.position - playerPos;
    }

    public void makeFistBig()
    {
        rb.transform.localScale = new Vector3(.05f, .05f, .05f);
    }

}