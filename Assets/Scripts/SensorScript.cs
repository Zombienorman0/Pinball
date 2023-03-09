using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SensorScript : MonoBehaviour
{
    [SerializeField] Transform ballSpawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(WaitForRespawn(collision));
    }

    IEnumerator WaitForRespawn(Collider2D collider)
    {
        yield return new WaitForSeconds(2);
        collider.attachedRigidbody.transform.position = ballSpawnPoint.position;
    }
}
