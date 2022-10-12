using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Collision : MonoBehaviour
{
    //충돌시 사용할 힘의 크기
    public float force = 500;


     void OnCollisionEnter(Collision collided)
    {
        //힘을 가할 방향
        Vector3 direction = new Vector3(0, 1f, 1f);


        //충돌 물체의 Tag가 "ground"일 경우
        if (collided.collider.CompareTag("ground"))
        {
            //오디오 실행
            GetComponent<AudioSource>().Play();

            //힘을 가함
            GetComponent<Rigidbody>().AddForce(direction * force);
        }
            
        //충돌체 이름 출력
        Debug.Log(collided.gameObject.name);


    }

}
