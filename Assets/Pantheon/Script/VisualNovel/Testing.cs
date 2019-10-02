using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Testing : MonoBehaviour
{
    DialogueSystem dialogue;
    VisualNovelInfo info_;

    // Use this for initialization
    void Start()
    {
        dialogue = DialogueSystem.instance;
    }
    public string[] s = new string[]
    {
        "hero:Avira",
        "hero",
        "Tobehonest"
    };
    int index = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!dialogue.isSpeaking || dialogue.isWaitingForUserInput)
            {
              if(index >= s.Length)
                {
                    return;
                }
                Say(s[index]);
                    index++;
                
            }
        }
    }

    void Say(string s)
    {
        string[] parts = s.Split(':');
        string speech = parts[0];
        string speaker = (parts.Length >= 2) ? parts[1] : "";

        dialogue.Say(speech, speaker);
    }
}
