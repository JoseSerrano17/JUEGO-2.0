using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Troop Data", menuName ="Troops Data")]
public class TroopsData : ScriptableObject
{
    //Stats
    [SerializeField] private int maxHP;             //Max Health Points
    [SerializeField] private int dmg;               //Damage
    [SerializeField] private int speed;             //Movement Speed
    [SerializeField] private int magicResistance;   //Magic Resistance
    [SerializeField] private int armor;             //Armor
    [SerializeField] private float attackSpeed;     //Attack Speed
    [SerializeField] private float attackRange;     //Attack Range
    [SerializeField] private int magicPenetration;  //Magic Penetration
    [SerializeField] private int armorPenetration;  //Armor Penetration
    [SerializeField] private float coolDown;        //CoolDown
    [SerializeField] private float goldCost;        //Coste de oro
    [SerializeField] private float woodCost;        //Coste de madera
    [SerializeField] private float foodCost;        //Coste de comida
    [SerializeField] private float knowledgeCost;   //Coste de conocimiento

    public int gethp()
    {
        return maxHP;
    }

    public int getdmg()
    {
        return dmg;
    }

    public int getspeed()
    {
        return speed;
    }

    public int getmagicResistance()
    {
        return magicResistance;
    }

    public int getarmor()
    {
        return armor;
    }

    public float getattackSpeed()
    {
        return attackSpeed;
    }
    public float getattackRange()
    {
        return attackRange;
    }

    public int getmagicPenetration()
    {
        return magicPenetration;
    }

    public int getarmorPenetration()
    {
        return armorPenetration;
    }

    public float getcoolDown()
    {
        return coolDown;
    }
    
   public float getGoldCost()
    {
        return goldCost;
    }

    public float getWoodCost()
    {
        return woodCost;
    }

    public float getFoodCost()
    {
        return foodCost;
    }

    public float getKnowledgeCost()
    {
        return knowledgeCost;
    }
}
