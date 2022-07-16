using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    [SerializeField] private UIHandler _uiHandler;
    [SerializeField] private GameObject[] _panels;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    private void Start()
    {
        _uiHandler.UIHandlerInit(this);
        ChangeActivePanel(0);
    }

    /// <summary>
    /// Aktif paneli ayarlar.
    /// index = Ka� numaral� panelin aktif olaca��na karar veren say�d�r.
    /// </summary>
    public void ChangeActivePanel(int index)
    {
        for (int i = 0; i < _panels.Length; i++)
        {
            _panels[i].SetActive(i == index);
        }
    }
}