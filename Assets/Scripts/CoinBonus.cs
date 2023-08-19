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
        multiplier += 1f;
    }
    void Update()
    {
        if (cfm.strikeBonus == true)
        {
            cfm.strikeBonus = false;
            coins += 100f * multiplier;
            multiplier += 0.5f;
        }
        else if (cfm.spareBonus == true)
        {
            cfm.spareBonus = false;
            coins += 50f * multiplier;
            multiplier += 0.25f;
        }
        else if (cfm.openFrameBonus == true)
        {
            cfm.openFrameBonus = false;
            multiplier = 1f;
        }

        coinText.text = ("Coins: " + coins);
        coinMultiplierText.text = ("Multiplier: " + multiplier);
    }
}
