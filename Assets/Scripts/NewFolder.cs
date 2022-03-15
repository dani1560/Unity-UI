using UnityEngine;
using UnityEngine.UI;

public class NewFolder : MonoBehaviour
{
    public GameObject folderObj;
    GameObject canvasParent;
    static float scalingX, scalingY;

    bool status;
    int listIndexes;

    Text folderName;

    void Start()
    {
        canvasParent = GameObject.Find("foldersPanel");
        folderName = GameObject.Find("folderName").GetComponent<Text>();
        scalingX = 40f;
        scalingY = -70f;
        folderName.text = "Folder";
        status = true;


        if (globalVariable.backward)
        {
            var lngth = globalVariable.folders.Count;
            globalVariable.folders.Clear();

            for (int i = 0; i < lngth; i++)
            {
                addFiles();
            }

            globalVariable.backward = false;
        }
    }

    public void addFiles()
    {
        if (listIndexes < 60)
        {
            var a = Instantiate(folderObj, new Vector2(scalingX, scalingY), Quaternion.identity);
            a.transform.SetParent(canvasParent.transform, false);
            a.transform.localScale = new Vector3(1, 1, 1);
            globalVariable.folders.Add(a);
            listIndexes++;
            folderName.text = "Folder " + listIndexes;
            status = true;
            scalingX += 60f;
            

            if (scalingX == 760 && scalingY == -70)
            {
                scalingX = 40;
                scalingY = -140;
            }
            else if (scalingX == 760 && scalingY == -140)
            {
                scalingX = 40;
                scalingY = -210;
            }
            else if (scalingX == 760 && scalingY == -210)
            {
                scalingX = 40;
                scalingY = -280;
            }
            else if (scalingX == 760 && scalingY == -280)
            {
                scalingX = 40;
                scalingY = -340;
            }

        }

    }

    public void deletingFiles()
    {
        if (status == true)
        {
            if (listIndexes > 0)
            {
                listIndexes--;
                Destroy(globalVariable.folders[listIndexes]);
                globalVariable.folders.RemoveAt(listIndexes);
                scalingX -= 60;
                Debug.Log(scalingX + "-:-" + scalingY);

                if (scalingX == -20 && scalingY == -340)
                {
                    scalingX = 700;
                    scalingY = -280;
                }
                else if (scalingX == -20 && scalingY == -280)
                {
                    scalingX = 700;
                    scalingY = -210;
                }
                else if (scalingX == -20 && scalingY == -210)
                {
                    scalingX = 700;
                    scalingY = -140;
                }
                else if (scalingX == -20 && scalingY == -140)
                {
                    scalingX = 700;
                    scalingY = -70;
                }

            }
            else
            {
                status = false;
                Debug.Log("Finished");
            }
        }
    }

}
