using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(DynamicJoystick))]
public class JoystickInput : PlayerSelecter<PlayerMovement>
{
    private DynamicJoystick _dynamicJoystick;

    private bool HaveOffset => Mathf.Abs(_dynamicJoystick.Vertical) > 0 || Mathf.Abs(_dynamicJoystick.Horizontal) > 0;
    private void Start()
    {
        _dynamicJoystick = GetComponent<DynamicJoystick>();
    }
    private void FixedUpdate()
    {
        if(HaveOffset)
        {
            float vertical = _dynamicJoystick.Vertical;
            float horizontal = _dynamicJoystick.Horizontal;

            Player.Move(new Vector2(horizontal, vertical));
        }
    }
    
}
