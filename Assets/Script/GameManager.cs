using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Sphere;
    private float timeAfter = 0;

    void Update()
    {
        //�ð� ����
         timeAfter += Time.deltaTime;

        //1�ʰ� ������ Sphere Ȱ��ȭ
        if (timeAfter > 1)     
            Sphere.SetActive(true);

    }
}
