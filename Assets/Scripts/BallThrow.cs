using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ThrowBall();
        }

    }

    public void ThrowBall()
    {
        rb.AddForce(0f, 0f, 150f, ForceMode.Impulse);
    }
}
