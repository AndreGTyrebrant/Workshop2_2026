using UnityEngine;

public class WinConManager : MonoBehaviour
{
    int collected = 0;
    public TMPro.TextMeshProUGUI collectedText;
    public void WinCheck()
    {
        if (collected < 3)
        {
            collected++; 
            collectedText.text = "Collected: " + collected.ToString();
            Debug.Log(collected);
        }
        else
        {
            collectedText.text = "You won kappa.";
            Debug.Log("Bombodilo crocodilo");
        }
    }
}
