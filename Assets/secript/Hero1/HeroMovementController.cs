using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroMovementController : MonoBehaviour
{

    public int dimond_counter = 0;
    public List<GameObject> listo;
  
    int listnum;
    [SerializeField] private float forwarMovementSpeed;
    [SerializeField] private float horizontal_speed_value;
    float horizontal;


    void FixedUpdate()
    {
        if (Input.GetMouseButton(0)) { horizontal = Input.GetAxis("Mouse X"); }
        else
        {
            horizontal = 0;
        }
        transform.Translate(Vector3.forward * forwarMovementSpeed * Time.fixedDeltaTime);


         transform.Translate(Vector3.right * horizontal_speed_value*horizontal * Time.fixedDeltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("duvar"))
        {
        
            OnCollisionStay(collision);
            horizontal = 0;
        }
        else if (collision.gameObject.CompareTag("abstcle"))
        {
           
            if (listo.Contains(collision.gameObject) == false)
            {
       
                listo.Add(collision.gameObject);
                transform.position = new Vector3(transform.position.x, transform.position.y + 2.0f, transform.position.z);
                collision.gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - (listo.Count * 2.0f),transform.position.z);
                collision.gameObject.transform.SetParent(transform);
                var t = collision.gameObject.GetComponent<BoxCollider>();
                var q = collision.gameObject.GetComponent<SphereCollider>();
                collision.gameObject.tag = "activeabstcle";               
                listnum = listo.Count;
            }
           

        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("duvar"))
        {
            horizontal =0;
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("end"))
        {

            horizontal_speed_value = 0;
            forwarMovementSpeed = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
  
    }
    public void droop(GameObject outt)
    {
        if (listo.Count == 0)
        {
            
            horizontal_speed_value = 0;
            forwarMovementSpeed = 0;
            SceneManager.LoadScene("final");
        }
        else
        {
            listo.Remove(outt);
            outt.transform.parent = null;
            listnum = listo.Count;
        }
    }

}
