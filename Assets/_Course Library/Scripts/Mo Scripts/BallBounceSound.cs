using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.layer.ToString() != "Hands")
        {
            audioSource.PlayOneShot(audioSource.clip, rigidBody.velocity.magnitude);
        }
   
    }
}
