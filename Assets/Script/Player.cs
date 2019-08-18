using UnityEngine;
using UnityEditor;
using System.Collections.Generic;


public class Player : ScriptableObject
{
    string name_;
    int hp_;
    int power_;
    int defence_;
    public GameObject view;
    public Canvas health_UI_;
    public Canvas damage_effect_;
    PlayerInfo info;
    
    private void SetUp(string name, int hp, int power, int defence)
    {
        name_ = name;

        hp_ = hp;
        power_ = power;
        defence_ = defence;


    }
    public  void Attack()
    {

    }

    public void PlayerMove()
    {

    }

    private void OnDestroy()
    {
        
    }

}