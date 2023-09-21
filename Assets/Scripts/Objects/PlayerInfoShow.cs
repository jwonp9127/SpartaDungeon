using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInfoShow : MonoBehaviour
{
    private Player _player;
    public TMP_Text playerName;
    public TMP_Text playerGold;
    public TMP_Text playerDescription;
    public TMP_Text playerAtk;
    public TMP_Text playerDef;
    public TMP_Text playerHp;
    public TMP_Text playerCritical;
    
    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Start()
    {
        playerName.text = _player.Name;
        playerGold.text = _player.Gold.ToString();
        playerDescription.text = _player.Description;
        playerAtk.text = _player.Atk.ToString();
        playerDef.text = _player.Def.ToString();
        playerHp.text = _player.Hp.ToString();
        playerCritical.text = _player.Critical.ToString();
    }
    
    
}
