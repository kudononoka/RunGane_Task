using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CubeGeneration : MonoBehaviour
{
    [SerializeField, Header("CubePrefab")] GameObject _cubePrefab;
    [SerializeField, Header("Cube�u���Ԋu")] float _distance;
    [SerializeField, Header("��������ꏊ�͈̔�")] Transform[] _startEnd;
    [SerializeField, Header("��������ꏊX")] float[] _generatePosX;
    void Start()
    {
        Vector3 generationPos = _startEnd[0].position;
        Vector3 end = _startEnd[1].position;
        while (generationPos.z < end.z)
        {
            Instantiate(_cubePrefab, generationPos, Quaternion.identity);
            generationPos.z += _distance;
            int index = Random.Range(0, _generatePosX.Length);
            generationPos.x = _generatePosX[index];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
