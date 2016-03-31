using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
    private Rigidbody rb;
    private Transform trans;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
        rb.velocity = trans.forward * speed;
    }
}
