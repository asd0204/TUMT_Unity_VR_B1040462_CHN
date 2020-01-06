using UnityEngine;

public class TeleportInteratble : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "HeadCollider" && GameManager.haveKey)
        {
            Application.Quit();
           // string theString = "這是一段字串";
            //Debug.Log(theString);
        }
    }
}
