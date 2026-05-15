using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue/Dialogue Data")]
public class DialogueData : ScriptableObject
{
    public List<DialogueLine> Lines = new();
}

[System.Serializable]
public class DialogueLine
{
    [Header("Dialogue")]
    public string CharacterName;

    [TextArea(3, 6)]
    public string DialogueText;

    [Header("Visual")]
    public Sprite BackgroundSprite;

    public Sprite DialogueBoxSprite;

    public Vector2 DialogueBoxPosition;
}