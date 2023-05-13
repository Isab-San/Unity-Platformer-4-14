using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void GoToGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }

    public void GoToVictory()
    {
        SceneManager.LoadScene("VictoryScene");
    }

    public void GoToTitleScreen()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
