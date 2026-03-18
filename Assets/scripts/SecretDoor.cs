using UnityEngine;

public class SecretDoor : Door
{
    [SerializeField]
    string secretLevelName;
    void Start()
    {
        if (Manual.HasManual)
        {
            levelName = secretLevelName;
        }
    }
}
