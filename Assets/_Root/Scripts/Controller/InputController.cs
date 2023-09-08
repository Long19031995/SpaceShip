using UnityEngine;

public class InputController : Singleton<InputController>
{
    private Vector3 mousePos;
    public Vector3 MousePos => mousePos;

    private void FixedUpdate()
    {
        GetMousePos();
    }

    protected virtual void GetMousePos()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
