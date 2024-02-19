using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Player Settings")]
    public float playerSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // QualitySettings.vSyncCount = 0;
        // Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += playerSpeed * Time.deltaTime * move;
    }
}
