using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float score = 0;
    public Text scoreDisplay;
    public Player player;

    // Update is called once per frame
    void Update()
    {
        //Update Score
        if (player.health > 0)
        {
            score += Time.deltaTime;
        }
        //Display Score
        scoreDisplay.text = score.ToString();
    }
}
