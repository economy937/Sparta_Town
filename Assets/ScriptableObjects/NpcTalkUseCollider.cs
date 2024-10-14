using UnityEngine;
using UnityEngine.UI;
public class NpcTalk2 : MonoBehaviour
{
    public GameObject Talk;
    public GameObject TalkBox;
    public Text NpcName;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision) //OnTriggerEnter2D로 구현 강채린 매니저 적용 중 범위 알 수 있어 OverlapCircle 보다 더 좋은 듯 
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("대화가능");
            Talk.SetActive(true);
        }
       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Talk.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(Talk.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                NpcName.text = name;
                TalkBox.SetActive(true);
                Time.timeScale = 0.0f;
            }
        }
    }
}
