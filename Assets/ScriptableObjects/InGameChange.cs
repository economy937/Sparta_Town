using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public GameObject Changename;
    public InputField NameInput;
    public string PlayerName = null;
    public AudioSource Bgm;


    public void DisplayNameChangeInput()
    {
        Changename.SetActive(true);

        Time.timeScale = 0f;

    }
    public void NameChange()
    {
        PlayerName = NameInput.text;
        
        if (!string.IsNullOrEmpty(PlayerName))
        {
            
            PlayerPrefs.SetString("PlayerName", NameInput.text);
            Debug.Log(PlayerName);
            Changename.SetActive(false);
            Time.timeScale = 1f;

        }
    }
    public void InGameChange()
    {
        Bgm.Play();
        if ("Woman" == PlayerPrefs.GetString("Character"))
        {

            PlayerPrefs.DeleteKey("Character");
            PlayerPrefs.SetString("Character", "Man");
        }
        else
        {
            PlayerPrefs.DeleteKey("Character");
            PlayerPrefs.SetString("Character", "Woman");
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
