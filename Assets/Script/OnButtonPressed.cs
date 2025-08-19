using UnityEngine;
using UnityEngine.SceneManagement;

public class OnButtonPressed : MonoBehaviour
{
    [SerializeField] private int CharacterSelectSceneIndex;
    [SerializeField] private int PlayingSceneIndex;
    [SerializeField] private CH_Showcase_Manager ShowcaseManager;


    public void On_CharacterSelect_Button_Down()
    {
        SceneManager.LoadScene(CharacterSelectSceneIndex);

    }

    public void On_Exit_Button_Down()
    {
        Application.Quit();
    }

    public void On_Ready_Button_Down()
    {
        SceneManager.LoadScene(PlayingSceneIndex);
    }

   public void On_Character_Button_Down(CharacterInfo SelectedCH)
    {
        ShowcaseManager.ChangeCharacterOnDisplay(SelectedCH);
    }

}
