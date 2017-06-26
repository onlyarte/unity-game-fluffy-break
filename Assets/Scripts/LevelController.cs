using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController
{

    int level = 0;
    LevelStat currentStat = null;

    public LevelController(int currentLevel)
    {
        level = currentLevel;

        string input = PlayerPrefs.GetString("stats" + level, "");
        currentStat = JsonUtility.FromJson<LevelStat>(input);
        if (currentStat == null || currentStat.passed == false)
            currentStat = new LevelStat();
        currentStat.deaths = 0;
        currentStat.time = 0;
    }

    public void addDeath()
    {
        currentStat.deaths++;
    }

    public int getDeaths()
    {
        return currentStat.deaths;
    }

    public int getBestDeaths()
    {
        return currentStat.bestDeaths;
    }

    public void setTime()
    {
        currentStat.time = (int)Time.timeSinceLevelLoad;
    }

    public int getTime()
    {
        return currentStat.time;
    }

    public float getBestTime()
    {
        return currentStat.bestTime;
    }

    public void saveOnWin()
    {
        setTime();
        currentStat.passed = true;
        if (currentStat.deaths < currentStat.bestDeaths || currentStat.bestDeaths == 0)
            currentStat.bestDeaths = currentStat.deaths;
        if (currentStat.time < currentStat.bestTime || currentStat.bestTime == 0)
            currentStat.bestTime = currentStat.time;

        Debug.Log(currentStat.time);

        string output = JsonUtility.ToJson(currentStat);
        PlayerPrefs.SetString("stats" + level, output);
    }

}
