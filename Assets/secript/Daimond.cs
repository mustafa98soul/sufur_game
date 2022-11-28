using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daimond : MonoBehaviour
{

    HeroMovementController hero;
    private void Start()
    {
        hero = FindObjectOfType<HeroMovementController>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mycube") || other.CompareTag("activeabstcle"))
        {
            Destroy(this.gameObject);
            hero.dimond_counter += 1;

            


        }
    }
  
}
