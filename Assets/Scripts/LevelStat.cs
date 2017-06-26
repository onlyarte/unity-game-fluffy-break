using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelStat
{
    public bool passed = false;
    public int deaths = 0;
    public int bestDeaths = 0;
    public int time = 0;
    public int bestTime = 0;
}