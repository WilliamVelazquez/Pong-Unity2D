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

    public SceneChanger sceneChanger;

    private void OnTriggerEnter2D(Collider2D ball)
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

        ball.GetComponent<BallBehaviour>().gameStarted = false;
        checkScore();
    }

    void checkScore()
    {
        if(playerScoreQuantity >= 3)
        {
            sceneChanger.changeSceneTo("WinScene");
        }
        else if (enemyScoreQuantity >= 3)
        {
            sceneChanger.changeSceneTo("LoseScene");
        }
    }

    void UpdateScoreLabel( Text label, int score)
    {
        label.text = score.ToString();
    }
}
