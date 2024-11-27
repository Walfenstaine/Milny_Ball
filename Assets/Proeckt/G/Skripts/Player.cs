using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetTrigger("Kik");
    }
}
