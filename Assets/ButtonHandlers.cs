using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandlers : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private TMP_Dropdown dropdown;
    [SerializeField] private Button btn;
    [SerializeField] private Animator fade;
    [SerializeField] private TextMeshProUGUI currentLoc;

    public void MoveButton() {
        StartCoroutine(Fade(dropdown.options[dropdown.value].text));
    }

    public IEnumerator Fade(string destination) {
        fade.SetTrigger("out");
        fade.ResetTrigger("in");

        yield return new WaitForSeconds(0.5f);

        fade.SetTrigger("in");
        fade.ResetTrigger("out");

        GameObject tp = GameObject.Find(destination);
        player.transform.position = tp.transform.position;
        currentLoc.text = destination;
    }
}
