using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Camera Camera;
    public Transform StartPositionCamera;
    public GameObject Menu;

    public float MoveSpeed = 10;
    public float RotateSpeed = 4;
    float xRotate;
    float yRotate;


    void Start()
    {
        UpdateRotation();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        MouseClick();
        HotKey();
        Move();
        Rotate();
    }

    void MouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray cameraRay = Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(cameraRay, out hit))
            {
                Transform newPositionCamera = Camera.transform;

                Laptop laptop = hit.transform.GetComponent<Laptop>();
                newPositionCamera = laptop ? laptop.GetPositionCamera() : newPositionCamera;

                PC pc = hit.transform.GetComponent<PC>();
                newPositionCamera = pc ? pc.GetPositionCamera() : newPositionCamera;

                Port1 port = hit.transform.GetComponent<Port1>();
                port?.InputCabel();

                Camera.transform.position = newPositionCamera.position;
                Camera.transform.rotation = newPositionCamera.rotation;
            }
            UpdateRotation();
        }
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray cameraRay = Camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(cameraRay, out hit))
            {
                Button button = hit.transform.GetComponent<Button>();
                button?.GetButton();
            }
        }
    }

    void HotKey()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Menu.SetActive(!Menu.activeInHierarchy);
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        float z = -Input.GetAxis("Vertical");

        Vector3 offset = new Vector3(x * MoveSpeed * Time.deltaTime, 0, -z * MoveSpeed * Time.deltaTime);

        Camera.transform.Translate(offset);

        float pointX = Mathf.Clamp(Camera.transform.position.x, -4, 4);
        float pointZ = Mathf.Clamp(Camera.transform.position.z, -4, 4);
        float pointY = Mathf.Clamp(Camera.transform.position.y, 1.2f, 5);

        Camera.transform.position = new Vector3(pointX, pointY, pointZ);
    }

    void Rotate()
    {
        if (Input.GetMouseButton(1))
        {
            xRotate += -Input.GetAxis("Mouse Y") * RotateSpeed * Time.deltaTime;
            yRotate += Input.GetAxis("Mouse X") * RotateSpeed * Time.deltaTime;
            xRotate = Mathf.Clamp(xRotate, -60, 60);
            Camera.transform.eulerAngles = new Vector3(xRotate, yRotate, Camera.transform.eulerAngles.z);
        }
    }

    void UpdateRotation()
    {
        xRotate = Camera.transform.eulerAngles.x;
        yRotate = Camera.transform.eulerAngles.y;
    }
}
