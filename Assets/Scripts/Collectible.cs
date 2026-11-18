using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject WinManager;
    private GameObject collectedPS;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CustomizablePlatformerMovement>())
        {
            collision.GetComponent<WinConManager>().WinCheck();
            collision.transform.Find("playerCollectedPS").GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
        }
    }
}
