using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleObject : MonoBehaviour
{
    public ObstacleType obstacleType;
    public int resourceAmount = 10;

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name);

        bool usedResources = false;
        switch (obstacleType)
        {
            case ObstacleType.Wood:
                usedResources= ResourceManager.Instance.AddWood(resourceAmount);
                break;
            case ObstacleType.Rock:
                usedResources =  ResourceManager.Instance.AddStone(resourceAmount);
                break;
            default:
                break;
        }

        if (usedResources)
        {
            Destroy(gameObject);
        }
        else
            Debug.Log("not destroyed");

    }

    public enum ObstacleType{
        Wood,
        Rock
    }
}
