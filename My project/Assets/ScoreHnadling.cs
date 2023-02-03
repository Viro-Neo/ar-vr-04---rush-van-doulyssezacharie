using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHnadling : MonoBehaviour
{
    int score;
    public Text scoreText;


    public int getScore()
    {
        return score;
    }

    public void scoreIncrease(int addValue)
    {
        score += addValue;
        scoreText.text = "Score\n".ToString() + score.ToString();
    }

    void scoreDecrease(int subValue)
    {
        score -= subValue;
        scoreText.text = "Score\n".ToString() + score.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score\n".ToString() + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
