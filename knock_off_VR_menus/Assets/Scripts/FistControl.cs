using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class FistControl : NetworkBehaviour
{

    private Rigidbody rb;
    Vector3 offset = new Vector3(0f, 0f, 0f);
    Vector3 playerPos = new Vector3(0f, 0f, 0f);
    public float speed = 0.1f;
    private Fist fist;
    bool toPunch = false;
    private Vector3 punchDirection = new Vector3(0f, 0f, 0f);
    private Vector3 Target = new Vector3(1, 0, 0);
    private float OrbitDist = 5.0f;
    private bool punching = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerPos = transform.parent.transform.position;
        offset = transform.position - playerPos;
        fist = GetComponent<Fist>();
    }

    public Vector3 getPunchDirection()
    {
        return punchDirection;
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        //		Vector3 rotPosition = new Vector3 (Input.GetAxis ("Axis 3"), 0, Input.GetAxis ("Axis 4"));
        //		rb.angularVelocity = Vector3.zero;
        //		if (rotPosition.normalized != Vector3.zero) {
        //			Target = rotPosition.normalized * OrbitDist;
        //		} else {
        //			Target = Target.normalized * OrbitDist;
        //		}
        //		transform.position = Vector3.Slerp (transform.position, (Target - rb.position), rotPosition.magnitude * .5f);
        //transform.position += rb.position;
        Vector3 rotPosition;
        float rsx = Input.GetAxis("Axis 5");
        float rsy = Input.GetAxis("Axis 6");
        playerPos = transform.parent.transform.position;

        var c = (rsx * rsx) + (rsy * rsy);
        if (c > .5f)
        {
            rotPosition = new Vector3(playerPos.x + rsx, playerPos.y,
                playerPos.z - rsy);

            //float angle = Vector3.Angle (rotPosition, rb.transform.position);
            rb.transform.position = Vector3.Lerp(transform.position, rotPosition, 1);
            offset = transform.position - playerPos;
            rb.angularVelocity = Vector3.zero;
        }
        Vector3 temp = new Vector3(rb.transform.position.x - playerPos.x, 0, rb.transform.position.z - playerPos.z);
        punchDirection = temp;
        transform.position = playerPos + offset;

    }



}