using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_transform : MonoBehaviour
{
    private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform 클래스 : 물체의 위치를 이동하거나 회전할 떄 사용
        if (Input.GetKeyDown(KeyCode.A))
        {
            float rnd = Random.Range(-0.2f, 0.2f);
            //this : 스크립트가 연결된 물체를 의미, 생략 가능
            this.transform.position += new Vector3(rnd, rnd, rnd);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            float rnd = Random.Range(0.0f, 360.0f);
            this.transform.rotation = Quaternion.Euler(rnd, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            float rnd = Random.Range(0.5f, 1.5f);
            this.transform.localScale = new Vector3(rnd, rnd, rnd);
        }


        //Rigidbody
        //Mass : 질량, Drag : 공기저항, Angular Drag 회전운동저항
        //Is Kinematic : 물리 적용 X, 충돌체크 수행
        //Interpolate 물체의 움직이 지나치게 끊겨보일경우 사용
        if (Input.GetKey(KeyCode.Space))
        {
            float rnd = Random.Range(0.0f, 15.0f);
            rigidbody.AddForce(0f, rnd, 0f);
        }

        //모든 물체는 플랫폼 성능과 상관없이 항상 일정한 속도로 이동해야함
        //TIme.deltaTime : 직전 프레임과 현재 프레임 사이의 소요시간
        // 매 프레임 이동거리 = 속도 X Time.deltaTime
        //if (Input.GetKey(KeyCode.UpArrow))
        //    this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        //유니티는 왼손 좌표계를 사용

        //각 기본축을 중심으로 회전할 각도 지정
        if (Input.GetKey(KeyCode.R))
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
