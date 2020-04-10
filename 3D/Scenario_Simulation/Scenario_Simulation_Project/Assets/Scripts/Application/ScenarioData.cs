using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ScenarioData
{
    // Basic data elements that will be saved and then reloaded up.
    
    public int activeScenario;

    public int playerHealth;
    //public int playableFriendlyHealth;
    //public int playableEnemyHealth;

    public float[] playerPosition;
    //public float[] playableFriendlyPosition;
    //public float[] playableEnemyPosition;

    public int friendlyBotHealth;
    public int enemyBotHealth;

    public float[] friendlyBotPosition;
    public float[] enemyBotPosition;

    public ScenarioData(Scenario scenario)
    {
        activeScenario = scenario.currentScenario;

        playerHealth = scenario.player.currentHealth;

        playerPosition = new float[3];
        playerPosition[0] = scenario.player.transform.position.x;
        playerPosition[1] = scenario.player.transform.position.y;
        playerPosition[2] = scenario.player.transform.position.z;

        //playableFriendlyPosition = new float[3];
        //playableFriendlyPosition[0] = scenario.playableFriendly.transform.position.x;
        //playableFriendlyPosition[1] = scenario.playableFriendly.transform.position.y;
        //playableFriendlyPosition[2] = scenario.playableFriendly.transform.position.z;

        //playableEnemyPosition = new float[3];
        //playableEnemyPosition[0] = scenario.playableEnemy.transform.position.x;
        //playableEnemyPosition[1] = scenario.playableEnemy.transform.position.y;
        //playableEnemyPosition[2] = scenario.playableEnemy.transform.position.z;

        friendlyBotPosition = new float[3];
        friendlyBotPosition[0] = scenario.friendlyBot.transform.position.x;
        friendlyBotPosition[1] = scenario.friendlyBot.transform.position.y;
        friendlyBotPosition[2] = scenario.friendlyBot.transform.position.z;

        enemyBotPosition = new float[3];
        enemyBotPosition[0] = scenario.enemyBot.transform.position.x;
        enemyBotPosition[1] = scenario.enemyBot.transform.position.y;
        enemyBotPosition[2] = scenario.enemyBot.transform.position.z;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
