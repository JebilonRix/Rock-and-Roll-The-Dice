using UnityEngine;

[CreateAssetMenu(fileName = "DiceStorage", menuName = "Systems/DiceStorage")]
public class SO_DiceStorage : ScriptableObject
{
    [SerializeField] private int _dice1Count = 0;
    [SerializeField] private int _dice2Count = 0;
    [SerializeField] private int _dice3Count = 0;
    [SerializeField] private int _dice4Count = 0;
    [SerializeField] private int _dice5Count = 0;
    [SerializeField] private int _dice6Count = 0;

    private void OnDisable()
    {
        ResetValues();
    }
    public void AddDice(Dice dice)
    {
        switch (dice)
        {
            case Dice.Dice_1:
                _dice1Count++;
                break;

            case Dice.Dice_2:
                _dice2Count++;
                break;

            case Dice.Dice_3:
                _dice3Count++;
                break;

            case Dice.Dice_4:
                _dice4Count++;
                break;

            case Dice.Dice_5:
                _dice5Count++;
                break;

            case Dice.Dice_6:
                _dice6Count++;
                break;
        }
    }
    public int GetTotalDamage()
    {
        int totalDamage = 0;
        int[] array = new int[] { _dice1Count, _dice2Count, _dice3Count, _dice4Count, _dice5Count, _dice6Count };

        for (int i = 0; i < 6; i++)
        {
            totalDamage += (int)Mathf.Pow(array[i], (i + 1));
        }

        Debug.Log("hasar = " + totalDamage);
        ResetValues();

        return totalDamage;
    }

    private void ResetValues()
    {
        _dice1Count = 0;
        _dice2Count = 0;
        _dice3Count = 0;
        _dice4Count = 0;
        _dice5Count = 0;
        _dice6Count = 0;
    }
}