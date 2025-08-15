using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class OnButtonPressed : MonoBehaviour
{
    [SerializeField] private int CharacterSelectSceneIndex;
    [SerializeField] private int PlayingSceneIndex; 
    [SerializeField] private CharacterInfo SelectedCH; 

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
        
    }

}
