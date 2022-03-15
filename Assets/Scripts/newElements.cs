using System.Collections.Generic;
using UnityEngine;

public class newElements : MonoBehaviour
{
    public GameObject folderObj;
    GameObject canvasParent;
    float scalingY;
    bool status;
    int listIndexes = 0;

    List<GameObject> folders = new List<GameObject>();

    void Start()
    {
        canvasParent = GameObject.Find("InnerPanel");

        scalingY = 626f;
        status = true;

        if (globalVariable.forward)
        {
            var lngth = globalVariable.globalValue;
            globalVariable.globalValue = 0;

            for (int i = 0; i < lngth; i++)
            {
                addFiles();
            }

            globalVariable.forward = false;
        }
    }

    public void addFiles()
    {

        if (listIndexes == 0)
        {
            scalingY = 626f;
        }

        if (listIndexes < 55)
        {

            listIndexes++;
            status = true;

            var a = Instantiate(folderObj, new Vector2(0f, scalingY), Quaternion.identity);
            a.transform.SetParent(canvasParent.transform, false);
            a.transform.localScale = new Vector3(1, 1, 1);
            folders.Add(a);
          
            scalingY += -42f;

            globalVariable.globalValue++;
            
        }
        
    }

    public void deletingFiles()
    {
        

        if (status == true)
        { 
            if (listIndexes > 0)
            {
                listIndexes--;
                Destroy(folders[listIndexes]);
                folders.RemoveAt(listIndexes);
                scalingY -= -42f;

                globalVariable.globalValue--;
               
            }
            else
            {
                status = false;
            }
        }
    }
}
