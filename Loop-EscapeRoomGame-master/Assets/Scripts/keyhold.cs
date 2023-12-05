using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHold : MonoBehaviour
{
    public Transform player; // ��ȡ������
    public float interactionDistance = 30f; // ʰȡ��������
    private bool isInRange = false;

    // Update is called once per frame
    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            PickUpKey();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
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

    void PickUpKey()
    {
        player.GetComponent<player>().IsKeyhold = true;
        Destroy(gameObject);
    }
}
