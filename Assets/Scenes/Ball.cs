using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float startingPoint; // startingPoint 변수 선언

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start"); // 시작할때 콘솔에 start 표시
        startingPoint = transform.position.z; // startingPoint를 처음 z좌표로 선언 
    }

    // Update is called once per frame
    void Update()
    {
        float distance; // distance 변수 선언
        distance = transform.position.z - startingPoint; // 현재 z좌표에서 처음 z좌표를 뺀 값

        if (Input.GetKeyDown(KeyCode.Space)){  // space키를 눌렀을 때
            GetComponent<Rigidbody>().AddForce(Vector3.up*100); // rigidbody컴포넌트를 얻는다. 위쪽 방향으로 100만큼의 힘을 갖는다.
            /*

            Rigidbody ballRigid;
            ballRigid = gameObject.GetComponent<Rigidbody>();
            ballRigid.AddForce(Vector3.up*100)
            */
        }
        
    }
}
