using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForMovement : MonoBehaviour
{
    [Header("Original Pin Positions")]
    private Vector3 pin1Pos;
    private Vector3 pin2Pos;
    private Vector3 pin3Pos;
    private Vector3 pin4Pos;
    private Vector3 pin5Pos;
    private Vector3 pin6Pos;
    private Vector3 pin7Pos;
    private Vector3 pin8Pos;
    private Vector3 pin9Pos;
    private Vector3 pin10Pos;
    
    [Header("Array of Pins")]
    public GameObject[] pins = new GameObject[10];
    
    [Header("Pin GameObjects")]
    private GameObject pin1;
    private GameObject pin2;
    private GameObject pin3;
    private GameObject pin4;
    private GameObject pin5;
    private GameObject pin6;
    private GameObject pin7;
    private GameObject pin8;
    private GameObject pin9;
    private GameObject pin10;

    // Start is called before the first frame update
    void Start()
    {
        //assign gameObjects to a piece in the pins array
        pin1 = pins[0];
        pin2 = pins[1];
        pin3 = pins[2];
        pin4 = pins[3];
        pin5 = pins[4];
        pin6 = pins[5];
        pin7 = pins[6];
        pin8 = pins[7];
        pin9 = pins[8];
        pin10 = pins[9];
    
        //set pin origins to initial pin position
        pin1Pos = pin1.transform.position;
        pin2Pos = pin2.transform.position;
        pin3Pos = pin3.transform.position;
        pin4Pos = pin4.transform.position;
        pin5Pos = pin5.transform.position;
        pin6Pos = pin6.transform.position;
        pin7Pos = pin7.transform.position;
        pin8Pos = pin8.transform.position;
        pin9Pos = pin9.transform.position;
        pin10Pos = pin10.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementCheck()
    {
        //if pin is not in same position as origin then set the pin to be inactive
        if (pin1.transform.position != pin1Pos)
        {
            pin1.SetActive(false);
        }

        if (pin2.transform.position != pin2Pos)
        {
            pin2.SetActive(false);
        }

        if (pin3.transform.position != pin3Pos)
        {
            pin3.SetActive(false);
        }

        if (pin4.transform.position != pin4Pos)
        {
            pin4.SetActive(false);
        }

        if (pin5.transform.position != pin5Pos)
        {
            pin5.SetActive(false);
        }

        if (pin6.transform.position != pin6Pos)
        {
            pin6.SetActive(false);
        }

        if (pin7.transform.position != pin7Pos)
        {
            pin7.SetActive(false);
        }

        if (pin8.transform.position != pin8Pos)
        {
            pin8.SetActive(false);
        }

        if (pin9.transform.position != pin9Pos)
        {
            pin9.SetActive(false);
        }

        if (pin10.transform.position != pin10Pos)
        {
            pin10.SetActive(false);
        }
    }
}
