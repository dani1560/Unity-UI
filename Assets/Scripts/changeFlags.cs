using UnityEngine;
using UnityEngine.UI;

public class changeFlags : MonoBehaviour
{
    public Sprite sp1, sp2;
    Image flag;

    private void Start()
    {
        flag = gameObject.GetComponent<Image>();
    }

    public void changeFlag()
    {
        if (flag.sprite == sp1)
        {
            flag.sprite = sp2;
        }
        else if (flag.sprite == sp2)
        {
            flag.sprite = sp1;
        }
    }
}
