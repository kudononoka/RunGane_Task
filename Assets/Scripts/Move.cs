using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField, Header("スピード")] float _moveSpeed;
    bool isStop = false;
    float time;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //停止
        if (isStop)
        {
            _rigidBody.velocity = Vector3.zero;
        }
        else
        {
            //移動
            _rigidBody.velocity = new Vector3(0, 0, _moveSpeed);
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
