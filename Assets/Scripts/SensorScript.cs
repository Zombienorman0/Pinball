using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using TMPro;

public class SensorScript : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField] Transform ballSpawnPoint;
    [SerializeField] int Lives;
    bool notHit;

    public void Start()
    {
        text.text = $"Lives: {Lives}";
        notHit = false;
    }
    public void Update()
    {
        text.text = $"Lives: {Lives}";
        if (Lives < 1)
        {
            SceneManager.LoadScene("Closing");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            takeDamage(Lives);
            StartCoroutine(WaitForRespawn(collision));
        }
        
    }

    IEnumerator WaitForRespawn(Collider2D collider)
    {
        yield return new WaitForSeconds(1);
        collider.attachedRigidbody.transform.position = ballSpawnPoint.position;
    }

    public void takeDamage(int d)
    {
        if (notHit = true)
        {
            Lives--;
            notHit = false;
            text.text = Lives.ToString();
            
        }
        
    }
}
