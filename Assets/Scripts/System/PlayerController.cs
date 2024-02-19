using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Vector2 move;
    
    [Header("Player Settings")]
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
    }

    private void FixedUpdate() {
        Vector2 position = rigidbody2D.position + (playerSpeed * Time.deltaTime * move);
        rigidbody2D.MovePosition(position);
    }

    // Update is called once per frame
    void Update()
    {
        move = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
