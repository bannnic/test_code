using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_control : MonoBehaviour
{


    public void re_title()
    {
        SceneManager.LoadScene("Title");

    }

    public void re_start()
    {
        SceneManager.LoadScene("Main");

    }

    public void game_end()
    {
        Application.Quit();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
