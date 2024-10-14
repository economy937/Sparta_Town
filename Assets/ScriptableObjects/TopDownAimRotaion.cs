using UnityEngine;

public class TopDownAimRotaion : MonoBehaviour
{

    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private SpriteRenderer characterRenderer2;
    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 diretion)
    {
        RotateArm(diretion);
    }

    private void RotateArm(Vector2 diretion)
    {
        if(Time.timeScale != 0f)
        {
            float rotZ = Mathf.Atan2(diretion.y, diretion.x) * Mathf.Rad2Deg;

            characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
            characterRenderer2.flipX = Mathf.Abs(rotZ) > 90f;
        }
        
    }
}