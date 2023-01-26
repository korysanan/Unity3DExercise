using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RedCoinStart");
            Destroy(gameObject); // 이 스크립트가 추가된 gameObject = coin을 없애라
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
