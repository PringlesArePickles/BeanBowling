using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallThrow : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody rb;
    public Transform ballOrigin;
    public Transform camOrigin;
    public GameObject cam;

    [Header("Numbers")]
    private float throwPower = 225f;

    [Header("Script references")]
    public CheckForMovement cfm;
    private RemoveConstraints rc;

    [Header("Booleans")]
    private bool canThrow;
    private bool canMoveLeft;
    private bool canMoveRight;

    [Header("Text")]
    public Text powerNumberText;

    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //add rigidbody constraints
        canThrow = true; //ball can be thrown
        rc = FindObjectOfType<RemoveConstraints>(); //find all objects with RemoveConstraintsScript
        canMoveLeft = true; //ball can move left
        canMoveRight = true; //ball can move right
    }

    // Update is called once per frame
    void Update()
    {
        powerNumberText.text = throwPower.ToString(); //powerText shows the throw power float as a string

        if (Input.GetKeyUp(KeyCode.Space) && canThrow == true) //if space is pressed
        {
            ThrowBall(); //call ThrowBall() function
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && canMoveLeft == true && canThrow == true) //if "a" or left arrow key was pressed
        {
            gameObject.transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
            cam.transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
            //change position a tiny bit in the negative direction
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && canMoveRight == true && canThrow == true) //if "d" or right arrow key was pressed
        {
            gameObject.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            cam.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            //change positioin a tiny bit in positive direction
        }
    }

    public void ThrowBall()
    {
        cfm.ballsThrown += 1;
        rb.constraints = RigidbodyConstraints.None; //remove rigidbody constraints
        rb.AddForce(0f, 0f, throwPower, ForceMode.Impulse); //throw ball with impulse force
        Invoke("ResetBall", 9f); //call reset ball function after 7 seconds
        canThrow = false; //ball can no longer be thrown;
    }

    public void ResetBall()
    {
        rc.AddConstraints(); //call the AddConstraints() function in all objects containing the script RemoveConstraints.cs
        cfm.MovementCheck(); //call the MovementCheck() function in CheckForMovement.cs
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //stop ball from moving
        transform.position = ballOrigin.position; //put ball in original position
        transform.rotation = ballOrigin.rotation; //put ball in original rotation
        cam.transform.position = camOrigin.position; //put camera in original position
        cam.transform.rotation = camOrigin.rotation; //put camera in original rotation
        canThrow = true; //ball can throw
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "leftBarrier")
        {
            canMoveLeft = false;
        }
        else
        {
            canMoveLeft = true;
        }
        
        if (other.gameObject.tag == "rightBarrier")
        {
            canMoveRight = false;
        }
        else
        {
            canMoveRight = true;
        }
    }
}
