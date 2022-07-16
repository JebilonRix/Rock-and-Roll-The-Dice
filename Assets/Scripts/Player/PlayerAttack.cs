using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Connectors")]
    [SerializeField] private SO_Health _enemyHealth;
    [SerializeField] private SO_DiceStorage _diceStorage;

    public void Attack()
    {
        _enemyHealth.TakeDamage(_diceStorage.GetTotalDamage());
    }
}