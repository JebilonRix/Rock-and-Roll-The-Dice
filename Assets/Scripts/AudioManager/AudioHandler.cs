using RedPanda.AudioSystem;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioHandler : MonoBehaviour
{
    [SerializeField] private SO_DynamicMusic _main;
    [SerializeField] private SO_Health _playerHealth;
    [SerializeField] private SO_Health _enemyHealth;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        ToMenuMusic();
    }
    public void ToMenuMusic()
    {
        _main.PlayDirectly(_audioSource, 0);
    }
    public void ToGameMusic()
    {
        _main.PlayDirectly(_audioSource, 1);
        _main.PlayDynamic(_audioSource, 2);
    }
}