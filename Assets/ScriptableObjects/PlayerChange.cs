using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChange : MonoBehaviour
{
    public Text Name;
    public Text AttName;

    public SpriteRenderer Select1;
    public SpriteRenderer Select2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Name.text = PlayerPrefs.GetString("PlayerName");
        AttName.text = Name.text;
        if ("Woman" == PlayerPrefs.GetString("Character"))
        {
            Select1.enabled = true;
            Select2.enabled = false;
        }
        else
        {
            Select1.enabled = false;
            Select2.enabled = true;
        }
    }
}
