using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))            //���콺 ��Ŭ��(0�� ��ư)�� ���� ��
        {
            ShootRay();                            //���� �߻� �Լ� ȣ��
        }
    }

    void ShootRay()
    {
        Ray ray = new Ray(transform.position, transform.forward);    //�߻��� Ray�� ������, ���� ���� (���� ī�޶󿡼� ���콺 Ŀ�� �������� �߻�)
        RaycastHit hit;                                                 //Ray�� ���� ����� ������ ������ ���弭

        if(Physics.Raycast(ray, out hit))                               //Raycast�� ��ȯ���� bool��, Ray�� �¾Ҵٸ� true ��ȯ
        {
            Destroy(hit.collider.gameObject);                           //���� ��� ������Ʈ�� ����
        }
    }
}
