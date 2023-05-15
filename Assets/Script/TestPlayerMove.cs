using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour
{
    [SerializeField] Rigidbody _rigidBody;
    bool isStop = false;
    Vector3 movedir = Vector3.zero;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = this.transform.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0.0f, 0.0f, 50.0f);

        if (rb.velocity.magnitude < 10.0f)
        {
            rb.AddForce(force);
        }

    }
}