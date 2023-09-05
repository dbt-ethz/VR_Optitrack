using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ControllerEvent : MonoBehaviour
{
    public InputActionReference roomLocYes = null;
    private Image image;

    private void Start()
    {
        image = GetComponent<Image>();
        if (image)
        {
            Debug.Log("found");
            Debug.Log(image.color);
        }
        else Debug.Log("nullll");
    }
    private void Awake()
    {
        roomLocYes.action.started += RoomLocYes;
    }
    private void OnDestroy()
    {
        roomLocYes.action.started -= RoomLocYes;
    }

    private void RoomLocYes(InputAction.CallbackContext context)
    {
        image.color = Color.blue;
    }
}
