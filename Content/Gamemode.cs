using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ProjectFramework.Content
{

    public abstract class Gamemode
    {
        private GamemodeInfo gamemodeInfo;
        private List<string> classes = new List<string>();


        public GamemodeInfo GamemodeInfo()
        {
            return gamemodeInfo;
        }
        public virtual void AttachGamemodeInfo(GamemodeInfo gmInfo)
        {
            gamemodeInfo = gmInfo;
        }
        public abstract void Init();

        public void Update(){
        }

        public void OnPlayerJoin()
        {

        }

    }

}
