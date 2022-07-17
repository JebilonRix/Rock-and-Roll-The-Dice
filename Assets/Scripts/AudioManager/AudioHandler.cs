using RedPanda.AudioSystem;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioHandler : MonoBehaviour
{
    [SerializeField] private SO_DynamicMusic _main;
    [SerializeField] private SO_DynamicMusic _solos;

    [SerializeField] private SO_Health _playerHealth;
    [SerializeField] private SO_Health _enemyHealth;

    private bool _playDeath = false;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        _playDeath = false;
        _main.PlayDynamic(_audioSource, 0);
        _main.PlayDynamic(_audioSource, 1);
    }

    private void Update()
    {
        if (_playDeath)
        {
            return;
        }

        if (_playerHealth.Health <= 0 || _enemyHealth.Health <= 0)
        {
            _main.PlayDynamic(_audioSource, 2);
            _playDeath = true;
        }
    }
}