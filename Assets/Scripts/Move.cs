using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField, Header("前方向の速度")] float _moveSpeed;
    [SerializeField, Header("横移動の速度")] float _moveXSpeed;
    bool isStop = false;
    float time;
    int count = 0;
    float _moveXDir = 0;
    Vector3 playerPos;
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _moveXDir = 0;
        if (Input.GetKeyDown(KeyCode.LeftArrow) && count > -1)
        {
            _moveXDir = -1;
            count--;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && count < 1)
        {
            _moveXDir = 1;
            count++;
        }
        _rigidBody.AddForce(Vector3.right * _moveXDir * _moveXSpeed, ForceMode.Impulse);
    }
    
    void FixedUpdate()
    {
        //停止
        if (isStop)
        {
            _rigidBody.velocity = Vector3.zero;
        }
        else
        {
            _rigidBody.velocity = Vector3.forward * _moveSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //ゴールしたら
        if (other.gameObject.CompareTag("Goal"))
        {
            isStop = true;
        }
    }
}
