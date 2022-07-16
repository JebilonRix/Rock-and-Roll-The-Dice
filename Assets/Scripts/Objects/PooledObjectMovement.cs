using RedPanda.ObjectPooling;
using UnityEngine;

public class PooledObjectMovement : MonoBehaviour
{
    [SerializeField] private SO_PooledObject _pooledObject;
    [SerializeField] private float _movementSpeed = 5f;

    private void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _movementSpeed);
    }
}