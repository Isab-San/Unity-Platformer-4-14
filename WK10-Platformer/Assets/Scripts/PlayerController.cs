using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 5;

    Animator characterAnim;
    public SpriteRenderer characterSprite;

    AudioSource aS;

    //public int lives = 3;

    //public int coinAmount = 0;

    public Vector3 respawnPoint;
    public GameObject respawnTrigger;

    // Start is called before the first frame update
    void Start()
    {
        characterAnim = GetComponentInChildren<Animator>();

        aS = GetComponent<AudioSource>();

        //characterSprite = GetComponentInChildren<SpriteRenderer>();

        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        characterAnim.SetFloat("speed", Mathf.Abs(h));

        characterSprite.flipX = h < 0;

        //transform.Translate(Vector3.right * h * Time.deltaTime * speed);

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        Vector3 vel = new Vector3();

        vel.x = h * speed;
        vel.y = rb.velocity.y;
        vel.z = 0;

        //rb.velocity = vel;

        if (Input.GetButtonDown("Jump"))
        {
            //rb.AddForce(Vector2.up * jumpForce);
            aS.Play();
            vel.y = jumpForce;
        }

        rb.velocity = vel;
    }

    public void Respawn()
    {
        /*float v = Input.GetAxis("Vertical");
        
        if(v < -4)
        {
            gameObject.y =
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Triggered: " + collision.gameObject.name);

        if (collision.tag == "RespawnTrigger")
        {
            GameManager.instance.lives -= 1;
            Debug.Log(GameManager.instance.lives);
            transform.position = respawnPoint;

            if (GameManager.instance.lives == 0)
            {
                SoundManager.instance.PlaySound(1);
                SceneManager.LoadScene("GameOverScene");
                GameManager.instance.lives = 3;
                GameManager.instance.score = 0;
            }

        }

    }
}
