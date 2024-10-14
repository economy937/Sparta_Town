using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attendee : MonoBehaviour
{
    
    public GameObject AttendeeList;
    public Text NpcListText;
    public List<string> npcNames = new List<string>();

    private void Start()
    {
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("Npc");

        foreach (GameObject NPC in npcs)
        {
            npcNames.Add(NPC.name);
        }
        UpdateNPCList();
    }
    void UpdateNPCList()
    {
        NpcListText.text = ""; 

        foreach (string name in npcNames)
        {
            NpcListText.text += name + "\n";
        }
    }


    public void AttendeeListOpen()
    {
        AttendeeList.SetActive(true);
    }

    public void AttendeeListClose()
    {
        AttendeeList.SetActive(false);
    }

}
