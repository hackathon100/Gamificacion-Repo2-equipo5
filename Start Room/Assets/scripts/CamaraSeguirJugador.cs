using UnityEngine;

public class CamaraSeguirJugador : MonoBehaviour {

    [Header("Component")]
    public Transform target;
    private Transform activeObject;

    private void Update()
    {
        GetChildPosition();
        // transform.position = new Vector3(target.position.x, target.position.y, -10);
        transform.position = new Vector3(activeObject.position.x, activeObject.position.y, -10);
    }
    private void GetChildPosition(){
        for (int i = 0; i < target.transform.childCount; i++){
            if (target.transform.GetChild(i).gameObject.activeSelf == true){
                activeObject = target.transform.GetChild(i);
            }
        }
    }
}