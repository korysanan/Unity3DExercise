using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinText;
    int coinCount = 0;

    void GetCoin()
    {
        coinCount ++;
        coinText.text = coinCount + "개";
        Debug.Log("동전:" + coinCount);
    }

    void RestartGame()
    {
        // Application.LoadLevel("SampleScene");
        Debug.Log("Game Over!");
    }

    void RedCoinStart()
    {
        DestroyObstacles();
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");

        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
