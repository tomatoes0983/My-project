using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpvelo = 10;
    public bool canjump = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canjump)
        {
            canjump = false;
            rb.AddForce(0,jumpvelo,0,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        canjump = true;
    }



}
