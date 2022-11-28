using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public List<GameObject> constant;
    public HeroMovementController con;
    // Start is called before the first frame update
    void Start()
    {
        con = GameObject.FindObjectOfType<HeroMovementController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("activeabstcle")|| other.CompareTag("mycube"))
        {

           
            if (constant.Contains(this.gameObject) == false)
            {
                constant.Add(this.gameObject);
                con.droop(other.gameObject);
    
            }
        }

        
    }
}
