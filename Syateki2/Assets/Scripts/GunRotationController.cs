using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotationController : MonoBehaviour
{
    public float rotationSpeed = 5f; // 回転の速度

    // Update is called once per frame
    void Update()
    {
        // 上下左右キーで銃口の向きを変える
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        RotateGun(horizontalInput, verticalInput);
    }

    void RotateGun(float horizontalInput, float verticalInput)
    {
        // 現在の回転角度を取得
        Vector3 currentRotation = transform.localEulerAngles;

        // 新しい回転角度を計算
        float newRotationY = currentRotation.y + horizontalInput * rotationSpeed;
        float newRotationX = currentRotation.x - verticalInput * rotationSpeed;

        // 新しい回転角度を設定
        transform.localEulerAngles = new Vector3(newRotationX, newRotationY, currentRotation.z);
    }
}
