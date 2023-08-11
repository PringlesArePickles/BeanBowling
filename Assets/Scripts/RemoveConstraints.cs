using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveConstraints : MonoBehaviour
{
    public Rigidbody m_rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Pin")
        {
            m_rigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
