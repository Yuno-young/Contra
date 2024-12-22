using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target; // Đối tượng mà camera theo dõi
    private float currentY; // Lưu vị trí Y hiện tại của camera

    void Start()
    {
        // Khởi tạo currentY bằng vị trí Y ban đầu của camera
        currentY = transform.position.y;
    }

    void LateUpdate()
    {
        // Nếu target có vị trí Y cao hơn currentY, cập nhật currentY
        if (target.position.y > currentY)
        {
            currentY = target.position.y;
        }

        // Cập nhật vị trí của camera (chỉ di chuyển theo trục Y)
        transform.position = new Vector3(transform.position.x, currentY, transform.position.z);
    }
}
