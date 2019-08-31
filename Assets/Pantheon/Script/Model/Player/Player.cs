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
    PlayerInfo info_;
    
    private void SetUp(PlayerModel player)
    {
        


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