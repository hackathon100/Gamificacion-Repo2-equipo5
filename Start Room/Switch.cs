using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject on;
    public GameObject select;
    public GameObject off;

    public bool isOn;
    public bool isSelect;

    // Start is called before the first frame update

    void Start()
    {
        on.SetActive(isOn);
        select.SetActive(isSelect);
        off.SetActive(!isOn);
        if(isOn)
        {
            MainEquilateros.Instance.SwitchChange(1);
        }
    }
    private void OnMouseUp()
    {
        isSelect = !isSelect;
        isOn = !isOn;
        on.SetActive(isOn);
        select.SetActive(isSelect);
        off.SetActive(!isOn);
        if (isOn)
        {
            MainEquilateros.Instance.SwitchChange(1);
        }
        else
        {
            MainEquilateros.Instance.SwitchChange(-1);
        }    
    }

}
