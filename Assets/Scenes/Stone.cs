using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Vector3 target; // target에 3차원 좌표
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.position;   // 타겟은 공이며 그 공의 위치
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.01f); // 돌이 타겟으로 날라오는 코드
        transform.Rotate(new Vector3(0, 0, 5)); // 공이 회전
    }

    void OnTriggerEnter(Collider collider) // 타겟에 맞았을 때 게임 재시작
    {
        if(collider.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RestartGame");
        }
    }
}
