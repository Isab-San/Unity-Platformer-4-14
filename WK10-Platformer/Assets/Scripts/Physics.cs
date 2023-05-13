using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Physics : MonoBehaviour
{
    //public int coinAmount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //SoundManager.instance.PlaySound(0);
        //coinAmount += 1;
        //Debug.Log(coinAmount);
        //Debug.Log("COLLISION");

        //Debug.Log("Collided with: " + collision.gameObject.name);

        //Destroy(collision.gameObject); destroy whatever this object hits
        //Destroy(gameObject); //destoy this object when it hits something. useful for coins?

        if (gameObject.tag == "Coin")
        {
            SoundManager.instance.PlaySound(0);
            GameManager.instance.score ++;
            Debug.Log(GameManager.instance.score);
            Destroy(gameObject);

            if(GameManager.instance.score == 3)
            {
                SoundManager.instance.PlaySound(2);
                StartCoroutine(Wait());
                SceneManager.LoadScene("VictoryScene");
                GameManager.instance.score = 0;
                GameManager.instance.lives = 3;
            }
        }

    }
}
