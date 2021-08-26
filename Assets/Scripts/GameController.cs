using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text buttonText;
    private void Awake()
    {
        Application.targetFrameRate = 30;
    }
    public void PressButton()
    {
        buttonText.text = Random.Range(1, 11).ToString();
    }
}
