using System.Collections.Generic;
using UnityEngine;

public class globalVariable : MonoBehaviour
{
    public static int globalValue;
    public static List<GameObject> folders = new List<GameObject>();
    public static bool backward;
    public static bool forward;

    void Start()
    {
        backward = false;
        forward = false;
    }

}
