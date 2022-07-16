using UnityEngine;
using static UnityEngine.SceneManagement.SceneManager;

[CreateAssetMenu(fileName = "UIHandler", menuName = "UI/UIHandler")]
public class UIHandler : ScriptableObject
{
    private PanelChanger panelChanger;

    /// <summary>
    /// Bu method panel changer class'�n scriptable objesine kuramay� sa�lar.
    /// </summary>
    public void UIHandlerInit(PanelChanger changer)
    {
        panelChanger = changer;
    }
    /// <summary>
    /// Main Men�'y� y�kler.
    /// </summary>
    public void LoadMainMenu()
    {
        LoadScene(0);
        ChangeActivePanel(0);
    }
    public void LoadGame()
    {
        LoadScene(1);
        ChangeActivePanel(1);
    }
    public void ChangeActivePanel(int index)
    {
        panelChanger.ChangeActivePanel(index);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}