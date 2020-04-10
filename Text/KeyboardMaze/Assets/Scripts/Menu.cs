using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    GameController gc;
    TextInput ti;

    public Text MainMenuText;
    public Text ControlsMenuText;
    public Text SettingsMenuText;

    //public InputField inputField;

    private void Awake()
    {
        gc = GetComponent<GameController>(); //Reference to GameController Script
        ti = GetComponent<TextInput>();
        //inputField.onEndEdit.AddListener(ti.AcceptStringInput); //Listens for when the user is finished with current keyboard input
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Testing if the user enters specific key words to move through different parts of the menu.
        if (Input.inputString.ToLower().Equals("start"))
        {
            gc.LogStringInputWithReturn("start");
            StartApplication();
        }
        else if (Input.inputString.ToLower().Equals("settings") && MainMenuText.isActiveAndEnabled.Equals(true))
        {
            gc.LogStringInputWithReturn("settings");
            MainMenuText.isActiveAndEnabled.Equals(false);
            SettingsMenuText.isActiveAndEnabled.Equals(true);
        }
        else if (Input.inputString.ToLower().Equals("controls") && MainMenuText.isActiveAndEnabled.Equals(true))
        {
            gc.LogStringInputWithReturn("controls");
            MainMenuText.isActiveAndEnabled.Equals(false);
            ControlsMenuText.isActiveAndEnabled.Equals(true);
        }
        else if (Input.inputString.ToLower().Equals("back") && MainMenuText.isActiveAndEnabled.Equals(false) && SettingsMenuText.isActiveAndEnabled.Equals(true))
        {
            gc.LogStringInputWithReturn("back");
            MainMenuText.isActiveAndEnabled.Equals(true);
            SettingsMenuText.isActiveAndEnabled.Equals(false);
        }
        else if (Input.inputString.ToLower().Equals("back") && MainMenuText.isActiveAndEnabled.Equals(false) && ControlsMenuText.isActiveAndEnabled.Equals(true))
        {
            gc.LogStringInputWithReturn("back");
            MainMenuText.isActiveAndEnabled.Equals(true);
            ControlsMenuText.isActiveAndEnabled.Equals(false);
        }
        else if (Input.inputString.ToLower().Equals("quit") && MainMenuText.isActiveAndEnabled.Equals(true))
        {
            gc.LogStringInputWithReturn("quit");
            QuitApplication();
        }
    }

    public void StartApplication()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
    
}
