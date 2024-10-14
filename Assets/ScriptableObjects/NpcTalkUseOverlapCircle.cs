using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NpcTalk1 : MonoBehaviour
{
    public LayerMask PlayerLayer;
    public GameObject Talk;
    public GameObject TalkBox;
    public float distance =3.0f;
    public Text NpcName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cnaTalk = Physics2D.OverlapCircle(transform.position, distance, PlayerLayer);
        if (cnaTalk != null)
        {
            Talk.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E))
            {
                NpcName.text = name;
                TalkBox.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
        else
        {
            Talk.SetActive(false);
        }
    }
    public void TalkBoxClose()
    {
        Time.timeScale = 1.0f;
        TalkBox.SetActive(false);
    }

}
