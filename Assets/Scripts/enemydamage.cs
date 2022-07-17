using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamage : MonoBehaviour
{
    Animator hareket;
    
    // Start is called before the first frame update
    void Start()
    {
        hareket = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            hareket.SetTrigger("hurt");
        }
        if (Input.GetKey(KeyCode.D))
        {
            hareket.SetTrigger("slide");
        }
    }
}
