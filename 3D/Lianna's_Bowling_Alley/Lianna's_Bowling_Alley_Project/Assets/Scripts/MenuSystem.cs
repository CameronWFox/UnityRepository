using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuSystem : MonoBehaviour
{
    public AudioMixer audio_mixer;

    public Dropdown resolution_dropdown; //Dropdown variable for the resolutions dropdown in the settings menu.

    Resolution[] resolutions; //Array of all the resolution options that are for the system that is running the application.

    // Start is called before the first frame update
    void Start()
    {
        #region Application_Resolution_Work
        resolutions = Screen.resolutions; // Gathers all the resolution options for the system that is currently running the application.

        resolution_dropdown.ClearOptions(); //Clears that resolution options that were previously stored in the dropdown.

        List<string> resolution_options = new List<string>(); //List of all the resolution options on the current system as string elements.

        int current_resolution_index = 0; //Resolution index for going through the resolution list of strings.

        for (int i = 0; i < resolutions.Length; i++)
        {
            string resolution_option = resolutions[i].width + " x " + resolutions[i].height;
            resolution_options.Add(resolution_option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                current_resolution_index = i;
            }
        }

        resolution_dropdown.AddOptions(resolution_options);
        resolution_dropdown.value = current_resolution_index;
        resolution_dropdown.RefreshShownValue();
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
        Debug.Log("You have QUIT the application...Bowling Alley Shutting Down...");
        Application.Quit();
    }

    // Setting the volume in the settings menu.
    public void SetVolume(float volume)
    {
        audio_mixer.SetFloat("Volume", volume);
    }

    // Setting the quality level for the application.
    public void SetQuality(int quality_index)
    {
        QualitySettings.SetQualityLevel(quality_index);
    }

    // Set if the user wants to run the application in fullscreen or window mode.
    public void SetFullscreen(bool is_fullscreen)
    {
        Screen.fullScreen = is_fullscreen;
    }

    // Setting the desired resolution.
    public void SetResolution(int resolution_index)
    {
        Resolution resolution = resolutions[resolution_index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
