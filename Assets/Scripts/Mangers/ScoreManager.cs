﻿
/***********************************************************************************************************
 * Produced by App Advisory - http://app-advisory.com													   *
 * Facebook: https://facebook.com/appadvisory															   *
 * Contact us: https://appadvisory.zendesk.com/hc/en-us/requests/new									   *
 * App Advisory Unity Asset Store catalog: http://u3d.as/9cs											   *
 * Developed by Gilbert Anthony Barouch - https://www.linkedin.com/in/ganbarouch                           *
 ***********************************************************************************************************/




using UnityEngine;
using System.Collections;

namespace AppAdvisory.MathGame
{
    public class ScoreManager
    {
        public static void SaveScore(int lastScore, int level)
        {
            PlayerPrefs.SetInt("LAST_SCORE", lastScore);
            PlayerPrefs.SetInt("LAST_LEVEL", level);

            int best = GetBestScore();

            if (lastScore > best)
                PlayerPrefs.SetInt("LAST_SCORE_IS_NEW_BEST", 1);
            else
                PlayerPrefs.SetInt("LAST_SCORE_IS_NEW_BEST", 0);


            if (lastScore > best)
            {
                PlayerPrefs.SetInt("BEST_SCORE", lastScore);
                TournamentManager.Instance.StoreScore(lastScore, level);
            }

            PlayerPrefs.Save();
        }

        public static void ResetScore()
        {
            PlayerPrefs.SetInt("LAST_SCORE", 0);
            PlayerPrefs.SetInt("LAST_LEVEL", 0);
            PlayerPrefs.SetInt("BEST_SCORE", 0);
            PlayerPrefs.Save();
        }

        public static int GetLastScore()
        {
            return PlayerPrefs.GetInt("LAST_SCORE");
        }


        public static int GetLastLevel()
        {
            return PlayerPrefs.GetInt("LAST_LEVEL");
        }

        public static bool GetLastScoreIsBest()
        {
            int temp = PlayerPrefs.GetInt("LAST_SCORE_IS_NEW_BEST");
            if (temp == 1)
            {
                return true;
            }
            return false;
        }

        public static int GetBestScore()
        {
            return PlayerPrefs.GetInt("BEST_SCORE");
        }
    }
}