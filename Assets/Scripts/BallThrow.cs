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
    public GameObject ball;

    [Header("Numbers")]
    public float throwPower;

    [Header("Script references")]
    public CheckForMovement cfm;
    private RemoveConstraints rc;

    [Header("Booleans")]
    private bool canThrow;
    private bool canMoveLeft;
    private bool canMoveRight;

    [Header("Text")]
    public Text powerNumberText;

    [Header("Pins")]
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;
    public Rigidbody pin1rb;
    public Rigidbody pin2rb;
    public Rigidbody pin3rb;
    public Rigidbody pin4rb;
    public Rigidbody pin5rb;
    public Rigidbody pin6rb;
    public Rigidbody pin7rb;
    public Rigidbody pin8rb;
    public Rigidbody pin9rb;
    public Rigidbody pin10rb;

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
        throwPower = PlayerPrefs.GetFloat("throwPower", 185f);
        powerNumberText.text = throwPower.ToString(); //powerText shows the throw power float as a string

        if (Input.GetKeyUp(KeyCode.Space) && canThrow == true) //if space is pressed
        {
            ThrowBall(); //call ThrowBall() function
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && canMoveLeft == true && canThrow == true) //if "a" or left arrow key was pressed
        {
            gameObject.transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
            cam.transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);
            //change position a tiny bit in the negative direction
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && canMoveRight == true && canThrow == true) //if "d" or right arrow key was pressed
        {
            gameObject.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            cam.transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, transform.position.z);
            //change positioin a tiny bit in positive direction
        }

        if (ball.transform.position.x <= -4.5f)
        {
            canMoveLeft = false;
        }
        
        if (ball.transform.position.x >= 4.5f)
        {
            canMoveRight = false;
        }
        
        if (ball.transform.position.x > -4.5f && ball.transform.position.x < 4.5f)
        {
            canMoveRight = true;
            canMoveLeft = true;
        }
    }

    public void ThrowBall()
    {
        cfm.ballsThrown += 1;
        rb.constraints = RigidbodyConstraints.None; //remove rigidbody constraints
        rb.AddForce(Random.Range(-3f, 3f), 0f, throwPower, ForceMode.Impulse); //throw ball with impulse force
        Invoke("ResetBall", 7.5f); //call reset ball function after 7 seconds
        canThrow = false; //ball can no longer be thrown;
        canMoveLeft = false;
        canMoveRight = false;
    }

    public void ResetBall()
    {
        pin1rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin2rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin3rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin4rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin5rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin6rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin7rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin8rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin9rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        pin10rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
    
        cfm.MovementCheck(); //call the MovementCheck() function in CheckForMovement.cs
        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ; //stop ball from moving
        transform.position = ballOrigin.position; //put ball in original position
        transform.rotation = ballOrigin.rotation; //put ball in original rotation
        cam.transform.position = camOrigin.position; //put camera in original position
        cam.transform.rotation = camOrigin.rotation; //put camera in original rotation
        canThrow = true; //ball can throw
        canMoveLeft = true;
        canMoveRight = true;
    }
}
