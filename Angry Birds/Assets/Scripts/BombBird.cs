﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBird : Bird
{
    public float fieldofimpact;

    public float force;

    public LayerMask LayerToHit;

    void start()
    {

    }

    void update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            explode();
        }
    }

    void explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position,fieldofimpact,LayerToHit);

        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;
            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,fieldofimpact);
    }

    public override void OnTap()
    {
        explode();
    }
}
