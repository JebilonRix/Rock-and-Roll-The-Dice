using RedPanda.AudioSystem;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Connectors")]
    [SerializeField] private SO_Health _enemyHealth;
    [SerializeField] private SO_DiceStorage _diceStorage;
    [SerializeField] private SO_DynamicMusic _solos;
    [SerializeField] private AudioSource _audioSource;
    public void Attack()
    {
        var damage = _diceStorage.GetTotalDamage();
        _enemyHealth.TakeDamage(damage);

        if (damage < 100)
        {
            _solos.PlayDynamic(_audioSource, 0);
        }
        else if (damage > 250)
        {
            _solos.PlayDynamic(_audioSource, 1);
        }
        else if (damage > 400)
        {
            _solos.PlayDynamic(_audioSource, 2);
        }
    }
}