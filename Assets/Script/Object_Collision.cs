using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Collision : MonoBehaviour
{
    //�浹�� ����� ���� ũ��
    public float force = 500;


     void OnCollisionEnter(Collision collided)
    {
        //���� ���� ����
        Vector3 direction = new Vector3(0, 1f, 1f);


        //�浹 ��ü�� Tag�� "ground"�� ���
        if (collided.collider.CompareTag("ground"))
        {
            //����� ����
            GetComponent<AudioSource>().Play();

            //���� ����
            GetComponent<Rigidbody>().AddForce(direction * force);
        }
            
        //�浹ü �̸� ���
        Debug.Log(collided.gameObject.name);


    }

}
