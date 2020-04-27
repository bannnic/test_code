using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class title_button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


 

    // Update is called once per frame
    void Update()
    {

     

    }
    public void click_st()
    {
        SceneManager.LoadScene("Main");
    }

    public void click_ed()
    {
        Application.Quit();
    }


    public void click_manual()
    {

            SceneManager.LoadScene("Manual");
       

    }

    public void click_back()
    {

            SceneManager.LoadScene("Title");
   

    }



}
