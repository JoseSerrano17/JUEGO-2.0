using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropa3 : TropasAliadas
{

    [SerializeField] private AlliesData data;


    private void FixedUpdate()
    {
        rBody.velocity = new Vector2(data.getspeed(), rBody.velocity.y);
       
        if (rBody.velocity.y <= -50)
        {
            takeDamage(100);
        }


    }
}
