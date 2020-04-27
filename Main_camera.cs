using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_camera : MonoBehaviour
{ 
    public float rotateSpeed = 10.0f;

    public float zoomSpeed = 10.0f;

    private Camera mainCamera;


    public AudioSource ClockAudio;
    public AudioClip clockAudio;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GetComponent<Camera>();
        this.ClockAudio = this.gameObject.AddComponent<AudioSource>();
        this.ClockAudio.clip = clockAudio;
        this.ClockAudio.loop = true;
        this.ClockAudio.Play();
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if (distance != 0)
        {
            mainCamera.fieldOfView += distance;
        }


    }

    private void Rotate()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 rot = transform.rotation.eulerAngles; // 현재 카메라의 각도를 Vector3로 반환
            //rot.y += Input.GetAxis("Mouse X") * rotateSpeed; // 마우스 X 위치 * 회전 스피드
            rot.x += -1 * Input.GetAxis("Mouse Y") * rotateSpeed; // 마우스 Y 위치 * 회전 스피드
            Quaternion q = Quaternion.Euler(rot); // Quaternion으로 변환
            q.z = 0;
            //transform.rotation = Quaternion.Slerp(transform.rotation, q, 2f); // 자연스럽게 회전
        }


        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            transform.Translate(0, 0, -0.1f);
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            transform.Translate(0, 0, 0.1f);
        }
        //if (Input.GetMouseButton(0))
        //{
        //    if (Input.GetAxis("Mouse X") < 0)
        //    {
        //        transform.Translate(0.1f, 0, 0);
        //    }
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    if (Input.GetAxis("Mouse X") > 0)
        //    {
        //        transform.Translate(-0.1f, 0, 0);
        //    }
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    if (Input.GetAxis("Mouse Y") < 0)
        //    {
        //        transform.Translate(0, 0.1f, 0);
        //    }
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    if (Input.GetAxis("Mouse Y") > 0)
        //    {
        //        transform.Translate(0, -0.1f, 0);
        //    }
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    if (Input.GetAxis("Mouse X") > 0)
        //    {
        //        transform.Rotate(0, 0.5f, 0, Space.World);
        //        transform.Translate(-0.17f, 0, 0);
        //    }
        //}
        //if (Input.GetMouseButton(1))
        //{
        //    if (Input.GetAxis("Mouse X") < 0)
        //    {
        //        transform.Rotate(0, -0.5f, 0, Space.World);
        //        transform.Translate(0.17f, 0, 0);
        //    }
        //}
    }


    // Update is called once per frame
    void Update()
    {
        Zoom();
        Rotate();

        if (Time.timeScale == 0)
        {
            this.ClockAudio.Stop();
            this.ClockAudio.loop = false;
        }

    }
}


