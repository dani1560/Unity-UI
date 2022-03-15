using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject obj;

    private void Awake()
    {
        DontDestroyOnLoad(obj);
    }

}
