using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongSwitch : MonoBehaviour
{
    // Update is called once per frame
    private void OnMouseUp()
    {
        SceneManager.LoadScene("MiniJuegoEquilateros");
    }
}
