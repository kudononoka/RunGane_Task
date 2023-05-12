using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _score;
    UIManager _uiManager;

    private void Start()
    {
        _uiManager = FindObjectOfType<UIManager>();
    }
    public void ScorePointPlus(int plusPoint)
    {
        _score += plusPoint;
        _uiManager.ScoreUILoad(_score);
    }
}
