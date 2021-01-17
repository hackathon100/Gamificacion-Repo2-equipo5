using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;

public class ChangeSkin : MonoBehaviour
{
    // Start is called before the first frame update
    public static string playerName;
    public static string playerSkin;
    User user = new User(playerName, playerSkin);
    private void updateData(){
        playerSkin = user.userSkin;
        ShowSprite();
    }
    private void getData(){
        RestClient.Get<User>("https://hackathon-equipo5-default-rtdb.firebaseio.com/.json").Then(response => {
            user = response;
            updateData();
        });
    }
    void Start()
    {
        playerName = "Prueba";
        getData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ShowSprite(){       
        int index = int.Parse(user.userSkin);
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++){
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;

            child.gameObject.SetActive(shouldShow);
        }
    }
}
