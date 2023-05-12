using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Header("PlayerPos")] Transform _playerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(0, 7 + _playerPos.position.y, -7 + _playerPos.position.z);
        transform.position = pos;
    }
}
