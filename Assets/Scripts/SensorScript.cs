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

    public void Start()
    {
        text.text = $"Lives: {Lives}";
    }
    public void Update()
    {
        if (Lives < 0)
        {
            SceneManager.LoadScene("Opening");
        }else
        if (Lives < 1)
        {
            takeDamage(Lives);
        }else if (Lives < 2)
        {
            takeDamage(Lives);
        }
        else if(Lives < 3)
        {
            takeDamage(Lives);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            
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
        Lives -= d;
        text.text = Lives.ToString();
    }
}
