using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    public Transform player;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player && other.GetComponent<player>().IsKeyhold)//玩家拿到钥匙，进入碰撞区，播放动画
        {
            animator.SetTrigger("opening");
        }
    }
}