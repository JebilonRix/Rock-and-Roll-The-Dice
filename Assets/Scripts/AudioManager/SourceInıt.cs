using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SourceInıt : MonoBehaviour
{
    private UIHandler handler;

    private void Start()
    {
        handler.AudioSourceInıt(GetComponent<AudioSource>());
    }
}