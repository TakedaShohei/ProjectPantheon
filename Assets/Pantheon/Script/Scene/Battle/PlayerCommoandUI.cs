using UnityEngine;
using System.Collections;

public class PlayerCommoandUI : MonoBehaviour
{
    BattleMain battle_main_ = null;

    public void Setup(BattleMain  battle_main)
    {
        battle_main_ = battle_main;
    }

    public void AttackBtnClick()
    {
        AttackAction action = new AttackAction();
        //action.entity_ = XXX;
        //action.target_ = XXX;
        battle_main_.AddAction(action);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
