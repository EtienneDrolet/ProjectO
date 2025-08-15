using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CH_Showcase_Manager : MonoBehaviour
{
    [SerializeField] private GameObject CH_Sprite;
    [SerializeField] private GameObject CH_Name;
    [SerializeField] private GameObject CH_Class;
    [SerializeField] private GameObject CH_Ability1_Name;
    [SerializeField] private GameObject CH_Ability1_Description;
    [SerializeField] private GameObject CH_Ability2_Name;
    [SerializeField] private GameObject CH_Ability2_Description;



    private void Start()
    {

    }

    public void ChangeCharacterOnDisplay(CharacterInfo info)
    {

        CH_Sprite.GetComponent<SpriteRenderer>().sprite = info.CH_Sprite;
        CH_Name.GetComponent<TextMeshProUGUI>().text = info.CH_Name;
        CH_Class.GetComponent<TextMeshProUGUI>().text = info.CH_Class;
        CH_Ability1_Name.GetComponent<TextMeshProUGUI>().text = info.CH_Ability1_Name;
        CH_Ability2_Name.GetComponent<TextMeshProUGUI>().text = info.CH_Ability2_Name;
        CH_Ability1_Description.GetComponent<TextMeshProUGUI>().text = info.CH_Ability1_Description;
        CH_Ability2_Description.GetComponent<TextMeshProUGUI>().text = info.CH_Ability2_Description;
    }
}
