using UnityEngine;

public class AudioChanger : MonoBehaviour
{
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource1.pitch = 0.2f;
        audioSource2.pitch = 0.2f;
        audioSource3.pitch = 0.2f;
    }
}
