using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class SetText : MonoBehaviour
{
    [SerializeField] private Dice _dice;

    private void Start()
    {
        var det = FindObjectOfType<HitDetection>();

        GetCount count = new GetCount();

        count.Text = GetComponent<Text>();
        count.Dice = _dice;

        det.Counts.Add(count);
    }
}
