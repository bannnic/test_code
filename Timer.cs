using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text timerText;
    private float time;
    private int currentTime;

    public static bool stop = true;


    public Text gameEdText;
    public GameObject title_button;
    public GameObject restart_button;
    public GameObject end_button;

    //fail sound
    public AudioSource Failaudio;
    public AudioClip fail_Sound;
    bool fail_sound = false;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
        stop= true;
        timerText = GetComponent<Text>();

        title_button.SetActive(false);
        restart_button.SetActive(false);
        end_button.SetActive(false);

        gameEdText.enabled = false;


        //fail 사운드
        this.Failaudio = Failaudio.gameObject.AddComponent<AudioSource>();
        this.Failaudio.clip = fail_Sound;
        this.Failaudio.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime == 180)
        {
            stop = false;

            title_button.SetActive(true);
            restart_button.SetActive(true);
            end_button.SetActive(true);

            gameEdText.enabled = true;

            Time.timeScale = 0;

            Failaudio.Play();
            Failaudio.loop = true;

            currentTime++;
        }


        if (stop)
        {
           time += Time.deltaTime;
           currentTime = (int)time;
           timerText.text = "Timer :" + currentTime + "/180";
        }
    }
}
