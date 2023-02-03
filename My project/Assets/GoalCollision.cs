using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollision : MonoBehaviour
{
    public ScoreHnadling score;
    public int pointsAdd;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Destroy(collision.gameObject);
            score.scoreIncrease(pointsAdd);
        }
    }
}
