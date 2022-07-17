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

    public int Dice1Count { get => _dice1Count; private set => _dice1Count = value; }
    public int Dice2Count { get => _dice2Count; private set => _dice2Count = value; }
    public int Dice3Count { get => _dice3Count; private set => _dice3Count = value; }
    public int Dice4Count { get => _dice4Count; private set => _dice4Count = value; }
    public int Dice5Count { get => _dice5Count; private set => _dice5Count = value; }
    public int Dice6Count { get => _dice6Count; private set => _dice6Count = value; }

    private void OnDisable()
    {
        ResetValues();
    }
    public int GetDiceCount(Dice dice)
    {
        switch (dice)
        {
            case Dice.Dice_1:
                return Dice1Count;

            case Dice.Dice_2:
                return Dice2Count;

            case Dice.Dice_3:
                return Dice3Count;

            case Dice.Dice_4:
                return Dice4Count;

            case Dice.Dice_5:
                return Dice5Count;

            case Dice.Dice_6:
                return Dice6Count;
        }

        return 0;
    }
    public void AddDice(Dice dice)
    {
        switch (dice)
        {
            case Dice.Dice_1:
                Dice1Count++;
                break;

            case Dice.Dice_2:
                Dice2Count++;
                break;

            case Dice.Dice_3:
                Dice3Count++;
                break;

            case Dice.Dice_4:
                Dice4Count++;
                break;

            case Dice.Dice_5:
                Dice5Count++;
                break;

            case Dice.Dice_6:
                Dice6Count++;
                break;
        }
    }
    public int GetTotalDamage()
    {
        int totalDamage = 0;
        int[] array = new int[] { Dice1Count, Dice2Count, Dice3Count, Dice4Count, Dice5Count, Dice6Count };

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
        Dice1Count = 0;
        Dice2Count = 0;
        Dice3Count = 0;
        Dice4Count = 0;
        Dice5Count = 0;
        Dice6Count = 0;
    }
}