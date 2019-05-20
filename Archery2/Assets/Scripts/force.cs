using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    Rigidbody rigidB;
    public float shootForce = 2000;
    // Start is called before the first frame update
    void Enable()
    {
        rigidB = GetComponent<Rigidbody>();
        rigidB.velocity = Vector3.zero;
        ApplyForce();
    }

    // Update is called once per frame
    void Update()
    {
        SpinObjectInAir();
    }

    void ApplyForce()
    {
        rigidB.AddRelativeForce(Vector3.forward * shootForce);

    }

    void SpinObjectInAir()
    {
        //spin arrow
    }
}
