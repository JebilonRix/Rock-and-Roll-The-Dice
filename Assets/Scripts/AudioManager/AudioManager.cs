using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    private AudioSource _audioSource;
    [SerializeField] private AudioMixerGroup _mixer;

    [SerializeField] private AudioClip _intro;
    [SerializeField] private AudioClip _loop;
    [SerializeField] private AudioClip _outro;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        _audioSource.outputAudioMixerGroup = _mixer;
        PlayThis("intro");
    }

    public void PlayThis(string tag)
    {
        tag = tag.ToLower();

        if (tag == "intro")
        {
            _audioSource.clip = _intro;
            _audioSource.loop = false;
        }
        else if (tag == "main")
        {
            _audioSource.clip = _loop;
            _audioSource.loop = true;
        }
        else if (tag == "outro")
        {
            _audioSource.clip = _outro;
            _audioSource.loop = false;
        }

        _audioSource.Play();
    }
}