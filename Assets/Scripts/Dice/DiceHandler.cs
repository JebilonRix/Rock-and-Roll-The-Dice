using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceHandler : MonoBehaviour
{
    [SerializeField] private Dice _dice;
    public Dice Dice { get => _dice; }
}
