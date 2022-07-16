using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class HitDetection : MonoBehaviour
{
    [Header("Connector")]
    [SerializeField] private SO_Health _health;
    [SerializeField] private SO_DiceStorage _diceStorage;

    [Header("Numbers")]
    [SerializeField] private int _rockHitDamage = 10;

    [Header("Tags")]
    [SerializeField] private string _diceTag = "Dice";
    [SerializeField] private string _rockTag = "Rock";

    private void Awake()
    {
        BoxCollider col = GetComponent<BoxCollider>();
        col.enabled = true;
        col.isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_diceTag))
        {
            _diceStorage.AddDice(other.GetComponent<DiceHandler>().Dice);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag(_rockTag))
        {
            _health.TakeDamage(_rockHitDamage);
            other.gameObject.SetActive(false);
        }
    }
}