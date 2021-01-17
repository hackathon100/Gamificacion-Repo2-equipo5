using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEquilateros : MonoBehaviour
{
    static public MainEquilateros Instance;

    public int switchCount;
    public GameObject winText;
    private int onCount = 0;
    public bool isWin;

    private void Awake()
    {
        Instance = this;
    }

    public void SwitchChange(int points)
    {
        onCount = onCount + points;
        if (onCount == switchCount)
        {
            winText.SetActive(true);
            isWin = true;
        }
    }
}
