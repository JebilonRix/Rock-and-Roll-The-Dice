using RedPanda.AudioSystem;
using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;

[CreateAssetMenu(fileName = "UIHandler", menuName = "UI/UIHandler")]
public class UIHandler : ScriptableObject
{
    [SerializeField] private SO_DynamicMusic _music;
    private PanelChanger _panelChanger;
    private AudioSource _source;

    public void AudioSourceInýt(AudioSource source)
    {
        _source = source;
    }
    public void UIHandlerInit(PanelChanger changer)
    {
        _panelChanger = changer;
    }
    public void LoadMainMenu()
    {
        LoadScene(0);
        ChangeActivePanel(0);
    }
    public void LoadGame()
    {
        ChangeActivePanel(1);
    }
    public void ChangeActivePanel(int index)
    {
        _panelChanger.ChangeActivePanel(index);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}