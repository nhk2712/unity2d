using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class settings
{
    private static int msc = 1;
    private static int sfx = 1;

    public static void onMsc(){
        msc=1;
    }

    public static void offMsc(){
        msc=0;
    }

    public static void onSfx(){
        sfx=1;
    }

    public static void offSfx(){
        sfx=0;
    }

    public static int getMsc(){
        return msc;
    }

    public static int getSfx(){
        return sfx;
    }
}
