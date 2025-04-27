using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private InputActionReference openMenu;

    // Start is called before the first frame update
    void Start()
    {
        openMenu.action.performed += ShowMenu;
        openMenu.action.canceled += HideMenu;
    }

    public void ShowMenu(InputAction.CallbackContext context) {
        menu.SetActive(true);
    }

    public void HideMenu(InputAction.CallbackContext context) {
        menu.SetActive(false);
    }
}
