using RedPanda.ObjectPooling;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class PooledObjectMovement : MonoBehaviour
{
    [SerializeField] private SO_PooledObject _pooledObject;
    [SerializeField] private SO_SpriteHolder _spriteHolder;
    [SerializeField] private float _movementSpeed = 5f;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _movementSpeed);
    }
    private void OnEnable()
    {
        if (_pooledObject.PooledObjectTag == "Dice")
        {
            //deðiþtir burayý
            _spriteRenderer.sprite = _spriteHolder.Sprites[0];
        }
        else if (_pooledObject.PooledObjectTag == "Rock")
        {
            _spriteRenderer.sprite = _spriteHolder.Sprites[Random.Range(0, _spriteHolder.Sprites.Length)];
        }
    }
}