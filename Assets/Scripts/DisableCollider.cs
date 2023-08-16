using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCollider : MonoBehaviour
{
    private BoxCollider bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "pin")
        {
            bc.GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            bc.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
