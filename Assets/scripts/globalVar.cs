using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class globalVar : MonoBehaviour
{   

    // private variable score & highScore
    [SerializeField] static int score;

    

    [SerializeField] static int highScore = 0;
    [SerializeField] static string HsName = "";

    private static int coin = 0;
    public int enemyScore = 1;
    public int bossEnemyScore = 10;

    public static int currentTheme = 0;

    public static int lastScore = 0;

    static int theme1 = 0;
    static int theme2 = 0;

    static int speedLevel = 1;

    public static bool gameloss = false;

    GameObject rmenu;

    public static bool RMenu = false;  

    
    private void Awake() {
        rmenu = gameObject;
    }
    //public functions 
    private void Start() {
        
        
        highScore = loadHighScore();
        HsName = loadHighScorerName();
        coin = loadCoin();
        theme1 = loadTheme1();
        theme2 = loadTheme2();
        speedLevel = loadSpeedLevel();

        
    }

    private void Update() {
        if(speedLevel == 0)
        {
            setSpeedlevel(1);
        }
    }
    public void addScore(int val){

        score = score + val;

    }

    public void subScore(int val)
    {
        score = score - val;
    }

    public int getScore()
    {
        return score;
    }

    public void resetScore()
    {
        score = 0;
    }

    public void gameOver()
    {
        print("gameover");
        if(reviveMenu.reviveT < 2)
        {
            RMenu = true;
            Time.timeScale = 0f;
            
        }
        else{
            
            reviveMenu.reviveT = 0;
            RMenu = false;
            if(score>highScore)
            {

            highScore = score;
            lastScore = score;
            coin = coin + score;
            saveCoin();
            
            saveHighScore();
            saveThemes();
            saveSpeedLevel();
            
            resetScore();
            
            SceneManager.LoadScene("highScore");

            }
            else{

            coin = coin + score;
            lastScore = score;
            saveCoin();
            
            saveHighScore();
            saveThemes();
            saveSpeedLevel();
            gameloss = true;
            resetScore();

                if(SceneManager.GetActiveScene().name == "newGame")
                {
                    SceneManager.LoadScene("dashboard");
                }
                else
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            
            }

        }

        
        

    }

    public void setHighScorerName(string name)
    {
        HsName = name;
        saveHighScorerName();
    }

    public int getHighScore()
    {
        return highScore;
    }

    public int GetCoin()
    {
        return coin;
    }

    public void subCoin(int c)
    {
        coin = coin - c;
        saveCoin();
    }
    public string getHighScorerName()
    {
        return HsName;
    }

    public int getTheme1()
    {
        return theme1;
    }

    public int getTheme2()
    {
        return theme2;
    }

    public void setTheme1(int n)
    {
        theme1 = n;
        saveThemes();
    }

    public void setTheme2(int n)
    {
        theme2 = n;
        saveThemes();
    }


    public void saveHighScore()
    {
        PlayerPrefs.SetInt("hScore",highScore);
        PlayerPrefs.Save();
    }

    public int loadHighScore()
    {
        int Hs = PlayerPrefs.GetInt("hScore");
        return Hs;
    }

    public void saveHighScorerName()
    {
        PlayerPrefs.SetString("HsName",HsName);
        PlayerPrefs.Save();
    }

    public string loadHighScorerName()
    {
        string HsN = PlayerPrefs.GetString("HsName");
        return HsN;
    }

    public void saveCoin()
    {
        PlayerPrefs.SetInt("coin",coin);
        PlayerPrefs.Save();
    }

    public int loadCoin()
    {
        int Hs = PlayerPrefs.GetInt("coin");
        return Hs;
    }

    public void saveThemes()
    {
        PlayerPrefs.SetInt("theme1",theme1);
         PlayerPrefs.SetInt("theme2",theme2);
        PlayerPrefs.Save();
    }

    public int loadTheme1()
    {
        int Hs = PlayerPrefs.GetInt("theme1");
        
        return Hs;
    }
    public int loadTheme2()
    {
        
        int Hs1 = PlayerPrefs.GetInt("theme2");
        return Hs1;
    }

    public int getCurrentTheme()
    {
        return currentTheme;
    }

     public void saveSpeedLevel()
    {
        PlayerPrefs.SetInt("sl",speedLevel);
        PlayerPrefs.Save();
    }

    public int loadSpeedLevel()
    {
        int Hs = PlayerPrefs.GetInt("sl");
        return Hs;
    }

    public int getSpeedLevel()
    {
        return speedLevel;
    }

    public void setSpeedlevel(int n)
    {
        speedLevel = n;
        saveSpeedLevel();
    }
}
