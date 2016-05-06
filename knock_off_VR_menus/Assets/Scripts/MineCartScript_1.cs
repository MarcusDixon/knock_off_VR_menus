using UnityEngine;
using System.Collections;

public class MineCartScript_1 : MonoBehaviour {
    private Vector3 startPosition = new Vector3(6.96f, 0.614324f, -.179676f);
    private Vector3 endPosition = new Vector3(.95f, 0.614324f, -.179676f);
    private bool direction = true;
    // Use this for initialization
        
    void Start () {
        transform.position = startPosition;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > startPosition.x)
        {
            direction = true; 
        }
        else if(transform.position.x < endPosition.x)
        {
            direction = false;
        }

        if (direction)
        {
            Forwards();
        }
        else
            Backwards();
	}

    void Forwards()
    {
        transform.position += new Vector3(-.05f, 0, 0);
    }
    void Backwards()
    {
        transform.position += new Vector3(.05f, 0, 0);
    }
}
