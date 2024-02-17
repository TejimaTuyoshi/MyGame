using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outobject : MonoBehaviour
{
    [SerializeField] GameObject position;
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
            other.gameObject.transform.position = position.transform.position;
        }
    }
}
