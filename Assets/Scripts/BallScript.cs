using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    Rigidbody2D rb;
    PhysicMaterial bounce;
    Collider2D collision;
    public TMP_Text text;
    public TMP_Text Highscoretext;
    int score = 0;
    Scene scene;
    void Start()
    {
        
        text.text = $"Score: {score}";
        Highscoretext.text = $"Score: {score}";
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        text.text = $"Score: {score}";
        Highscoretext.text = $"Score: {score}";
    }

    public void SetBallPosition(Vector2 position)
    {
        rb.transform.position = position;
        rb.velocity = Vector2.zero;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bounce"))
        {
            score += 100;
            text.text = score.ToString();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bounce"))
        {
            score += 100;
            text.text = score.ToString($"Score: {score}");
        }
    }

}
