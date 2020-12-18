using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControls : MonoBehaviour
{
    public static void Kill(Player player)
    {
        Destroy(player.gameObject);
        
    }


}
