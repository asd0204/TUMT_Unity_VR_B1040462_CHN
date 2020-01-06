using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool haveKey;
    public GameObject asd;
    public GameObject qwe;

    // 公開並且參數零或一個
    public void ThrowPickUp()
    {
        print("撿起物件");
         
        qwe.SetActive(true);
    }

    public void ThrowDetach(GameObject obj)
    {
        print("放開物件");
        haveKey = true;
        Destroy(obj);
        asd.SetActive(true);
    }

    public void ThrowHeld()
    {
        print("拿著物件");
    }
}
