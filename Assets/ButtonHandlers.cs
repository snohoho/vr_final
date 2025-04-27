using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandlers : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private Button btn;
    private string destination;

    void Update()
    {
        
    }

    public void MoveButton() {
        destination = dropdown.options[dropdown.value].text;

        GameObject tp = GameObject.Find(destination);
        player.transform.position = tp.transform.position;
    }
}
