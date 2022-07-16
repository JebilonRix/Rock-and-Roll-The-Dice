using UnityEngine;

[CreateAssetMenu(fileName = "DiceStorage", menuName = "Systems/DiceStorage")]
public class SO_DiceStorage : ScriptableObject
{
    private int[] _diceAmounts = new int[6];

    private void OnDisable()
    {
        for (int i = 0; i < _diceAmounts.Length; i++)
        {
            _diceAmounts[(i)] = 0;
        }
    }
    public void AddDice(Dice dice)
    {
        _diceAmounts[(int)dice]++;

        Debug.Log(dice.ToString() + " named dice's count is " + _diceAmounts[(int)dice]);
    }
    public int GetTotalDamage()
    {
        int totalDamage = 0;

        //_diceAmounts 6 adet zardan ka� adet bulundu�unu temsil ediyor.
        //_diceAmounts[0] => dice 1 ka� tane var.
        //_diceAmounts[1] => dice 2 ka� tane var.
        //i=0 => (i+1) = 1
        //i=1 => (i+1) = 2
        //Hasar form�l� = zar adeti ^ zar numaras�

        for (int i = 0; i < _diceAmounts.Length; i++)
        {
            totalDamage += _diceAmounts[i] ^ (i + 1);
        }

        Debug.Log("hasar = " + totalDamage);

        return totalDamage;
    }
}