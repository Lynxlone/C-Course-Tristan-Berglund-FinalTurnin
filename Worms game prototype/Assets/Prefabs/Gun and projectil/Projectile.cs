using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{

    public Rigidbody projectile;
    public float speed = 20;

    public void Start()
    {
      //  Rigidbody.AddForce(projectile * speed * Time.fixedDeltaTime);
    }

    public void Awake()
    {
        GetComponent<Collider>().enabled = false;
        Invoke("ActivateCollision", 0.6f);
    }

    public void ActivateCollision()
    {
        GetComponent<Collider>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

       
        {
           

        }
    }
}