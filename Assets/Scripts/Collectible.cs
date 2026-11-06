using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameObject WinManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CustomizablePlatformerMovement>())
        {
            collision.GetComponent<WinConManager>().WinCheck();
            Destroy(gameObject);
        }
    }
}
