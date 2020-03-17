using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
[CreateAssetMenu(
   fileName = "PlayerCommandInfo",
   menuName = "Pantheon/PlayerCommandInfo",
   order = 11)
]

public class PlayerCommandInfo : ScriptableObject
{
    [SerializeField] private GameObject player_hp_bar_; 
    public GameObject PlayerHpBar
    {
        get { return player_hp_bar_; }
        protected set { player_hp_bar_ = value; }
    }
    [SerializeField] private GameObject player_action_button_;
    public GameObject PlayerActionButton
    {
        get { return player_action_button_; }
        protected set { player_action_button_ = value; }
    }
    [SerializeField] private GameObject player_command_ui_;
    public GameObject PlayerCommandUI
    {
        get { return player_command_ui_; }
        protected set { player_command_ui_ = value; }
    }
    [SerializeField] private GameObject player_damage_text_ui_;
    public GameObject PlayerDamageTextUi
    {
        get { return player_damage_text_ui_; }
        protected set { player_damage_text_ui_ = value; }
    }
}