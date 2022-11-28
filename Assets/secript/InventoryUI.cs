using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    HeroMovementController hero;
    private TextMeshProUGUI diamondText;
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
        hero = FindObjectOfType<HeroMovementController>();


    }
    private void Update()
    {
        diamondText.text = hero.dimond_counter.ToString();
    }

}
