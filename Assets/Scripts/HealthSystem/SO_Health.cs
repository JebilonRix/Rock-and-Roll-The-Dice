using UnityEngine;

[CreateAssetMenu(fileName = "Health", menuName = "Systems/Health")]
public class SO_Health : ScriptableObject
{
    [SerializeField] private int _health;
    private bool _isDead = false;

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            _isDead = true;
        }
    }
}