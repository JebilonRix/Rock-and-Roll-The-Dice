using RedPanda.AudioSystem;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public class HitDetection : MonoBehaviour
{
    [Header("Connector")]
    [SerializeField] private SO_Health _health;
    [SerializeField] private SO_DiceStorage _diceStorage;
    [SerializeField] private SO_DynamicMusic _solos;
    [SerializeField] private AudioSource _audioSource;

    [Header("Numbers")]
    [SerializeField] private int _rockHitDamage = 10;

    [Header("Tags")]
    [SerializeField] private string _diceTag = "Dice";
    [SerializeField] private string _rockTag = "Rock";

    [Header("Texts")]
    [SerializeField] private List<GetCount> _counts = new List<GetCount>();



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
            DiceHandler diceHandler = other.GetComponent<DiceHandler>();

            _diceStorage.AddDice(diceHandler.Dice);

            foreach (GetCount item in _counts)
            {
                if (item.Dice != diceHandler.Dice)
                {
                    continue;
                }

                item.Text.text = _diceStorage.GetDiceCount(item.Dice).ToString();
            }

            _solos.PlayDynamic(_audioSource, Random.Range(_solos.Clips.Length - 3, _solos.Clips.Length));

            other.gameObject.SetActive(false);
        }
        if (other.CompareTag(_rockTag))
        {
            _health.TakeDamage(_rockHitDamage);
            other.gameObject.SetActive(false);
        }
    }
}