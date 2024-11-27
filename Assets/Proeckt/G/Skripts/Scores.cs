using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using YG;
public class Scores : MonoBehaviour
{
    public Text score;

    private void FixedUpdate()
    {
        score.text = "" + YandexGame.savesData.record;
    }
}
