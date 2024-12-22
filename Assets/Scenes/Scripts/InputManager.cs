using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour 
{
    public static bool JumpButtonPressed
	{
		get
		{
            return Input.GetKeyDown (KeyCode.Space);
        }
	}
	public static bool AttackButtonPressed
	{
		get
		{
			return Input.GetKeyDown (KeyCode.J);
		}
	}
	public static bool JumpButton
	{
		get
		{
			return Input.GetKey (KeyCode.Space);
		}
	}
	public static bool AttackButton
	{
		get
		{
			return Input.GetKey (KeyCode.J);
		}
	}
	public static float HorizontalAxis
	{
		get
		{
			return Input.GetAxis ("Horizontal");
		}
	}
	public static float VerticalAxis
	{
		get
		{
			return Input.GetAxis ("Vertical");
		}
	}


    /*public bool JumpButtonPressed = false;
    public bool AttackButtonPressed = false;
    public bool JumpButton = false;
    public bool AttackButton = false;

    public void OnJumpButtonPressed()
    {
        JumpButtonPressed = true;
    }
    public void OnAttackButtonPressed()
    {
        AttackButtonPressed = true;
    }
    public void OnJButtonPressed()
    {
        JumpButton = true;
    }
    public void OnAButtonPressed()
    {
        AttackButton = true;
    }

    private void Update()
    {
        if (JumpButtonPressed)
        {
            // Trạng thái button đã được nhấn, thực hiện hành động tương ứng
            Debug.Log("Button is pressed!");
            // Đặt lại giá trị của isButtonPressed về false để sẵn sàng cho lần nhấn tiếp theo
            JumpButtonPressed = false;
        }
        if (AttackButtonPressed)
        {
            // Trạng thái button đã được nhấn, thực hiện hành động tương ứng
            Debug.Log("Button is pressed!");
            // Đặt lại giá trị của isButtonPressed về false để sẵn sàng cho lần nhấn tiếp theo
            AttackButtonPressed = false;
        }
        if (JumpButton)
        {
            // Trạng thái button đã được nhấn, thực hiện hành động tương ứng
            Debug.Log("Button is pressed!");
            // Đặt lại giá trị của isButtonPressed về false để sẵn sàng cho lần nhấn tiếp theo
            JumpButton = false;
        }
        if (AttackButton)
        {
            // Trạng thái button đã được nhấn, thực hiện hành động tương ứng
            Debug.Log("Button is pressed!");
            // Đặt lại giá trị của isButtonPressed về false để sẵn sàng cho lần nhấn tiếp theo
            AttackButton = false;
        }
    }*/
}
