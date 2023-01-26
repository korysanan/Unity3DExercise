using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Obstacle
{
    public GameObject stone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float timeCount = 0;

    // Update is called once per frame
    void Update()
    {
        base.Update();
        
        timeCount += Time.deltaTime; // 구간 시간을 잰다.
        if (timeCount > 3) // 구간 시간이 3초가 넘으면 실행
        {
            Instantiate(stone, transform.position, Quaternion.identity); // stone을 만들고 위치는 자신의 위치에서 날라간다
            timeCount = 0; // 실행 후 다시 0으로 초기화
        }
    }
}
