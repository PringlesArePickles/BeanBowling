using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    /*[Header("Buttons")]
    public GameObject refriedBeans;
    public GameObject pintoBeans;
    public GameObject limaBeans;
    public GameObject kidneyBeans;
    public GameObject blackBeans;
    public GameObject lentils;
    public GameObject greenBeans;
    public GameObject garbanzoBeans;
    public GameObject jellyBeans;*/

    [Header("Text in buttons")]
    public Text refriedBeansText;
    public Text pintoBeansText;
    public Text limaBeansText;
    public Text kidneyBeansText;
    public Text blackBeansText;
    public Text lentilsText;
    public Text greenBeansText;
    public Text garbanzoBeansText;
    public Text jellyBeansText;

    [Header("Script references")]
    public CoinBonus coinBonus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void refriedBeansFunction()
    {
        refriedBeansText.color = new Color(0f, 1f, 0f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }
    public void pintoBeansFunction()
    {
        if (coinBonus.coins >= 100f)
        {
            coinBonus.coins -= 100f;

            refriedBeansText.color = new Color(.5f, .5f, .5f);
            pintoBeansText.color = new Color(0f, 1f, 0f);
            limaBeansText.color = new Color(.5f, .5f, .5f);
            kidneyBeansText.color = new Color(.5f, .5f, .5f);
            blackBeansText.color = new Color(.5f, .5f, .5f);
            lentilsText.color = new Color(.5f, .5f, .5f);
            greenBeansText.color = new Color(.5f, .5f, .5f);
            garbanzoBeansText.color = new Color(.5f, .5f, .5f);
            jellyBeansText.color = new Color(.5f, .5f, .5f);
        }
        
    }

    public void limaBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(0f, 1f, 0f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void kidneyBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(0f, 1f, 0f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void blackBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(0f, 1f, 0f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void lentilsFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(0f, 1f, 0f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void greenBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(0f, 1f, 0f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void garbanzoBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(0f, 1f, 0f);
        jellyBeansText.color = new Color(.5f, .5f, .5f);
    }

    public void jellyBeansFunction()
    {
        refriedBeansText.color = new Color(.5f, .5f, .5f);
        pintoBeansText.color = new Color(.5f, .5f, .5f);
        limaBeansText.color = new Color(.5f, .5f, .5f);
        kidneyBeansText.color = new Color(.5f, .5f, .5f);
        blackBeansText.color = new Color(.5f, .5f, .5f);
        lentilsText.color = new Color(.5f, .5f, .5f);
        greenBeansText.color = new Color(.5f, .5f, .5f);
        garbanzoBeansText.color = new Color(.5f, .5f, .5f);
        jellyBeansText.color = new Color(1f, .1f, .5f);
    }
}
