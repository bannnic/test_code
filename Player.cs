using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.UpArrow)==true)
        //{
        //    this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        //   // animator.SetFloat("Move", 1f, 0.1f, Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
        //   // animator.SetFloat("Move", 1f, 0.1f, Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow) == true)
        //{
        //    this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        //  //  animator.SetFloat("Direction", -1f, 0.1f, Time.deltaTime);
        //}


        //if (Input.GetKey(KeyCode.RightArrow) == true)
        //{
        //     this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        //  //  animator.SetFloat("Direction", 1f, 0.1f, Time.deltaTime);
        //}

        //if(Input.GetKey(KeyCode.Space))
        //{
        //    this.transform.Translate(Vector3.up * 3.0f * Time.deltaTime);

        //}



    }
}
