using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int coins = 0;

    

    // Update is called once per frame
    void Update()
    {

        // if all the coins are collected, end the level and show the "Level Complete" scene
        if (coins >=6)
            SceneManager.LoadScene("Level Complete");

        // This will update the "Coins Collected" text everytime a coin is picked up
        CoinText.text = "Coins Collected:" + coins;
    }
}
