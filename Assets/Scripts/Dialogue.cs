using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public List<DialogueLine> Lines = new();
}

[System.Serializable]
public class DialogueLine
{
    public string CharacterName;

    [TextArea(3, 6)]
    public string DialogueText;
    //public Image imageBox;
}