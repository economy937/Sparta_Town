using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public InputField NameInput;
    public string PlayerName = null;

    public void StartBtn()
    {
        PlayerName = NameInput.text;
        if (!string.IsNullOrEmpty(PlayerName))
        {
            PlayerPrefs.SetString("PlayerName", NameInput.text);
            Debug.Log(PlayerName);
            SceneManager.LoadScene("Main");
        }
    }

}
