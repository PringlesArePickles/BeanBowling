using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMaterialScript : MonoBehaviour
{
    public Shop shop;
    public Material refriedBeansMat;
    public Material pintoBeansMat;
    public Material limaBeansMat;
    public Material kidneyBeansMat;
    public Material blackBeansMat;
    public Material lentilsMat;
    public Material greenBeansMat;
    public Material garbanzoBeansMat;
    public Material jellyBeansMat;
    //public Shop shop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shop.ballMaterial = PlayerPrefs.GetString("ballMaterial", "refriedBeansMaterial");
        
        if (shop.ballMaterial == "refriedBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = refriedBeansMat;
        }

        if (shop.ballMaterial == "pintoBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = pintoBeansMat;
        }

        if (shop.ballMaterial == "limaBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = limaBeansMat;
        }

        if (shop.ballMaterial == "kidneyBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = kidneyBeansMat;
        }

        if (shop.ballMaterial == "blackBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = blackBeansMat;
        }

        if (shop.ballMaterial == "greenBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = greenBeansMat;
        }

        if (shop.ballMaterial == "lentilsMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = lentilsMat;
        }

        if (shop.ballMaterial == "garbanzoBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = garbanzoBeansMat;
        }

        if (shop.ballMaterial == "jellyBeansMaterial")
        {
            gameObject.GetComponent<MeshRenderer> ().material = jellyBeansMat;
        }
    }
}
