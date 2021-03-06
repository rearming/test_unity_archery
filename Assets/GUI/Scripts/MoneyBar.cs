﻿using GameManager;
using GenericScripts;
using UnityEngine;
using UnityEngine.UI;
using EventType = GenericScripts.EventType;

namespace GUI.Scripts
{
    public class MoneyBar : MonoBehaviour
    {
        private Text _text;
    
        void Start()
        {
            _text = GetComponentInChildren<Text>();
            EventManager.Instance.AddListener(EventType.SendReward, (type, sender, o) =>
            {
                var gameData = sender as GameData;
                if (gameData != null)
                    _text.text = gameData.PlayerMoney.ToString();
            });
        }
    }
}
