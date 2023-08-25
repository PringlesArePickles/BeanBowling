using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinBonus : MonoBehaviour
{
    public CheckForMovement cfm;

    public float coins;
    public float multiplier;

    public Text coinText;
    public Text coinMultiplierText;
    void Start()
    {
        multiplier = 1;
        //PlayerPrefs.SetFloat("multiplier", multiplier);
        multiplier = PlayerPrefs.GetFloat("multiplier", 1);
    }
    void Update()
    {
        if (cfm.strikeBonus == true)
        {
            cfm.strikeBonus = false;
            coins += 100f * multiplier;
            PlayerPrefs.SetFloat("coins", coins);
            multiplier += 0.5f;
            PlayerPrefs.SetFloat("multiplier", multiplier);
            multiplier = PlayerPrefs.GetFloat("multiplier");
        }
        else if (cfm.spareBonus == true)
        {
            cfm.spareBonus = false;
            coins += 50f * multiplier;
            PlayerPrefs.SetFloat("coins", coins);
            multiplier += 0.25f;
            PlayerPrefs.SetFloat("multiplier", multiplier);
            multiplier = PlayerPrefs.GetFloat("multiplier");
        }
        else if (cfm.openFrameBonus == true)
        {
            cfm.openFrameBonus = false;
            multiplier = 1f;
            PlayerPrefs.SetFloat("multiplier", multiplier);
            multiplier = PlayerPrefs.GetFloat("multiplier");
        }

        coinText.text = ("Coins: " + PlayerPrefs.GetFloat("coins"));
        coinMultiplierText.text = ("Multiplier: " + PlayerPrefs.GetFloat("multiplier"));
    }

    public void SetCoins()
    {
        PlayerPrefs.SetFloat("coins", coins);
    }
}
