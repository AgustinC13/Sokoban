using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCondition : MonoBehaviour
{
    private void Update()
    {
        IsLevelComplete();
        if (IsLevelComplete())
        {
            SceneManager.LoadScene("Victoria");
        }
    }

    bool IsLevelComplete()
    {
        Box[] boxes = FindObjectsOfType<Box>();
        foreach (var box in boxes)
        {
            if (!box) return false;
        }
        return true;
    }

}