using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("BeanBowling");
    }

    public void LoadShopScene()
    {
        SceneManager.LoadScene("ShopScreen");
        Debug.Log("coins in play scene. Coins: " + PlayerPrefs.GetFloat("coins"));
    }

    public void LoadHomeScene()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
