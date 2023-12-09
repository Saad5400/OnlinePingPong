using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HardAI : EasyAI
{
    void Awake()
    {
        enabled = GameManager.gameMode == GameMode.HardAI;
    }
}