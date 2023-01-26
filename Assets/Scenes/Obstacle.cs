using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void OnCollisionEnter(Collision collision) // 물체 충돌하는 메소드 (Collision collision) --> int a 같은 느낌
    {
        Vector3 direction = transform.position - collision.gameObject.transform.position; 
        // direction = 내 위치 - 공의 위치
        direction = direction.normalized * 1000; // 온 방향에 반대방향으로 1000만큼 힘이 부여
        // normalized = 상황에 따라 달라지기 때문에 사용
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
        // 공의 Rigidbody를 가져와서 힘을 부여(direction 방향으로)
    }

    float delta = 0.01f; // 장애물 속도
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {

        float newXPosition = transform.localPosition.x + delta;

        transform.localPosition = new Vector3(newXPosition, transform.localPosition.y, transform.localPosition.z);
        if(transform.position.x < -5)
        {
            delta = 0.01f;
        }
        else if(transform.localPosition.x > 5)
        {
            delta = -0.01f;
        }
    }
}
