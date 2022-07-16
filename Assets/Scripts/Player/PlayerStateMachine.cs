using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    [SerializeField] private CharacterStates _characterState;
    public CharacterStates CharacterState { get => _characterState; set => _characterState = value; }

    private void Start()
    {
        CharacterState = CharacterStates.Idle;
    }
}