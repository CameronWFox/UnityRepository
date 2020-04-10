using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown; //Dropdown variable for the resolutions dropdown in the settings menu.

    Resolution[] resolutions; //Array of all the resolution options that are for the system that is running the application.

    // Start is called before the first frame update
    void Start()
    {
        #region Application_Resolution_Work
        resolutions = Screen.resolutions; // Gathers all the resolution options for the system that is currently running the application.

        resolutionDropdown.ClearOptions(); //Clears that resolution options that were previously stored in the dropdown.

        List<string> resolution_options = new List<string>(); //List of all the resolution options on the current system as string elements.

        int currentResolutionIndex = 0; //Resolution index for going through the resolution list of strings.

        for (int i = 0; i < resolutions.Length; i++)
        {
            string resolution_option = resolutions[i].width + " x " + resolutions[i].height;
            resolution_options.Add(resolution_option);

            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(resolution_options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Starts up the application into a choosen scenario.
    public void StartApplication()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // Later will set up to when the application will start 
        // and based in the choosen scenario.
    }

    // Quits the application and closes everything out.
    public void QuitApplication()
    {
        Debug.Log("You have QUIT the application...Scenario Simulation Shutting Down...");
        Application.Quit();
    }

    // Setting the volume in the settings menu.
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    // Setting Option for the quality level for the application.
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // Setting Option if the user wants to run the application in fullscreen or window mode.
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    // Setting Option for the desired resolution.
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
