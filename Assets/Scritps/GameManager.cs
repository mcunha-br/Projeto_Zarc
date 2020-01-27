using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float speed;

    [Header ("Settings Game Play")]
    public GameObject gamePlay;
    public Text txtJump;
    public Text txtScore;
    public Text txtLevel;

    [Header ("Settings Game Over")]
    public GameObject gameOver;
    public Text txtScoreGameOver;
    public Text txtRecordGameOver;

    private int jump;
    private int score;
    private int level;

    public int Jump {
        get { return jump; }
        set {
            jump = value;
            txtJump.text = "Jump: " + jump;
        }
    }

    public int Score {
        get { return score; }
        set {
            score = value;
            txtScore.text = "Score: " + score;
        }
    }

    public int Level {
        get { return level; }
        set {
            level = value;
            txtLevel.text = "Level: " + level;
        }
    }

    public void GameOver () {
        if (Score > PlayerPrefs.GetInt ("RECORD"))
            PlayerPrefs.SetInt ("RECORD", Score);

        txtScoreGameOver.text = "Score:\n" + score;
        txtRecordGameOver.text = "Record:\n" + PlayerPrefs.GetInt ("RECORD");

        gamePlay.SetActive (false);
        gameOver.SetActive (true);
    }


    public void Buttons(string value) {
        switch(value) {
            case "MENU":
                SceneManager.LoadScene("Menu");
            break;

            case "RESTART":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            break;
        }
    }
}