using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text _scoreUI; 
    public void ScoreUILoad(int score)
    {
        _scoreUI.text = $"score : {score}";
    }
}
