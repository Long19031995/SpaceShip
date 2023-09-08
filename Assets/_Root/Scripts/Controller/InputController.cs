using UnityEngine;

public class InputController : Singleton<InputController>
{
    private Vector3 mousePos;
    public Vector3 MousePos => mousePos;

    private float onFiring;
    public float OnFiring => onFiring;

    private void FixedUpdate()
    {
        this.GetMousePos();
        this.GetFiring();
    }

    protected virtual void GetMousePos()
    {
        this.mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    protected virtual void GetFiring()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }
}
