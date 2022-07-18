using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    //private static PanelChanger _instance;

    [SerializeField] private UIHandler _uiHandler;
    [SerializeField] private GameObject[] _panels;

    private void Awake()
    {
        //if (_instance == null)
        //{
        //    _instance = this;
        //    DontDestroyOnLoad(this);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }
    private void Start()
    {
        _uiHandler.UIHandlerInit(this);

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