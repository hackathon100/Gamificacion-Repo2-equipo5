using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Proyecto26;
using System;

public class CharacterCreation : MonoBehaviour
{
    public SpriteRenderer spriteCompleto;
    public List<Sprite> options = new List<Sprite>();
    private int currentOption = 0;
    public static string playerName = "Prueba";
    public static string playerSkin;

    void Start()
    {
        
    }

    public void NextOption()
    {
        currentOption++;
        if(currentOption >= options.Count)
        {
            currentOption = 0;
        }
        spriteCompleto.sprite = options[currentOption];
    }

    public void PreviuosOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1;
        }
        spriteCompleto.sprite = options[currentOption];
    }

    IEnumerator waiter()
    {
        
        playerSkin = currentOption.ToString();
        User user = new User(playerName, playerSkin);
        RestClient.Put("https://hackathon-equipo5-default-rtdb.firebaseio.com/.json", user);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("MapaSalaClases");
        
    }


    public void loadScene()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
