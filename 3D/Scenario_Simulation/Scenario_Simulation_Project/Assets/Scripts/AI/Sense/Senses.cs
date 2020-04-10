using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Senses : MonoBehaviour
{
    public bool enableDebug = true;

    public Aspect.AspectTypes playerAspectName = Aspect.AspectTypes.PLAYER;
    public Aspect.AspectTypes playableFriendlyAspectName = Aspect.AspectTypes.PLAYABLE_FRIENDLY;
    public Aspect.AspectTypes playableEnemyAspectName = Aspect.AspectTypes.PLAYABLE_ENEMY;
    public Aspect.AspectTypes friendlyBotAspectName = Aspect.AspectTypes.FRIENDLY_BOT;
    public Aspect.AspectTypes enemyBotAspectName = Aspect.AspectTypes.ENEMY_BOT;

    public float detectionRate = 1.0f;

    protected float elapsedTime = 0.0f;

    protected virtual void Initialize()
    { }
    protected virtual void UpdateSense()
    { }

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0.0f;
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSense();
    }
}
