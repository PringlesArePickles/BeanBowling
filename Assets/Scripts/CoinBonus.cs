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
        /*multiplier = PlayerPrefs.GetFloat("multiplier", 1);
        PlayerPrefs.SetFloat("multiplier", multiplier);*/
    }
    void Update()
    {
        multiplier = PlayerPrefs.GetFloat("multiplier", 1f); //setting and getting player prefs
        PlayerPrefs.SetFloat("multiplier", multiplier);
        coins = PlayerPrefs.GetFloat("coins");
        PlayerPrefs.SetFloat("coins", coins);

        coinText.text = ("Coins: " + Mathf.Round(PlayerPrefs.GetFloat("coins"))); //updating text
        coinMultiplierText.text = ("Multiplier: " + PlayerPrefs.GetFloat("multiplier", 1f));

        if (cfm.strikeBonus == true)
        {
            cfm.strikeBonus = false; //make it not run again
            coins = PlayerPrefs.GetFloat("coins"); // get coins as the player pref key "coins"
            coins += 100f * PlayerPrefs.GetFloat("multiplier"); /* (100f * multiplier) */
            PlayerPrefs.SetFloat("coins", coins); // set coins to the the player pref key "coins"
            multiplier = PlayerPrefs.GetFloat("multiplier", 1f); // get mulitplier as the player pref key "multiplier"
            multiplier += 0.5f;
            PlayerPrefs.SetFloat("multiplier", multiplier); 
        }
        else if (cfm.spareBonus == true)
        {
            cfm.spareBonus = false;
            coins = PlayerPrefs.GetFloat("coins");
            coins += 50f * PlayerPrefs.GetFloat("multiplier");
            PlayerPrefs.SetFloat("coins", coins);
            multiplier = PlayerPrefs.GetFloat("multiplier", 1f);
            multiplier += 0.25f;
            PlayerPrefs.SetFloat("multiplier", multiplier);
        }
        else if (cfm.openFrameBonus == true)
        {
            cfm.openFrameBonus = false;
            multiplier = 1f;
            PlayerPrefs.SetFloat("multiplier", multiplier);
        }
        coinText.text = ("Coins: " + Mathf.Round(PlayerPrefs.GetFloat("coins")));
        coinMultiplierText.text = ("Multiplier: " + PlayerPrefs.GetFloat("multiplier"));
    }

    public void SetCoins()
    {
        coins = PlayerPrefs.GetFloat("coins");
        PlayerPrefs.SetFloat("coins", coins);
    }
}
