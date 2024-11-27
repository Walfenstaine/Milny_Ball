using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyRotator : MonoBehaviour
{
    float rut = 0;
    float spid = 0;
    public void Muiw(float speed) 
    {
        spid = speed;
    }
    private void Update()
    {
        rut += spid * Time.deltaTime;
        RenderSettings.skybox.SetFloat("_Rotation", rut);
    }
}
