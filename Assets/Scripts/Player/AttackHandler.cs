using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    [Header("Connectors")]
    [SerializeField] private PlayerStateMachine _playerStateMachine;
    [SerializeField] private SO_Health _enemyHealth;
    [SerializeField] private SO_DiceStorage _diceStorage;

    [Header("Timer")]
    private float _attackToIdleTime = 1f;

    private void Update()
    {
        if (_playerStateMachine.CharacterState == CharacterStates.Attack)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        Debug.Log("saldýrdým");

        _playerStateMachine.CharacterState = CharacterStates.Attack;

        _enemyHealth.TakeDamage(_diceStorage.GetTotalDamage());

        Invoke(nameof(ReturnToIdle), _attackToIdleTime);
    }

    private void ReturnToIdle()
    {
        Debug.Log("idle döndüm");

        _playerStateMachine.CharacterState = CharacterStates.Idle;
    }
}
