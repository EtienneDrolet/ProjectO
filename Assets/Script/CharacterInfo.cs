using UnityEngine;

[CreateAssetMenu(fileName = "CharacterInfo", menuName = "Scriptable Objects/CharacterInfo")]
public class CharacterInfo : ScriptableObject
{
    public string CH_Name;
    public Sprite CH_Sprite;
    public string CH_Class;
    public string CH_Ability1_Name;
    public string CH_Ability2_Name;
    public string CH_Ability1_Description;
    public string CH_Ability2_Description;
}
