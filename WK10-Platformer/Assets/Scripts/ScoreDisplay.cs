using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    //public Text livesText;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*livesText = GetComponent<Text>();
        livesText.text = "Lives: " + GameManager.instance.lives;*/

        scoreText = GetComponent<Text>();
        scoreText.text = "Points: " + GameManager.instance.score + "/3";
    }
}
