using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterChange : MonoBehaviour
{
    
    public SpriteRenderer Select1;
    public SpriteRenderer Select2;
    public AudioSource Bgm;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("Character", "Woman");
        Select1.color = Color.blue;
        Select2.color = Color.gray;
    }

    public void SelectCh1()
    {
        Bgm.Play();
        PlayerPrefs.DeleteKey("Character");
        PlayerPrefs.SetString("Character", "Woman");
        Select1.color = Color.blue;
        Select2.color = Color.gray;
    }

    public void SelectCh2()
    {
        Bgm.Play();
        PlayerPrefs.DeleteKey("Character");
        PlayerPrefs.SetString("Character", "Man");
        Select2.color = Color.blue;
        Select1.color = Color.gray;
        Debug.Log("man");
    }

   

    // Update is called once per frame
    void Update()
    {
        

    }

}
