using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    public Text scoreText;

    public float score;
    public static float real_score;

    public float countDownTimer;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreText.GetComponent<Text>();
        
        
        score = 0f;
        real_score = 0f;
    }

    void ScorePlus()
    {
        

        score += Time.deltaTime * 15;
        real_score = Mathf.Floor(score);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ScorePlus", countDownTimer);

        
        scoreText.text = real_score.ToString() + "m";
    }
}
