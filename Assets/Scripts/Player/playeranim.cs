using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranim : MonoBehaviour
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
            hareket.SetTrigger("attack");
        }
    }
}
