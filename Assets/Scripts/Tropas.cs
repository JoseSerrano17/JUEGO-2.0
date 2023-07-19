using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tropas : MonoBehaviour
{

    [SerializeField] protected TroopsData data; //Data
    protected int hp; //Currently HP
    protected Rigidbody2D rBody;
    
    private void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        hp = data.gethp();
    }


    protected void takeDamage(int dmg)
    {
        hp = hp - dmg;

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public float getcd()
    {
        return data.getcoolDown();
    }

}
