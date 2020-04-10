using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadSystem
{
    public static void Save(Scenario scenario)
    {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string filePath = Application.persistentDataPath + "/Save.binary";
        FileStream fileStream = new FileStream(filePath, FileMode.Create);

        ScenarioData scenarioData = new ScenarioData(scenario);

        binaryFormatter.Serialize(fileStream, scenarioData);
        binaryFormatter.Serialize(fileStream, scenarioData);
        binaryFormatter.Serialize(fileStream, scenarioData);
        fileStream.Close();
    }

    public static ScenarioData Load()
    {
        string filePath = Application.persistentDataPath + "/Save.binary";
        if (File.Exists(filePath))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(filePath, FileMode.Open);

            ScenarioData scenarioData = binaryFormatter.Deserialize(fileStream) as ScenarioData;
            fileStream.Close();

            return scenarioData;
        }
        else
        {
            Debug.LogError("SaveFile Not Found In " + filePath);
            return null;
        }
    }
}
