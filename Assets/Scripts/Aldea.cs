using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aldea : MonoBehaviour
{
    [SerializeField] private GameObject tropa1;
    [SerializeField] private GameObject tropa2;
    [SerializeField] private GameObject tropa3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check for spawn
        if (Input.GetKeyUp(KeyCode.Alpha1))
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

    public void spawnTroop1()
    {
        Instantiate(tropa1, this.transform.position, this.transform.rotation);
     

    }

    public void spawnTroop2()
    {
        Instantiate(tropa2, this.transform.position, this.transform.rotation);

    }

    public void spawnTroop3()
    {
        Instantiate(tropa3, this.transform.position, this.transform.rotation);

    }
}
