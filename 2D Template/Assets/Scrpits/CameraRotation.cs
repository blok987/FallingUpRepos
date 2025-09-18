using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private float sensX;
    [SerializeField]
    private float sensY;

    private float yRotation;
    private float xRotation;
    public Transform orientation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
    }
}
