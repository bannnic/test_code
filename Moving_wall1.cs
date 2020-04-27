using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_wall1 : MonoBehaviour
{

    private float vec = -0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (vec == 0.2f)
        {
            this.gameObject.transform.Translate(0, 0, Time.deltaTime);
            if (this.gameObject.transform.position.x > 36.0f)
            {
                vec = -0.2f;
            }

        }

        else if (vec == -0.2f)
        {
            this.gameObject.transform.Translate(0, 0, Time.deltaTime*-1);
            {
                if (this.gameObject.transform.position.x < 32.0f)
                {
                    vec = 0.2f;
                }
            }

        }

    }
}
