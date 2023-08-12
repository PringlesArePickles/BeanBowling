using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrow : MonoBehaviour
{
    public Rigidbody rb;
    public Transform ballOrigin;
    public Transform camOrigin;
    public GameObject cam;
    private float throwPower = 225f;

    public CheckForMovement cfm;

    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //add rigidbody constraints
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) //if space is pressed
        {
            ThrowBall(); //call ThrowBall() function
        }

    }

    public void ThrowBall()
    {
        rb.constraints = RigidbodyConstraints.None; //remove rigidbody constraints
        rb.AddForce(0f, 0f, throwPower, ForceMode.Impulse); //throw ball with impulse force
        Invoke("ResetBall", 5f); //call reset ball function after 5 seconds
    }

    public void ResetBall()
    {
        cfm.MovementCheck();
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //stop ball from moving
        transform.position = ballOrigin.position; //put ball in original position
        transform.rotation = ballOrigin.rotation; //put ball in original rotation
        cam.transform.position = camOrigin.position; //put camera in original position
        cam.transform.rotation = camOrigin.rotation; //put camera in original rotation
    }
}
