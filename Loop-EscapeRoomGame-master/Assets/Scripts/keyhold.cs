using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyhold : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;//获取玩家组件
    private void OnTriggerEnter(Collider other)//这里Other指的是与钥匙接触的物体（即玩家）
    {
        if (other.transform == player)
        {
            other.GetComponent<player>().IsKeyhold = true;//采用GetComponent方法获取玩家脚本中的bool值并且进行修改
            Destroy(gameObject);
        }
    }
}