using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginPage : MonoBehaviour
{
    InputField pass;
    Text required;
    Dropdown dropList;
    string selectedValue;

    void Start()
    {
        pass = GameObject.Find("InputPassword").GetComponent<InputField>();
        required = GameObject.Find("requiredPass").GetComponent<Text>();
        dropList = GameObject.Find("Dropdown").GetComponent<Dropdown>();
    }

    public void OnReset()
    {
        pass.text = "";     
    }

    public void OnLogin()
    {
        selectedValue = dropList.options[dropList.value].text;

        if (pass.text == "123" && selectedValue == "Trainer")
        {
            SceneManager.LoadScene("Panel");
        }
        else
        {
            required.text = "wrong password";
        }
    }

    public void OnClick()
    {
        required.text = "";
    }

    public void OnExit()
    {
        Application.Quit();
    }
}
