using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField, Header("�X�R�A���Z����|�C���g")] int _scorePlusPoint;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().ScorePointPlus(_scorePlusPoint);
            Destroy(this.gameObject);
        }
    }
}
