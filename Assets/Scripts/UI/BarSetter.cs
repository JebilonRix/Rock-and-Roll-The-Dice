using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class BarSetter : MonoBehaviour
{
    [SerializeField] private SO_Health _health;

    private void Start()
    {
        _health.HealthBarIn�t(GetComponent<Image>());
    }
}