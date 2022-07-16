using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(fileName = "AudioSlider", menuName = "UI/AudioSlider")]
public class SO_AudioSlider : ScriptableObject
{
    [SerializeField] private AudioMixerGroup mixerGroup;

    public void SetVolume(float value)
    {
        mixerGroup.audioMixer.SetFloat("volume", value);
    }
}