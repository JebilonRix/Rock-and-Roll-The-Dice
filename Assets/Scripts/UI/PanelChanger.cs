using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    [SerializeField] private UIHandler uiHandler;
    [SerializeField] private GameObject[] _panels;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        uiHandler.UIHandlerInit(this);

        ChangeActivePanel(0);
    }
    public void ChangeActivePanel(int index)
    {
        for (int i = 0; i < _panels.Length; i++)
        {
            _panels[i].SetActive(i == index);
        }
    }
}
