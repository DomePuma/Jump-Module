using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] jump jump;
    void Start()
    {
        jump = GetComponent<jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            jump.Jump();
        }
    }
}
