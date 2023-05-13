using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapScript : MonoBehaviour
{
    public GameObject explosionPrefab;

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
        yield return new WaitForSeconds(5);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if(collision.transform.tag == "Ground")
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }*/
        SoundManager.instance.PlaySound(1);

        if (gameObject.tag == "Trap")
        {
            GameManager.instance.lives = 0;

            if(GameManager.instance.lives == 0)
            {
                StartCoroutine(Wait());
                SceneManager.LoadScene("GameOverScene");
                GameManager.instance.lives = 3;
                GameManager.instance.score = 0;
            }
        }
    }
}
