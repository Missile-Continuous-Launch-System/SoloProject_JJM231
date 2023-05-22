using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController: MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    public float jumpForce = 5f;
    public float runMultiplier = 2f;

    private float originalMoveSpeed;
    private float originalRotationSpeed;
    private Rigidbody rb;
    private bool isJumping = false;
    private bool isRunning = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        originalMoveSpeed = moveSpeed;
        originalRotationSpeed = rotationSpeed;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // 플레이어 이동 처리
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = transform.right * horizontalMovement + transform.forward * verticalMovement;

        if (isRunning)
        {
            movement *= moveSpeed * runMultiplier;
        }
        else
        {
            movement *= moveSpeed;
        }

        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);

        // 플레이어 회전 처리
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        transform.Rotate(Vector3.up * mouseX);

        // 점프 처리
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isJumping = true;
        }

        // 달리기 처리
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
            moveSpeed = originalMoveSpeed * runMultiplier;
            rotationSpeed = originalRotationSpeed * runMultiplier;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
            moveSpeed = originalMoveSpeed;
            rotationSpeed = originalRotationSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 바닥에 닿았을 때 점프 가능 상태로 초기화
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
