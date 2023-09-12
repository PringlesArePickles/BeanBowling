using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    [Header("integers")]
    private int amountUpgraded;
    private int canUpgrade;
    [Header("script references")]
    public CoinBonus coinBonus;
    public BallThrow ballThrow;

    [Header("texts")]
    public Text upgradeText;

    [Header("buttons")]
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.GetFloat("throwPower", 185f);
        ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower", 185f);
        PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("amountUpgraded") == 5)
        {
            upgradeText.text = "Max";
        }
        
    }

    public void Upgrade1()
    {
        amountUpgraded = PlayerPrefs.GetInt("amountUpgraded", 0);
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 1000f)
        {
            button1.SetActive(false);

            coinBonus.coins -= 1000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins); 

            ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower");
            ballThrow.throwPower += 65f;
            PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);

            amountUpgraded ++;
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
            Debug.Log("upgrade 1");
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
        }
    }

    public void Upgrade2()
    {
        amountUpgraded = PlayerPrefs.GetInt("amountUpgraded");
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 1000f)
        {
            button2.SetActive(false);

            coinBonus.coins -= 1000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

            ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower");
            ballThrow.throwPower += 50f;
            PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);

            amountUpgraded ++;
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
            Debug.Log("upgrade 2");
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
        }
    }

    public void Upgrade3()
    {
        amountUpgraded = PlayerPrefs.GetInt("amountUpgraded");
        coinBonus.coins = PlayerPrefs.GetFloat("coins");
        
        if (coinBonus.coins >= 1000f)
        {
            button3.SetActive(false);

            coinBonus.coins -= 1000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

            ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower");
            ballThrow.throwPower += 35f;
            PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);

            amountUpgraded ++;
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
            Debug.Log("upgrade 3");
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
        }
    }

    public void Upgrade4()
    {
        amountUpgraded = PlayerPrefs.GetInt("amountUpgraded");
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 1000f)
        {
            button4.SetActive(false);

            coinBonus.coins -= 1000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

            ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower");
            ballThrow.throwPower += 25f;
            PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);

            amountUpgraded ++;
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
            Debug.Log("upgrade 4");
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
        }
    }

    public void Upgrade5()
    {
        amountUpgraded = PlayerPrefs.GetInt("amountUpgraded");
        coinBonus.coins = PlayerPrefs.GetFloat("coins");

        if (coinBonus.coins >= 1000f && canUpgrade != 1)
        {
            button5.SetActive(false);

            coinBonus.coins -= 1000f;
            PlayerPrefs.SetFloat("coins", coinBonus.coins);

            ballThrow.throwPower = PlayerPrefs.GetFloat("throwPower");
            ballThrow.throwPower += 15f;
            PlayerPrefs.SetFloat("throwPower", ballThrow.throwPower);

            amountUpgraded ++;
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
            Debug.Log("upgrade 5");
            PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
        }
    }

    public void increaseAmountUpgraded()
    {
        amountUpgraded ++;
        PlayerPrefs.SetInt("amountUpgraded", amountUpgraded);
    }
}
