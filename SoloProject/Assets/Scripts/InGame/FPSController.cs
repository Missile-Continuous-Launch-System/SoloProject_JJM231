using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FPSController : MonoBehaviour
{
    public float movementSpeed = 5f;    // 이동 속도
    public float rotationSpeed = 3f;    // 회전 속도

    private float mouseX;    // 마우스 X축 입력값
    private float mouseY;    // 마우스 Y축 입력값

    private float verticalRotation = 0f;
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;    // 마우스 커서 숨기기
    }

    private void Update()
    {
        // 키 입력 받기
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        // 앞/뒤 이동
        Vector3 movement = transform.forward * verticalMovement + transform.right * horizontalMovement;
        characterController.SimpleMove(movement * movementSpeed);

        // 좌우 회전
        transform.Rotate(Vector3.up, mouseX * rotationSpeed);

        // 상하 회전
        verticalRotation -= mouseY * rotationSpeed;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);
    }
}
