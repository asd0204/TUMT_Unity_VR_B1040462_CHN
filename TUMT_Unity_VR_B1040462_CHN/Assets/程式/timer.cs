using UnityEngine;

public class timer : MonoBehaviour {

    [Header("目前時間")]
    public float currentTime;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        currentTime += Time.fixedDeltaTime;
    }
}
