using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5.0f;  //移动速度
    public float rotateDuration = 0.5f;  //旋转动画的持续时间

    private void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void HandleMovement()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            moveDirection += Vector3.up;
        if (Input.GetKey(KeyCode.S))
            moveDirection += Vector3.down;
        if (Input.GetKey(KeyCode.A))
            moveDirection += Vector3.left;
        if (Input.GetKey(KeyCode.D))
            moveDirection += Vector3.right;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);
    }

    private void HandleRotation()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.DORotate(transform.rotation.eulerAngles + new Vector3(0, 90, 0), rotateDuration, RotateMode.Fast);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.DORotate(transform.rotation.eulerAngles + new Vector3(90, 0, 0), rotateDuration, RotateMode.Fast);
        }
    }
}
