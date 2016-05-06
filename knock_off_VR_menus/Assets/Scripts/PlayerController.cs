using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour
{

    private float speed = 5.0f;
    private Rigidbody rb;
    public int movePower = 100;
    private float moveHorizontal = 0.0f;
    private float moveVertical = 0.0f;
    private Fist fist;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fist = gameObject.GetComponentInChildren<Fist>();
    }

    void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        moveHorizontal = Input.GetAxis("Axis 1");
        moveVertical = Input.GetAxis("Axis 2");
    }

    void FixedUpdate()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        //rb.AddForce (movement.normalized * speed);
        rb.AddTorque(new Vector3(-movement.z, 0, -movement.x) * speed * movePower);
    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("ran into something", gameObject);
        if (other.gameObject.tag == "BigFist")
        {
            Debug.Log("bigfist", gameObject);
            fist.makeFistBig();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "HeavyMass")
        {
            Debug.Log("HeavyMass", gameObject);
            increaseMass();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "FastSpeed")
        {
            Debug.Log("FastSpeed", gameObject);
            increaseSpeed(7.5f);
            Destroy(other.gameObject);
        }

    }



    public void increaseSpeed(float input)
    {
        speed = input;
    }

    public void increaseMass()
    {
        rb.mass = 5;
    }

    public void cleanse()
    {
        speed = 5.0f;
        rb.mass = 1;
    }
}