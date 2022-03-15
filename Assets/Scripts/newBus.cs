using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class newBus: MonoBehaviour
{
    public GameObject folderObj;
    GameObject canvasParent;
    float scalingX;
    float autoIncrement;
    bool status;
    int listIndexes = 0;

    List<GameObject> folders = new List<GameObject>();

    void Start()
    {
        canvasParent = GameObject.Find("ContentPanel");
        autoIncrement = canvasParent.GetComponent<RectTransform>().offsetMax.x;
        scalingX = 58f;
        status = true;

       /* if (globalVariable.forward)
        {
            var lngth = globalVariable.globalValue;
            globalVariable.globalValue = 0;

            for (int i = 0; i < lngth; i++)
            {
                addFiles();
            }

            globalVariable.forward = false;
        }*/
    }

    public void addFiles()
    {
        autoSize();

        if (listIndexes < 55)
        {

            listIndexes++;
            status = true;

            var a = Instantiate(folderObj, new Vector2(scalingX, 4f), Quaternion.identity);
            a.transform.SetParent(canvasParent.transform, false);
            a.transform.localScale = new Vector3(1, 1, 1);
            folders.Add(a);
          
            scalingX += 130f;

            //globalVariable.globalValue++;
            
        }
        
    }

    public void deletingFiles()
    {
        //Debug.Log(File.ReadAllText(Application.dataPath + "/SAVE.txt"));

        if (status == true)
        { 
            if (listIndexes > 0)
            {
                listIndexes--;
                Destroy(folders[listIndexes]);
                folders.RemoveAt(listIndexes);
                scalingX -= 130f;

                autoIncrement -= 100f;
                canvasParent.GetComponent<RectTransform>().offsetMax = new Vector2(autoIncrement, default);
                // globalVariable.globalValue--;

            }
            else
            {
                status = false;
            }
        }
    }

    public void autoSize()
    {
        

        //File.WriteAllText(Application.dataPath + "/SAVE.txt", "kaam duniya k logon");
        //Debug.Log(canvasParent.GetComponent<RectTransform>().rect.height);

        if (listIndexes > 5)
        {
            autoIncrement += 100f;
            canvasParent.GetComponent<RectTransform>().offsetMax = new Vector2(autoIncrement, default);
        }
      
    }
}
