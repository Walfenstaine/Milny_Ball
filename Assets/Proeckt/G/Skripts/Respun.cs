using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respun : MonoBehaviour
{
    public GameObject[] spuns;

    public void Respuner() 
    {
        transform.localPosition += transform.right * 1400;
        int ran = Random.Range(0,4);
        for (int i = 0; i < spuns.Length; i++) 
        {
            if (i == ran)
            {
                spuns[i].SetActive(true);
            }
            else
            {
                spuns[i].SetActive(false);
            }
        }
    }
}
