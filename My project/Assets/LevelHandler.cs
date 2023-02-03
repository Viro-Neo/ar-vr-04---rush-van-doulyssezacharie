using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour
{
    public enum Level
    {
        EASY = 1,
        MEDIUM = 2,
        HARD = 3,
        EXTREME = 4,
        HELL = 5,
    }
    public Text levelText;
    public ScoreHnadling score;
    Level actualLevel;
    // Start is called before the first frame update

    public Level GetLevel()
    {
        return actualLevel;
    }
    void Start()
    {
        actualLevel = Level.EASY;
        levelText.text = actualLevel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (actualLevel != Level.HELL && score.getScore() > ((int)actualLevel) * 1000)
        {
            actualLevel = actualLevel + 1;
            levelText.text = actualLevel.ToString();
        };
    }
}
