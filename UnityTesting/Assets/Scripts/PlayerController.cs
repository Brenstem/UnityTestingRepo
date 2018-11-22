using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    private int count;

    [SerializeField] float speed;
    [SerializeField] Text score;
    [SerializeField] Text victoryText;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        victoryText.text = "";
        setScore();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;
            setScore();
        }
    }

    void setScore()
    {
        score.text = "Score: " + count.ToString();

        if (count >= 8)
        {
            victoryText.text = "you win";
        }
    }
}
