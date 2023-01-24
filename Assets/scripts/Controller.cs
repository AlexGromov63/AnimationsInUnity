using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Animator>().SetBool("isMashet", 
                !GetComponent<Animator>().GetBool("isMashet"));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetBool("isWalk",
                !GetComponent<Animator>().GetBool("isWalk"));
        }

    }
}
