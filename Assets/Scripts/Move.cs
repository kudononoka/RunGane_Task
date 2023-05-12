using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody _rigidBody;
    [SerializeField, Header("‘O•ûŒü‚Ì‘¬“x")] float _moveSpeed;
    [SerializeField, Header("‰¡ˆÚ“®‚Ì‘¬“x")] float _moveXSpeed;
    bool isStop = false;
    float time;
    int count = 0;
    Vector3 playerPos;
    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //’âŽ~
        if (isStop)
        {
            _rigidBody.velocity = Vector3.zero;
        }
        else
        {
            float x = 0;
            if(Input.GetKeyDown(KeyCode.LeftArrow) && count > -1)
            {
                x = -1;
                count--;
            }
            else if(Input.GetKeyDown(KeyCode.RightArrow) && count < 1)
            {
                x = 1;
                count++;
            }
            _rigidBody.velocity = Vector3.forward * _moveSpeed;
            _rigidBody.AddForce(Vector3.right * x * _moveXSpeed, ForceMode.Impulse);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //ƒS[ƒ‹‚µ‚½‚ç
        if (other.gameObject.CompareTag("Goal"))
        {
            isStop = true;
        }
    }
}
