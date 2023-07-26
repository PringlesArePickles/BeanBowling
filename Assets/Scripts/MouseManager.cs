using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseManager : MonoBehaviour
{
    [Header("Mouse Info")]
    public Vector3 clickStartLocation;

    [Header("Physics")]
    public Vector3 launchVector;
    public float launchForce;

    [Header("Slime")]
    public Transform ballTransform;
    public Rigidbody ballRigidbody;
    public Vector3 ballOrigin;

    // Start is called before the first frame update
    void Start()
    {
        ballOrigin = new Vector3(
        0f,
        2f,
        -35f
        );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;

        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * 1f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * 1.5f
            );
            launchVector.Normalize();
            ballTransform.position = ballOrigin - launchVector / 400;
        }

        if (Input.GetMouseButtonUp(0))
        {
            ballRigidbody.isKinematic = false;
            ballRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(1) || Input.GetKeyDown("space"))
        {
            ballRigidbody.isKinematic = true;
            ballTransform.position = ballOrigin;
        }
    }
}
