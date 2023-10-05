using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowControlScript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");

        DealWithHits thingIHit = collision.gameObject.GetComponent<DealWithHits>();
        if (thingIHit != null)
        {
            thingIHit.IHitYou();
        }

    }

    internal void ImThrowingYou(bearControl bearControl)
    {
       transform.position = bearControl.transform.position + 2* Vector3.up + 3 * bearControl.transform.forward;
        rb = GetComponent<Rigidbody>();

        rb.velocity = 10 * (2 * Vector3.up + 3 * bearControl.transform.forward);


    }
}
