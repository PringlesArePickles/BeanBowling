using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForMovement : MonoBehaviour
{
    [Header("Original Pin Positions")]
    public Transform pin1Pos;
    public Transform pin2Pos;
    public Transform pin3Pos;
    public Transform pin4Pos;
    public Transform pin5Pos;
    public Transform pin6Pos;
    public Transform pin7Pos;
    public Transform pin8Pos;
    public Transform pin9Pos;
    public Transform pin10Pos;
    
    [Header("Pin GameObjects")]
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

    [Header("Numbers")]
    private int pinsKnockedDown;

    [Header("Rigidbodies")]
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
        pinsKnockedDown = 0;
        Debug.Log("pins knocked down " + pinsKnockedDown);
    }

    // Update is called once per frame
    void Update()
    {
        if (pinsKnockedDown == 10)
        {
            ResetPins();
        }
    }

    public void MovementCheck()
    {
        float threshold = 0.05f;
        
        //if pin is not in same position as origin then set the pin to be inactive
        if (Vector3.Distance(pin1.transform.position, pin1Pos.position) > threshold && pin1.activeInHierarchy == true)
        {
            pin1.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin2.transform.position, pin2Pos.position) > threshold && pin2.activeInHierarchy == true)
        {
            pin2.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin3.transform.position, pin3Pos.position) > threshold && pin3.activeInHierarchy == true)
        {
            pin3.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin4.transform.position, pin4Pos.position) > threshold && pin4.activeInHierarchy == true)
        {
            pin4.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin5.transform.position, pin5Pos.position) > threshold && pin5.activeInHierarchy == true)
        {
            pin5.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin6.transform.position, pin6Pos.position) > threshold && pin6.activeInHierarchy == true)
        {
            pin6.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin7.transform.position, pin7Pos.position) > threshold && pin7.activeInHierarchy == true)
        {
            pin7.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin8.transform.position, pin8Pos.position) > threshold && pin8.activeInHierarchy == true)
        {
            pin8.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin9.transform.position, pin9Pos.position) > threshold && pin9.activeInHierarchy == true)
        {
            pin9.SetActive(false);
            pinsKnockedDown += 1;
        }

        if (Vector3.Distance(pin10.transform.position, pin10Pos.position) > threshold && pin10.activeInHierarchy == true)
        {
            pin10.SetActive(false);
            pinsKnockedDown += 1;
        }

        Debug.Log("pins knocked down" + pinsKnockedDown);
    }

    public void ResetPins()
    {
        pin1.SetActive(true);
        pin1.transform.position = pin1Pos.position;
        pin1.transform.rotation = pin1Pos.rotation;
        pin1rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin2.SetActive(true);
        pin2.transform.position = pin2Pos.position;
        pin2.transform.rotation = pin2Pos.rotation;
        pin2rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin3.SetActive(true);
        pin3.transform.position = pin3Pos.position;
        pin3.transform.rotation = pin3Pos.rotation;
        pin3rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin4.SetActive(true);
        pin4.transform.position = pin4Pos.position;
        pin4.transform.rotation = pin4Pos.rotation;
        pin4rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin5.SetActive(true);
        pin5.transform.position = pin5Pos.position;
        pin5.transform.rotation = pin5Pos.rotation;
        pin5rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin6.SetActive(true);
        pin6.transform.position = pin6Pos.position;
        pin6.transform.rotation = pin6Pos.rotation;
        pin6rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin7.SetActive(true);
        pin7.transform.position = pin7Pos.position;
        pin7.transform.rotation = pin7Pos.rotation;
        pin7rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin8.SetActive(true);
        pin8.transform.position = pin8Pos.position;
        pin8.transform.rotation = pin8Pos.rotation;
        pin8rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin9.SetActive(true);
        pin9.transform.position = pin9Pos.position;
        pin9.transform.rotation = pin9Pos.rotation;
        pin9rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pin10.SetActive(true);
        pin10.transform.position = pin10Pos.position;
        pin10.transform.rotation = pin10Pos.rotation;
        pin10rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;

        pinsKnockedDown = 0;
    }
}
