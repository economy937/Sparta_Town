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

    private void OnTriggerEnter2D(Collider2D collision) //OnTriggerEnter2D�� ���� ��ä�� �Ŵ��� ���� �� ���� �� �� �־� OverlapCircle ���� �� ���� �� 
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("��ȭ����");
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
