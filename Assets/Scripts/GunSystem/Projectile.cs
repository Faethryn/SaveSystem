using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ForwardsMovement();
    }

    private void ForwardsMovement()
    {
        transform.position += speed * this.transform.forward *Time.deltaTime;
    }
}
