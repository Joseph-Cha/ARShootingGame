using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{

    private Rigidbody Rigidbody;

    public float force = 10f;
    public float xforce = 1f;
    public float zforce = 2f;


    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Jump();
    }

    void Jump()
    {
        Rigidbody.AddForce(new Vector3(Random.Range(-xforce, xforce), force, Random.Range(-zforce, zforce)));
    }
}
