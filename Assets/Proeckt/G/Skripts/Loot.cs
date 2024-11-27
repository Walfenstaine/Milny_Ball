using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class Loot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            YandexGame.savesData.record += 1;
            YandexGame.SaveProgress();
            YandexGame.NewLeaderboardScores("LEADER666", YandexGame.savesData.record);
            Destroy(gameObject);
        }
    }
}
