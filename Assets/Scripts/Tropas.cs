using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropas : MonoBehaviour
{
    protected int hp; //Actual HP
     protected Rigidbody2D rBody;
    
    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }  
 
    protected void takeDamage(int dmg)
    {
        hp = hp - dmg;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

}
