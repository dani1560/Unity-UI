using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hoverButton : MonoBehaviour
{
    public Sprite sp1, sp2, sp3, ch1, ch2, ch3, ch4;
    Image flag, img1, img2, img3, img4;

    private void Start()
    {
        flag = gameObject.GetComponent<Image>();
        img1 = GameObject.Find("del").GetComponent<Image>();
        img2 = GameObject.Find("newFile").GetComponent<Image>();
        img3 = GameObject.Find("flip").GetComponent<Image>();
        img4 = GameObject.Find("drag").GetComponent<Image>();
    }
    public void mouseEnter()
    {
        if (flag.sprite == sp1)
        {
            flag.sprite = sp2;
        }
    }

    public void mouseExit()
    {
        if (flag.sprite == sp2)
        {
            flag.sprite = sp1;
        }
 
    }
    public void mouseClick()
    {
        if (flag.sprite == sp2)
        {
            if(gameObject.name == "del")
            {
                flag.sprite = sp3;
                img2.sprite = ch2;
                img3.sprite = ch3;
                img4.sprite = ch4;
            }
            if (gameObject.name == "newFile")
            {
                flag.sprite = sp3;
                img1.sprite = ch1;
                img3.sprite = ch3;
                img4.sprite = ch4;
            }
            if (gameObject.name == "flip")
            {
                flag.sprite = sp3;
                img2.sprite = ch2;
                img1.sprite = ch1;
                img4.sprite = ch4;
            }
            if (gameObject.name == "drag")
            {
                flag.sprite = sp3;
                img2.sprite = ch2;
                img3.sprite = ch3;
                img1.sprite = ch1;
            }
        }

    }

    public void mouseClick2()
    {
        if (flag.sprite == sp2)
        {
            if (gameObject.name == "del")
            {
                flag.sprite = sp3;
                img2.sprite = ch2;
                img3.sprite = ch3;
             
            }
            if (gameObject.name == "newFile")
            {
                flag.sprite = sp3;
                img1.sprite = ch1;
                img3.sprite = ch3;
            
            }
            if (gameObject.name == "flip")
            {
                flag.sprite = sp3;
                img2.sprite = ch2;
                img1.sprite = ch1;
           
            }
          
        }

    }


    public void folderClick()
    {
        globalVariable.forward = true;
        SceneManager.LoadScene("Folder");
    }
}
