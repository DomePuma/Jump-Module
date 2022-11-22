using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] jump jump;
    void Start()
    {
        jump = GetComponent<jump>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.Jump();
        }
    }
}
