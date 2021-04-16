using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class GameSettings
{
    private static string name;
    private static Sprite image;
    private static int social;
    private static int academic;

    public static string Name
    {
        get 
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public static Sprite Image
    {
        get
        {
            return image;
        }
        set
        {
            image = value;
        }
    }

    public static int SocialPoints
    {
        get 
        {
            return social;
        }
        set
        {
            social = value;
        }
    }


    public static int AcademicPoints
    {
        get
        {
            return academic;
        }
        set
        {
            academic = value;
        }
    }

}
