using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _startDashTime = 300f;
    [SerializeField] private float _dashSpeed = 0.1f;
    private Rigidbody _rb;
    private float _dashTime;
    private int _direction;

    public float StartDashTime { get => _startDashTime; set => _startDashTime = value; }
    public float DashSpeed { get => _dashSpeed; set => _dashSpeed = value; }

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _dashTime = StartDashTime;
    }

    private void Update()
    {
        if (_direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _direction = 2;
            }
        }
        else
        {
            if (_dashTime <= 0)
            {
                _direction = 0;
                _dashTime = StartDashTime;
                _rb.velocity = Vector3.zero;
            }
            else
            {
                _dashTime -= Time.deltaTime;

                if (_direction == 1)
                {
                    _rb.velocity = Vector3.left * DashSpeed;
                }
                else if (_direction == 2)
                {
                    _rb.velocity = Vector3.right * DashSpeed;
                }
            }
        }
    }
}