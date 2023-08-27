using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject bullet;
    public GameObject point;
    public int speed;

    private void Start()
    {
     
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(x * speed*Time.deltaTime,0,y * speed * Time.deltaTime);

        transform.rotation = Quaternion.Euler(0,Input.mousePosition.x,0);

        if (Input.GetMouseButtonDown(0)){
            Instantiate(bullet,point.transform.position, transform.rotation);
                }

    }
}
