using UnityEngine;

[CreateAssetMenu(fileName = "DiceStorage", menuName = "Systems/DiceStorage")]
public class SO_DiceStorage : ScriptableObject
{
    private int[] _diceAmounts = new int[6];

    public void AddDice(Dice dice)
    {
        _diceAmounts[(int)dice]++;
    }
    public int GetTaotalDamage()
    {
        int totalDamage = 0;

        //

        for (int i = 0; i < _diceAmounts.Length; i++)
        {
            totalDamage += _diceAmounts[i] ^ (i + 1);
        }

        return totalDamage;
    }
}