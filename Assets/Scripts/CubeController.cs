using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField, Header("スコア加算するポイント")] int _scorePlusPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().ScorePointPlus(_scorePlusPoint);
            Destroy(this.gameObject);
        }
    }
}
