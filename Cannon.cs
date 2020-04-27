using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //public GameObject prefab;   // 공을 담아두기 위한 변수
    public float power;
    public float rotspeed = 120.0f;// 공을 날리는 힘
    public float interval;

    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        Destroy(gameObject, 3.8f);
       // StartCoroutine(a());
       
    }

    // Update is called once per frame
    void Update()
    {

        //float amtToMove = power * Time.deltaTime;
        //float amtToRot = rotspeed * Time.deltaTime;


        //float front = Input.GetAxis("Vetrical");
        //float and = Input.GetAxis("Horizontal");
        //float ang2 = Input.GetAxis("MyCore");

        //transform.Translate(Vector3.forward * front * amtToMove);
        //transform.Rotate(Vector3.up * ang2 * amtToRot);
        //transform.Rotate(Vector3.up * ang2 * amtToRot);



         tr.Translate(Vector3.forward * power * Time.deltaTime);
    }

    //IEnumerator a()
    //{ 
    //    while(true)
    //    {

    //        GameObject bullet = LoadBullet();
    //        yield return new WaitForSeconds(2.0f);
    //    }
   
       
    //}


    //GameObject LoadBullet()
    //{
    //    var bullet = GameObject.Instantiate(prefab) as GameObject;
    //    bullet.transform.parent = transform;
    //    bullet.transform.localPosition = Vector3.zero;
    //    return bullet;
    //}
}
