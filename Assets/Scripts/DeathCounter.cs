using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour {

    public void resetCounter()
    {
        PlayerPrefs.SetInt("coins", 0);
    }

    public void addDeath(int number)
    {
        int coins = PlayerPrefs.GetInt("coins", 0);
        coins += number;
        Debug.Log(coins);
        PlayerPrefs.SetInt("coins", coins);

    }

    public int getDeathNumber()
    {
        return PlayerPrefs.GetInt("coins", 0);
    }

}
