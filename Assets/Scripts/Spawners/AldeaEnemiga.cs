using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AldeaEnemiga : MonoBehaviour
{
    [SerializeField] private GameObject enemigo1;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Check for spawn
        if (Input.GetKeyUp(KeyCode.K)) //Uses key 'K'
        {
            Instantiate(enemigo1, this.transform.position, this.transform.rotation);

        }

    }

}
