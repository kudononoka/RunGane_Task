using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField, Header("�O�����̑��x")] float _moveSpeed;
    [SerializeField, Header("���ړ��̑��x")] float _moveXSpeed;
    bool isStop = false;
    float time;
    Vector3 playerPos;
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //��~
        if (isStop)
        {
            _rigidBody.velocity = Vector3.zero;
        }
        else
        {
            float x = Input.GetAxisRaw("Horizontal");
            if(transform.position.x < -9 && x == -1 || transform.position.x > 9 && x == 1)
            {
                _rigidBody.velocity = Vector3.forward * _moveSpeed;
            }
            else
            {
                _rigidBody.velocity = Vector3.right * x * _moveXSpeed + Vector3.forward * _moveSpeed;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //�S�[��������
        if (other.gameObject.CompareTag("Goal"))
        {
            isStop = true;
        }
    }
}
