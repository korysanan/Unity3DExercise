using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject[] coins = GameObject.FindGameObjectsWothTag("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position;
    }
}
