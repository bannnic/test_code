using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_core : MonoBehaviour
{
    public Transform firePos;
    //public GameObject firePos;

    public GameObject core;
    // public Transform core_1;
    public float interval;


    // public GameObject fire_pos;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            Instantiate(core, transform.position, transform.rotation);
            //Transform mycore = (Transform)Instantiate(core_1,
            //    firePos.transform.position,
            //    firePos.transform.rotation
            //    );
            //mycore.


            //Transform mycore = (Transform)Instantiate(core,fire_pos.transform.position, fire_pos.transform.rotation);
            
            yield return new WaitForSeconds(interval);      
        }

    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
