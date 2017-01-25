using UnityEngine;
using System.Collections;

public class Ball_Physics : MonoBehaviour {
    public Rigidbody rb;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
}
