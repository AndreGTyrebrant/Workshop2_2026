using UnityEngine;

public class WinConManager : MonoBehaviour
{
    int collected = 0;
    public AudioSource CollectSound;
    public TMPro.TextMeshProUGUI collectedText;
    public GameObject DialogueBox;
    public GameObject SceneManager;

    void Start()
    {
        DialogueBox.GetComponent<Dialogue>().NextDialogue();
    }
    public void WinCheck()
    {
        if (collected < 3)
        {
            CollectSound.Play();
            collected++; 
            collectedText.text = "Collected: " + collected.ToString();
            Debug.Log(collected);
        }
        else
        {
            SceneManager.SceneChange();
            Debug.Log("Bombodilo crocodilo");
        }
    }
}
