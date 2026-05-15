using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [Header("Dialogue UI")]
    [SerializeField] private GameObject dialogueBox;

    [SerializeField] private TMP_Text characterName;
    [SerializeField] private TMP_Text dialogue;

    [SerializeField] private Image dialogueBoxImage;

    [Header("Background")]
    [SerializeField] private Image backgroundImage;

    [Header("Dialogue")]
    [SerializeField] private DialogueData currentDialogue;

    private int currentLineIndex;

    private RectTransform dialogueBoxRect;

    private void Start()
    {
        dialogueBoxRect = dialogueBox.GetComponent<RectTransform>();

        StartDialogue(currentDialogue);
    }

    public void StartDialogue(DialogueData dialogueData)
    {
        currentDialogue = dialogueData;
        currentLineIndex = 0;

        dialogueBox.SetActive(true);

        ShowCurrentLine();
    }

    public void NextDialogue()
    {
        currentLineIndex++;

        if (currentLineIndex >= currentDialogue.Lines.Count)
        {
            EndDialogue();
            return;
        }

        ShowCurrentLine();
    }

    private void ShowCurrentLine()
    {
        DialogueLine line = currentDialogue.Lines[currentLineIndex];

        // Text
        characterName.text = line.CharacterName;
        dialogue.text = line.DialogueText;

        // Background
        if (line.BackgroundSprite != null)
        {
            backgroundImage.sprite = line.BackgroundSprite;
        }

        // Dialogue Box Sprite
        if (line.DialogueBoxSprite != null)
        {
            dialogueBoxImage.sprite = line.DialogueBoxSprite;
        }

        // Dialogue Box Position
        dialogueBoxRect.anchoredPosition = line.DialogueBoxPosition;
    }

    private void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }
}