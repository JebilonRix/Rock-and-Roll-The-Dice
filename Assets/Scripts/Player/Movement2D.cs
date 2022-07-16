using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Movement2D : MonoBehaviour
{
    [SerializeField] private Transform[] _walkPoints; // 0,1,2,3,4

    private SpriteRenderer _spriteRenderer;
    private bool _facingRight = true;
    private int _index;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        _index = Mathf.RoundToInt(_walkPoints.Length / 2);

        FacingHandler(false);

        Move(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Move(-1);

            if (_facingRight)
            {
                FacingHandler(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Move(1);

            if (!_facingRight)
            {
                FacingHandler(true);
            }
        }
    }

    private void FacingHandler(bool turn)
    {
        _facingRight = turn;
        _spriteRenderer.flipX = !turn;
    }
    private void Move(int direction)
    {
        _index += direction;

        if (_index > _walkPoints.Length - 1)
        {
            _index = _walkPoints.Length - 1;
            return;
        }
        else if (_index < 0)
        {
            _index = 0;
            return;
        }

        //Move towards, lerp
        transform.position = _walkPoints[_index].transform.position;
    }
}