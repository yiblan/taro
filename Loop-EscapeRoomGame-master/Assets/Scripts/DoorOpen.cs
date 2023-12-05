using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator animator;
    public Transform player;
    private bool isInRange = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.Q))
        {
            PlayAnimation();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player && other.GetComponent<player>().IsKeyhold)
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            isInRange = false;
        }
    }

    void PlayAnimation()
    {
        animator.SetTrigger("opening");
    }
}
