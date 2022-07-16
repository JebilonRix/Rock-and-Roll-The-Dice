using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Movement2D : MonoBehaviour
{
    [SerializeField] private Transform[] _walkPoints; // 0,1,2,3,4
    private SpriteRenderer _spriteRenderer;
    private bool _facingRight = true;
    private int index = 2;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
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
        index += direction;

        if (index > _walkPoints.Length - 1)
        {
            index = _walkPoints.Length - 1;
            return;
        }
        else if (index < 0)
        {
            index = 0;
            return;
        }

        transform.position = _walkPoints[index].transform.position;
    }
}
