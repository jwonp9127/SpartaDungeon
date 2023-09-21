using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public JobStatsData jobstat;

    public int Exp { get; private set; }
    public string Description { get; private set; }
    public int Atk { get; private set; }
    public int Def { get; private set; }
    public int Hp { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    
    public TMP_Text playerName;
    public TMP_Text playerLevel;
    public TMP_Text playerGold;
    public TMP_Text playerDescription;
    public TMP_Text playerAtk;
    public TMP_Text playerDef;
    public TMP_Text playerHp;
    public TMP_Text playerCritical;
    public Slider playerExpSlider;
    public TMP_Text playerExpText;
    
    private void Start()
    {
        Name = "콘치즈삼겹살";
        Level = 1;
        Exp = 1;
        Description = jobstat.description;
        Atk = jobstat.atk;
        Def = jobstat.def;
        Hp = jobstat.hp;
        Critical = jobstat.critical;
        Gold = 1000;
        
        playerName.text = Name;
        playerLevel.text = Level.ToString();
        playerGold.text = Gold.ToString();
        playerDescription.text = Description;
        playerAtk.text = Atk.ToString();
        playerDef.text = Def.ToString();
        playerHp.text = Hp.ToString();
        playerCritical.text = Critical.ToString();
        playerExpSlider.value = (float)Exp / (Level * 10);
        playerExpText.text = $"{Exp} / {Level * 10}";
    }
}
