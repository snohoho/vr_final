using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DropdownUpdater : MonoBehaviour
{
    [SerializeField] private TMP_Dropdown ioDrop;
    [SerializeField] private TMP_Dropdown udDrop;
    [SerializeField] private TMP_Dropdown finalDropdown;
    private string io;
    private string ud;
    private List<string> indoorsDown = new List<string> {"SGA","NSBE","TEA","SHPE",
                                                        "Engineering Lab","PLS Tutoring","Chess Club","Robotics Club","Soccer Club","Makerspace",
                                                        "Chemistry Lab","Ablaze","Hallway","Cybersecurity Club", "Tabletop Club"};
    private List<string> indoorsUp = new List<string> {"Library",
                                                        "Student Space",
                                                        "ASCE"};
    private List<string> outdoorsDown = new List<string> {"Nerf Club",
                                                            "ASME",
                                                            "Longboarding Club"};
    private List<string> outdoorsUp = new List<string> {"Flight Club",
                                                        "Force Institute"};

    void Start()
    {
        RefreshList();
    }

    public void RefreshList() {
        io = ioDrop.options[ioDrop.value].text;
        ud = udDrop.options[udDrop.value].text;

        finalDropdown.options.Clear();
        //indoors
        if(io == "Inside") {
            //downstairs
            if(ud == "Downstairs") {
                foreach(string d in indoorsDown) {
                    finalDropdown.options.Add(new TMP_Dropdown.OptionData() {text=d});
                }
            }
            //upstairs
            if(ud == "Upstairs") {
                foreach(string d in indoorsUp) {
                    finalDropdown.options.Add(new TMP_Dropdown.OptionData() {text=d});
                }
            }
        }
        //outdoors
        if(io == "Outside") {
            //downstairs
            if(ud == "Downstairs") {
                foreach(string d in outdoorsDown) {
                    finalDropdown.options.Add(new TMP_Dropdown.OptionData() {text=d});
                }
            }
            //upstairs
            if(ud == "Upstairs") {
                foreach(string d in outdoorsUp) {
                    finalDropdown.options.Add(new TMP_Dropdown.OptionData() {text=d});
                }
            }
        }
        finalDropdown.RefreshShownValue();
    }
}
