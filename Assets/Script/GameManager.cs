using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Sphere;
    private float timeAfter = 0;

    void Update()
    {
        //시간 측정
         timeAfter += Time.deltaTime;

        //1초가 지나면 Sphere 활성화
        if (timeAfter > 1)     
            Sphere.SetActive(true);

    }
}
