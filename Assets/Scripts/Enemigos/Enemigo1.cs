using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : Tropas
{
    [SerializeField] private TroopsData data;


    private void FixedUpdate()
    {
        rBody.velocity = new Vector2(data.getspeed()*-1, rBody.velocity.y);
        if (rBody.velocity.y <= -50)
        {
            takeDamage(100);
        }

    }
}
