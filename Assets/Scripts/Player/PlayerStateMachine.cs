using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    [SerializeField] private CharacterStates _characterState;

    [Header("Connectors")]
    [SerializeField] private PlayerMovement _movement2D;
    [SerializeField] private PlayerAttack _attackHandler;

    [Header("Timers")]
    [SerializeField] private float _attackToIdleTime = 1f;
    [SerializeField] private float _walkToIdleTime;

    public CharacterStates CharacterState { get => _characterState; set => _characterState = value; }
    private void Start() => CharacterState = CharacterStates.Idle;
    private void Update() => StateMachine();
    private void StateMachine()
    {
        switch (CharacterState)
        {
            case CharacterStates.Idle:

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _attackHandler.Attack();
                    CharacterState = CharacterStates.Attack;
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    _movement2D.GoLeft();
                    CharacterState = CharacterStates.Walk;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    _movement2D.GoRight();
                    CharacterState = CharacterStates.Walk;
                }
                break;

            case CharacterStates.Walk:
                Invoke(nameof(ReturnToIdle), _walkToIdleTime);
                break;

            case CharacterStates.Attack:
                Invoke(nameof(ReturnToIdle), _attackToIdleTime);
                break;
        }
    }
    private void ReturnToIdle() => CharacterState = CharacterStates.Idle;
}