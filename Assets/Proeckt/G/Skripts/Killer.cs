using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(transform.forward * 10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            Interface.rid.Sum(2,true,0);
        }
    }
}
