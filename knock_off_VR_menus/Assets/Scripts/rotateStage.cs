using UnityEngine;
using System.Collections;

public class rotateStage : MonoBehaviour {

    //public float rotation;
    Rigidbody rb;
    ConstantForce cf;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cf = GetComponent<ConstantForce>();
    }
    void FixedUpdate()
    {

        //transform.Rotate(new Vector3(0, 0, rotation) * Time.deltaTime);
    }
}