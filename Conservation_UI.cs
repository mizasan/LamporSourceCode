using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConversationManager : MonoBehaviour
{
    public GameObject conversationPanel;
    public TMP_Text conversationText; // Menggunakan TMP_Text dari namespace TMPro
    public string[] dialogLines;


public void StartConversation(string dialog)
{
    Debug.Log("Setting conversation text: " + dialog);
    conversationText.text = dialog;
    conversationPanel.SetActive(true);
    Debug.Log("Conversation started. Panel active: " + conversationPanel.activeSelf);
}
    public void CloseConversation()
    {
        conversationPanel.SetActive(false);
        Debug.Log("Conversation closed. Panel active: " + conversationPanel.activeSelf);
    }
}
