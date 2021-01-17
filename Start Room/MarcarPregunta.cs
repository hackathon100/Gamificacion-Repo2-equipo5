using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarcarPregunta : MonoBehaviour
{
    public GameObject select;
    public int pregunta;
    private const int respuestCorrecta = 3;
    public GameObject winText;
    public GameObject loseText;

    public bool isSelect;
    // Start is called before the first frame update
    void Start()
    {
        select.SetActive(isSelect);
        winText.SetActive(false);
        loseText.SetActive(false);
    }

    private void OnMouseUp()
    {
        isSelect = !isSelect;
        select.SetActive(isSelect);
        if (isSelect && pregunta == respuestCorrecta)
        {
            winText.SetActive(true);
        }
        else
        {
            loseText.SetActive(true);
        }
    }
}
