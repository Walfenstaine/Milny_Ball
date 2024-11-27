using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muwelavel : MonoBehaviour
{
    public float speed;

    bool muve;
    public void Muve(bool muv) 
    {
        muve = muv;
    }
    private void Update()
    {
        if (muve)
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
