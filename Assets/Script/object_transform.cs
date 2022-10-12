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
        //transform Ŭ���� : ��ü�� ��ġ�� �̵��ϰų� ȸ���� �� ���
        if (Input.GetKeyDown(KeyCode.A))
        {
            float rnd = Random.Range(-0.2f, 0.2f);
            //this : ��ũ��Ʈ�� ����� ��ü�� �ǹ�, ���� ����
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
        //Mass : ����, Drag : ��������, Angular Drag ȸ�������
        //Is Kinematic : ���� ���� X, �浹üũ ����
        //Interpolate ��ü�� ������ ����ġ�� ���ܺ��ϰ�� ���
        if (Input.GetKey(KeyCode.Space))
        {
            float rnd = Random.Range(0.0f, 15.0f);
            rigidbody.AddForce(0f, rnd, 0f);
        }

        //��� ��ü�� �÷��� ���ɰ� ������� �׻� ������ �ӵ��� �̵��ؾ���
        //TIme.deltaTime : ���� �����Ӱ� ���� ������ ������ �ҿ�ð�
        // �� ������ �̵��Ÿ� = �ӵ� X Time.deltaTime
        //if (Input.GetKey(KeyCode.UpArrow))
        //    this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        //����Ƽ�� �޼� ��ǥ�踦 ���

        //�� �⺻���� �߽����� ȸ���� ���� ����
        if (Input.GetKey(KeyCode.R))
            this.transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
