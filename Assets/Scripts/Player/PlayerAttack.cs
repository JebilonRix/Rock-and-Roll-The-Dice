using RedPanda.AudioSystem;
using RedPanda.AudioSystem.AudioSettings;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Connectors")]
    [SerializeField] private SO_Health _enemyHealth;
    [SerializeField] private SO_DiceStorage _diceStorage;
    [SerializeField] private SO_DynamicMusic _solos;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private SO_Snapshot _shot;
    public void Attack()
    {
        var damage = _diceStorage.GetTotalDamage();
        _enemyHealth.TakeDamage(damage);

        _solos.PlayDirectlyOnce(_audioSource, Random.Range(0, _solos.Clips.Length));

        _shot.DoSnapshot("Attack");
    }
}