using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour {

    public Text playerScoreText;
    public Text enemyScoreText;

    int playerScoreQuantity;
    int enemyScoreQuantity;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Left")
        {
            enemyScoreQuantity++;
            UpdateScoreLabel(enemyScoreText,enemyScoreQuantity);
        }
        else if (gameObject.CompareTag("Right"))
        {
            playerScoreQuantity++;
            UpdateScoreLabel(playerScoreText, playerScoreQuantity);
        }
    }

    void UpdateScoreLabel( Text label, int score)
    {
        label.text = score.ToString();
    }
}
