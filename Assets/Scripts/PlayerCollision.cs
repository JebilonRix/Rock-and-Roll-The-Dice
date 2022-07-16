using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private string _tag = "Enemy";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_tag))
        {
            Debug.Log("öldün çýk");
        }
    }
}
