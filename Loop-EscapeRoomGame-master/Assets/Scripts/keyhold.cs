using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyhold : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;//��ȡ������
    private void OnTriggerEnter(Collider other)//����Otherָ������Կ�׽Ӵ������壨����ң�
    {
        if (other.transform == player)
        {
            other.GetComponent<player>().IsKeyhold = true;//����GetComponent������ȡ��ҽű��е�boolֵ���ҽ����޸�
            Destroy(gameObject);
        }
    }
}