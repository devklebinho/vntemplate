using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private GameObject dialogueBox;
    [SerializeField] private TMP_Text characterName;
    [SerializeField] private TMP_Text dialogue;

    [Header("Dialogue")]
    [SerializeField] private DialogueData currentDialogue;

    [SerializeField] private int currentLineIndex;

    private void Start()
    {
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

        characterName.text = line.CharacterName;
        dialogue.text = line.DialogueText;
    }

    private void EndDialogue()
    {
        dialogueBox.SetActive(false);
    }
}