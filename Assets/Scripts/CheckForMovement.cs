using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForMovement : MonoBehaviour
{
    private Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovementCheck()
    {
        if (transform.position != originalPosition)
        {
            Debug.Log("functioncalled");
            gameObject.SetActive(false);
        }
    }
}
