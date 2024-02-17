using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class jumpobject : MonoBehaviour
{
    [SerializeField] Player player;
    AudioSource audioSource;
    [SerializeField] AudioClip _audio;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(_audio);
            if (player.jumpCount > 0)
            {
                player.jumpCount -= 1;
            }
        }
    }
}
