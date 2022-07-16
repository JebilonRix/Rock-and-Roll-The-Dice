using UnityEngine;

public class ObjectDeactivator : MonoBehaviour
{
    [Header("Tags")]
    [SerializeField] private string _diceTag = "Dice";
    [SerializeField] private string _rockTag = "Rock";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_diceTag) || other.CompareTag(_rockTag))
        {
            other.gameObject.SetActive(false);
        }
    }
}