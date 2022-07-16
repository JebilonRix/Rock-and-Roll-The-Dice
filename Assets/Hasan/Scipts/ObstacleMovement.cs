using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float speed = 200f;

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
