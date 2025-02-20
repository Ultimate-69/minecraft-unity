using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Options")]
    [SerializeField] private float moveSpeed;
    [Space]
    [SerializeField] private GameObject player;
    [SerializeField] private Rigidbody rb;

    private float horizontalInput;
    private float forwardInput;
    private float verticalInput;

    private Vector3 moveDirection;

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        forwardInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.Q))
        {
            if (verticalInput > -1)
            {
                verticalInput -= Time.deltaTime;
            }
        }
        else if (Input.GetKey(KeyCode.E))
        {
            if (verticalInput < 1)
            {
                verticalInput += Time.deltaTime;
            }
        }
        else
        {
            verticalInput = 0;
        }

        Debug.Log(verticalInput);
    }

    void FixedUpdate() 
    {
        moveDirection = (player.transform.forward * forwardInput + player.transform.right * horizontalInput + player.transform.up * verticalInput).normalized;
        rb.linearVelocity = moveDirection * moveSpeed;
    }

}