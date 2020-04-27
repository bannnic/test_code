using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_control : MonoBehaviour
{
    public Text gold_bar_Text;
    int gold_b=0;
    bool bIsRedDoor;
    bool bIsBlueDoor;
    bool bIspurpleDoor;

    private bool isPause = false;

    //소리 넣자
    //피격사운드
    public AudioSource Attackudio;
    public AudioClip attack_Sound;
    bool at_sound = false;
    //pick up 사운드
    public AudioSource Pickaudio;
    public AudioClip pick_Sound;
    bool pi_sound = false;
    //clear sound
    public AudioSource Clearaudio;
    public AudioClip clear_Sound;
    bool clear_sound = false;

    //fail sound
    public AudioSource Failaudio;
    public AudioClip fail_Sound;
    bool fail_sound = false;



    //승리
    //패배
    public Text gameClearText;
    public Text gameEdText;

    public GameObject title_button;
    public GameObject restart_button;
    public GameObject end_button;

    //hp slider
    public Slider healthBarSlider;


    //처음 입구 가로 막는 해골바가지
    public GameObject big_skell;



    // Start is called before the first frame update
    void Start()
    {

        title_button.SetActive(false);
        restart_button.SetActive(false);
        end_button.SetActive(false);

        gameClearText.enabled = false;

        Time.timeScale = 1;
        isPause = false;

        healthBarSlider.value = 1.0f;

        gold_bar_Text.text = "Gold bar box :" + gold_b;
        //피격사운드
        this.Attackudio = Attackudio.gameObject.AddComponent<AudioSource>();
        this.Attackudio.clip = attack_Sound;
        this.Attackudio.loop = false;
        //Fail.enabled = false;
        //pick사운드
        this.Pickaudio = Pickaudio.gameObject.AddComponent<AudioSource>();
        this.Pickaudio.clip = pick_Sound;
        this.Pickaudio.loop = false;
        //clear사운드
        this.Clearaudio = Clearaudio.gameObject.AddComponent<AudioSource>();
        this.Clearaudio.clip = clear_Sound;
        this.Clearaudio.loop = false;
        this.Clearaudio.volume = 0.4f;
        //fail 사운드
        this.Failaudio = Failaudio.gameObject.AddComponent<AudioSource>();
        this.Failaudio.clip = fail_Sound;
        this.Failaudio.loop = false;

    }

    // Update is called once per frame
    void Update()
    {

        gold_bar_Text.text = "Gold bar box :" + gold_b + "/4";

        if (bIsBlueDoor == true)
        {
            this.transform.position = new Vector3(24.0f, 0.0f, 4.0f);
            bIsBlueDoor = false;
        }

        if (bIsRedDoor == true)
        {
            this.transform.position = new Vector3(28.0f, 0.0f, 34.0f);
            bIsRedDoor = false;
        }

        if (bIspurpleDoor == true)
        {
            this.transform.position = new Vector3(15.0f, 0.0f, 16.0f);

            bIspurpleDoor = false;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            gold_b = 4;
            
        }


        if (healthBarSlider.value == 0)
        {
            title_button.SetActive(true);
            restart_button.SetActive(true);
            end_button.SetActive(true);

            gameEdText.enabled = true;
            Time.timeScale = 0;

            Failaudio.Play();
            Failaudio.loop = true;

            healthBarSlider.value =0.01f;
        }


    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gold_bar")
        {
            Destroy(other.gameObject);
            gold_b = gold_b + 1;
            this.Pickaudio.Play();

        }

        if (other.gameObject.CompareTag("doorb"))
        {
            bIsBlueDoor = true;

        }

        if (other.gameObject.CompareTag("doorr"))
        {
            bIsRedDoor = true;
        }

        if (other.gameObject.CompareTag("purple_door"))
        {
            bIspurpleDoor = true;
        }

        if (other.tag == "core")
        {
            Destroy(other.gameObject);
        }

        if (other.tag == "skell")
        {
            Destroy(other.gameObject);
            Destroy(big_skell);
            this.Pickaudio.Play();
        }





        if (other.CompareTag("blade") && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= .031f;
            this.Attackudio.Play();


        }



        if (other.tag =="npc")
        {
            if (gold_b == 4)
            {

                title_button.SetActive(true);
                restart_button.SetActive(true);
                end_button.SetActive(true);

                gameClearText.enabled = true;

                Time.timeScale = 0;
                isPause = true;
                this.Clearaudio.Play();
                this.Clearaudio.loop = true;
            }

            if(gold_b<4)
            {
                title_button.SetActive(true);
                restart_button.SetActive(true);
                end_button.SetActive(true);

                gameEdText.enabled = true;
                Time.timeScale = 0;

                Failaudio.Play();
                Failaudio.loop = true;
            }

        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("core") && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= .051f;
            this.Attackudio.Play();
            Destroy(collision.gameObject);
            //audio.PlayOnShot(attack_Sound);


        }

        if (collision.collider.CompareTag("spear") && healthBarSlider.value > 0)
        {
            healthBarSlider.value -= .051f;
            this.Attackudio.Play();

        }

        //if (collision.collider.CompareTag("blade") && healthBarSlider.value > 0)
        //{
        //    healthBarSlider.value -= .051f;
        //    this.Attackudio.Play();
  

        //}

   


    }

}
