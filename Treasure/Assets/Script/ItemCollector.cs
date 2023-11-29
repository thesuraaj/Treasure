using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coins = 0;
    [SerializeField] Text coinsText;
    [SerializeField] AudioClip coinPickupSound;  // Add this line
    private AudioSource audioSource;  // Add this line

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  // Add this line
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coins++;

            // Play the coin pickup sound
            if (coinPickupSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(coinPickupSound);
            }

            // Update the UI text
            //coinsText.text = "Coins: " + coins;
        }
    }
}
