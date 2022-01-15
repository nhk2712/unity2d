using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public SpriteRenderer iconM;
    public SpriteRenderer iconS;
    Color cloff = new Color(1,1,1,0.5f);
    Color clon = new Color(1,1,1,1);

    public void music(){
        if (settings.getMsc()==1){
            settings.offMsc();
        }
        else if (settings.getMsc()==0){
            settings.onMsc();
        }
    }

    public void sound(){
        if (settings.getSfx()==1){
            settings.offSfx();
        }
        else if (settings.getSfx()==0){
            settings.onSfx();
        }
    }

    void Update(){
        if (settings.getMsc()==1){
            iconM.color = clon;
        }
        else if (settings.getMsc()==0){
            iconM.color = cloff;
        }

        if (settings.getSfx()==1){
            iconS.color = clon;
        }
        else if (settings.getSfx()==0){
            iconS.color = cloff;
        }
    }
}
