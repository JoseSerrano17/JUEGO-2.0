using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

public class Aldea : MonoBehaviour
{
    [SerializeField] private GameObject tropa1;
    [SerializeField] private GameObject tropa2;
    [SerializeField] private GameObject tropa3;
   
    //Tropa1
    private float coolDownTroop1;
    private bool inCoolDown_Tropa1;
    private float lastTimeSpawned_Tropa1;

    //Tropa2
    private float coolDownTroop2;
    private bool inCoolDown_Tropa2;
    private float lastTimeSpawned_Tropa2;

    //Tropa3
    private float coolDownTroop3;
    private bool inCoolDown_Tropa3;
    private float lastTimeSpawned_Tropa3;


    // Start is called before the first frame update
    void Start()
    {
        //Tropa1
        coolDownTroop1 = tropa1.GetComponent<Tropa1>().getcd();
        inCoolDown_Tropa1 = false;
        lastTimeSpawned_Tropa1 = 0;

        //Tropa2
        coolDownTroop2 = tropa2.GetComponent<Tropa2>().getcd();
        inCoolDown_Tropa2 = false;
        lastTimeSpawned_Tropa2 = 0;

        //Tropa3
        coolDownTroop3 = tropa3.GetComponent<Tropa3>().getcd();
        inCoolDown_Tropa3 = false;
        lastTimeSpawned_Tropa3 = 0;
    }


    // Update is called once per frame
    void Update()
    {
        //Check for CDs
        checkCDs();
       
        //Check for spawn
        if (Input.GetKeyUp(KeyCode.Alpha1) )
        {          
            spawnTroop1();
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {           
            spawnTroop2();
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {         
            spawnTroop3();
        }     
    }

    private void spawnTroop1()
    {
        if(!inCoolDown_Tropa1)
        {
            lastTimeSpawned_Tropa1 = Time.time;
            inCoolDown_Tropa1 = true;
            Instantiate(tropa1, this.transform.position, this.transform.rotation);
        }      
    }

    private void spawnTroop2()
    {
        if(!inCoolDown_Tropa2)
        {
            lastTimeSpawned_Tropa2 = Time.time;
            inCoolDown_Tropa2 = true;
            Instantiate(tropa2, this.transform.position, this.transform.rotation);
        }      
    }

    private void spawnTroop3()
    {
        if(!inCoolDown_Tropa3)
        {
            lastTimeSpawned_Tropa3 = Time.time;
            inCoolDown_Tropa3 = true;
            Instantiate(tropa3, this.transform.position, this.transform.rotation);
        }      
    }

    private void checkCDs()
    {
        //Tropa1
        if(inCoolDown_Tropa1 && (Time.time - lastTimeSpawned_Tropa1) >= coolDownTroop1) {
            inCoolDown_Tropa1 = false;
        }

        //Tropa2
        if (inCoolDown_Tropa2 && (Time.time - lastTimeSpawned_Tropa2) >= coolDownTroop2)
        {
            inCoolDown_Tropa2 = false;
        }

        //Tropa3
        if (inCoolDown_Tropa3 && (Time.time - lastTimeSpawned_Tropa3) >= coolDownTroop3)
        {
            inCoolDown_Tropa3 = false;
        }

    }
}
