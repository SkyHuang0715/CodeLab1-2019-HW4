using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;

    public int Score
    {

        get
        {
            return score;
        }
        
        set
        {
            score = value; 
            
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
