using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GetCount
{
    [SerializeField] private Dice dice;
    [SerializeField] private Text _text;

    public Dice Dice { get => dice; set => dice = value; }
    public Text Text { get => _text; set => _text = value; }
}