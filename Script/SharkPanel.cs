using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkPanel : MonoBehaviour
{
 public GameObject Panel;

 public void panelonOff()
    {
        Panel.SetActive(!Panel.activeSelf);
    }
}
