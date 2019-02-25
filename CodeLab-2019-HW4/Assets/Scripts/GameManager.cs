using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //int score;
    public Text scoreText;
    public Text highScoreText;

    private const string PLAYER_PREF_HIGHSCORE = "highScore "; //const= constant means sth doest change

    int score = 0;

    public int Score
    {

        get
        {
            return score;
        }
        
        set
        {
            score = value;
            scoreText.text = "Score " + score;
            HighScore = score;
        }
    }

    private int highScore = 0;

    public int HighScore
    {
        get
        {
            return highScore;
            
        }
        set
        {
            if (value > highScore) //when score > high score, renew the high score to current score
            {
                highScore = value;
                highScoreText.text = "High Score " + highScore;
                PlayerPrefs.SetInt(PLAYER_PREF_HIGHSCORE, highScore);
            }
        }
    }

    public static GameManager instance;
    
    
    // Start is called before the first frame update
    void Start()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            

        }
        else
        {
            Destroy(gameObject);
        }

        HighScore = PlayerPrefs.GetInt(PLAYER_PREF_HIGHSCORE, 10);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
