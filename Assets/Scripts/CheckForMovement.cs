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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementCheck()
    {
        float threshold = 0.05f;
        
        //if pin is not in same position as origin then set the pin to be inactive
        if (Vector3.Distance(pin1.transform.position, pin1Pos.position) > threshold)
        {
            pin1.SetActive(false);
        }

        if (Vector3.Distance(pin2.transform.position, pin2Pos.position) > threshold)
        {
            pin2.SetActive(false);
        }

        if (Vector3.Distance(pin3.transform.position, pin3Pos.position) > threshold)
        {
            pin3.SetActive(false);
        }

        if (Vector3.Distance(pin4.transform.position, pin4Pos.position) > threshold)
        {
            pin4.SetActive(false);
        }

        if (Vector3.Distance(pin5.transform.position, pin5Pos.position) > threshold)
        {
            pin5.SetActive(false);
        }

        if (Vector3.Distance(pin6.transform.position, pin6Pos.position) > threshold)
        {
            pin6.SetActive(false);
        }

        if (Vector3.Distance(pin7.transform.position, pin7Pos.position) > threshold)
        {
            pin7.SetActive(false);
        }

        if (Vector3.Distance(pin8.transform.position, pin8Pos.position) > threshold)
        {
            pin8.SetActive(false);
        }

        if (Vector3.Distance(pin9.transform.position, pin9Pos.position) > threshold)
        {
            pin9.SetActive(false);
        }

        if (Vector3.Distance(pin10.transform.position, pin10Pos.position) > threshold)
        {
            pin10.SetActive(false);
        }
    }
}
