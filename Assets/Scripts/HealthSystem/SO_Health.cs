using UnityEngine;

[CreateAssetMenu(fileName = "Health", menuName = "Systems/Health")]
public class SO_Health : ScriptableObject
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private string _name = "Player";
    private int _health;

    private void OnDisable()
    {
        _health = _maxHealth;
    }
    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            WinLoseCondition();
        }
    }
    public void WinLoseCondition()
    {
        if (_name == "Player")
        {
            //lose
        }
        else
        {
            //win
        }
    }
}