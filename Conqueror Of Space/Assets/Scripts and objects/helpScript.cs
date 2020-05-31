using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class helpScript : MonoBehaviour
{
    public GameObject aboutGame;
    public GameObject boosts;
    public GameObject enemies;
    public GameObject bosses;
    public GameObject scoreSystem;
    public GameObject recordsSystem;
    public GameObject difficulty;
    public GameObject options;
    public GameObject help;

    public void toOptions()
    {
        options.SetActive(true);
        help.SetActive(false);
    }
    public void aboutGameText()
    {
        aboutGame.SetActive(true);
        boosts.SetActive(false);
        enemies.SetActive(false);
        bosses.SetActive(false);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(false);
        difficulty.SetActive(false); 
        options.SetActive(false);
    }
    public void boostsText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(true);
        enemies.SetActive(false);
        bosses.SetActive(false);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(false);
        difficulty.SetActive(false);
        options.SetActive(false);
    }
    public void enemiesText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(false);
        enemies.SetActive(true);
        bosses.SetActive(false);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(false);
        difficulty.SetActive(false);
        options.SetActive(false);
    }
    public void bossesText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(false);
        enemies.SetActive(false);
        bosses.SetActive(true);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(false);
        difficulty.SetActive(false);
        options.SetActive(false);
    }
    public void scoreSystemText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(false);
        enemies.SetActive(false);
        bosses.SetActive(false);
        scoreSystem.SetActive(true);
        recordsSystem.SetActive(false);
        difficulty.SetActive(false);
        options.SetActive(false);
    }
    public void recordsSystemText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(false);
        enemies.SetActive(false);
        bosses.SetActive(false);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(true);
        difficulty.SetActive(false);
        options.SetActive(false);
    }
    public void difficultyText()
    {
        aboutGame.SetActive(false);
        boosts.SetActive(false);
        enemies.SetActive(false);
        bosses.SetActive(false);
        scoreSystem.SetActive(false);
        recordsSystem.SetActive(false);
        difficulty.SetActive(true);
        options.SetActive(false);
    }
}