using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public int no_of_bullets;

    public Transform cannon, head;
    public GameObject obj;
    public float force = 1000f;
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && no_of_bullets>0)
        {
            GameObject proj = Instantiate(obj, cannon.position, Quaternion.identity);
            proj.GetComponent<Rigidbody>().AddRelativeForce(head.forward*force, ForceMode.Impulse);
            no_of_bullets--;
            if (no_of_bullets == 0)
            {
                Exit();
            }
        }
        
           
    }
    void Exit()
    {
        Debug.Log("No bullets left");
    }
    
}
