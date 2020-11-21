using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    private bool toggle = true;
    public float Yincrement;
    public float speed;

    public int health = 2;

    public Text healthDisplay;

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = new Vector2(0f, 2.66f);
    }

    // Update is called once per frame
    void Update()
    {
        //Display Text
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            gameOver.SetActive(true);
            //Destroy Player Character
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && !toggle)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + 5);
            //transform.position = targetPos;
            toggle = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && toggle)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 5);
            //transform.position = targetPos;
            toggle = false;
        }
    }
}
