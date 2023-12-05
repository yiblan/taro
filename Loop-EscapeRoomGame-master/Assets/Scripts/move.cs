using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class move : MonoBehaviour
{

    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
    }
}
