using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingDrop : MonoBehaviour
{
    private AudioSource bounce;
    void Start()
    {
        bounce = gameObject.GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        bounce.Play();
    }
}
