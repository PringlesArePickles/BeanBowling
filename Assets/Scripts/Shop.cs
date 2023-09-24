using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
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

    [Header("Text")]
    public Text coinText;

    public Text rbText;
    public Text pbText;
    public Text lbText;
    public Text kbText;
    public Text bbText;
    public Text lText;
    public Text greenbText;
    public Text garbanzobText;
    public Text jbText;


    [Header("Script references")]
    public CoinBonus coinBonus;

    [Header("Floats")]
    //0 is false, 1 is true.
    public float pintoBeansOwned;
    public float limaBeansOwned;
    public float kidneyBeansOwned;
    public float blackBeansOwned;
    public float lentilsOwned;
    public float greenBeansOwned;
    public float garbanzoBeansOwned; 
    public float jellyBeansOwned;

    [Header("Strings")]
    public string ballMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score" + PlayerPrefs.GetFloat("score"));

        pintoBeansOwned = PlayerPrefs.GetFloat("pintoBeansOwned", 0);
        limaBeansOwned = PlayerPrefs.GetFloat("limaBeansOwned", 0);
        kidneyBeansOwned = PlayerPrefs.GetFloat("kidneyBeansOwned", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Coins in shop scene. Coins: " + PlayerPrefs.GetFloat("coins"));
        coinText.text = ("Coins: " + Mathf.Round(PlayerPrefs.GetFloat("coins")));

        if (pintoBeansOwned == 1f)
        {
            pbText.text = "Owned";
        }

        if (limaBeansOwned == 1f)
        {
            lbText.text = "Owned";
        }

        if (kidneyBeansOwned == 1f)
        {
            kbText.text = "Owned";
        }

        if (blackBeansOwned == 1f)
        {
            bbText.text = "Owned";
        }

        if (lentilsOwned == 1f)
        {
            lText.text = "Owned";
        }

        if (greenBeansOwned == 1f)
        {
            greenbText.text = "Owned";
        }

        if (garbanzoBeansOwned == 1f)
        {
            garbanzobText.text = "Owned";
        }

        if (jellyBeansOwned == 1f)
        {
            jbText.text = "Owned";
        }
    }

    public void refriedBeansFunction()
    {
        ballMaterial = "refriedBeansMaterial";
        PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 100f && pintoBeansOwned != 1f)
        {
            ballMaterial = "pintoBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            pintoBeansOwned = 1f;
            PlayerPrefs.SetFloat("pintoBeansOwned", pintoBeansOwned);
            coinBonus.coins -= 100f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("pintoBeansOwned") == 1f)
        {
            ballMaterial = "pintoBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 200f && limaBeansOwned != 1f)
        {
            ballMaterial = "limaBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            limaBeansOwned = 1f;
            PlayerPrefs.SetFloat("limaBeansOwned", limaBeansOwned);
            coinBonus.coins -= 200f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("limaBeansOnwed") == 1f)
        {
            ballMaterial = "limaBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void kidneyBeansFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 375 && kidneyBeansOwned != 1f)
        {
            ballMaterial = "kidneyBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            kidneyBeansOwned = 1f;
            PlayerPrefs.SetFloat("kidneyBeansOwned", kidneyBeansOwned);
            coinBonus.coins -= 200f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("kidneyBeansOwned") == 1f)
        {
            ballMaterial = "kidneyBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void blackBeansFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 650f && blackBeansOwned != 1f)
        {
            ballMaterial = "blackBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            blackBeansOwned = 1f;
            PlayerPrefs.SetFloat("blackBeansOwned", blackBeansOwned);
            coinBonus.coins -= 650f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("blackBeansOwned") == 1f)
        {
            ballMaterial = "blackBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void lentilsFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 975f && lentilsOwned != 1f)
        {
            ballMaterial = "lentilsMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);
            
            lentilsOwned = 1f;
            PlayerPrefs.SetFloat("lentilsOwned", lentilsOwned);
            coinBonus.coins -= 975f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("lentilsOwned") == 1f)
        {
            ballMaterial = "lentilsMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void greenBeansFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 1250 && greenBeansOwned != 1f)
        {
            ballMaterial = "greenBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            greenBeansOwned = 1f;
            PlayerPrefs.SetFloat("greenBeansOwned", greenBeansOwned);
            coinBonus.coins -= 1250f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("greenBeansOwned") == 1f)
        {
            ballMaterial = "greenBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void garbanzoBeansFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 2000f && garbanzoBeansOwned != 1f)
        {
            ballMaterial = "garbanzoBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            garbanzoBeansOwned = 1f;
            PlayerPrefs.SetFloat("garbanzoBeansOwned", garbanzoBeansOwned);
            coinBonus.coins -= 2000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("garbanzoBeansOwned") == 1f)
        {
            ballMaterial = "garbanzoBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
    }

    public void jellyBeansFunction()
    {
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 5000f && jellyBeansOwned != 1f)
        {
            ballMaterial = "jellyBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

            jellyBeansOwned = 1f;
            PlayerPrefs.SetFloat("jellyBeansOwned", jellyBeansOwned);
            coinBonus.coins -= 5000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

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
        else if (PlayerPrefs.GetFloat("jellyBeansOwned") == 1f)
        {
            ballMaterial = "jellyBeansMaterial";
            PlayerPrefs.SetString("ballMaterial", ballMaterial);

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
}
