using System;
using Player;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        private void Awake()
        {
            Playerscript2 player = Playerscript2.GetInstance;
        }

    }
}
