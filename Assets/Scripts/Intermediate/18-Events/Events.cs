using System;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void Start()
    {
        Player player = new Player();
        PlayerHealthBar playerHealthBar = new PlayerHealthBar(player);
        PlayerManaBar playerManaBar = new PlayerManaBar(player);
        player.Damage();
    }

    public class OnPlayerDamagedEventArgs : EventArgs
    {
        public int previousHealth;
    }
    
    public class Player
    {
        // public event Action OnPlayerDamaged;
        // public Action OnPlayerDamaged;
        // public event Action<int> OnPlayerDamaged;
        // public event EventHandler OnPlayerDamaged;
        public event EventHandler<OnPlayerDamagedEventArgs> OnPlayerDamaged;

        // private PlayerHealthBar playerHealthBar;
        
        public void Damage()
        {
            // if (OnPlayerDamaged != null)
            // {
            //     // OnPlayerDamaged();
            //     // OnPlayerDamaged(45);
            //     // OnPlayerDamaged(this, EventArgs.Empty);
            //     OnPlayerDamaged(this, new OnPlayerDamagedEventArgs
            //     {
            //         previousHealth = 56,
            //     });
            //     // playerHealthBar.Player_OnPlayerDamaged();
            // }
            
            OnPlayerDamaged?.Invoke(this, new OnPlayerDamagedEventArgs
            {
                previousHealth = 56,
            });
        }
    }

    private class PlayerHealthBar
    {
        public PlayerHealthBar(Player player)
        {
            player.OnPlayerDamaged += Player_OnPlayerDamaged1;
            // player.OnPlayerDamaged();
        }

        private void Player_OnPlayerDamaged1(object sender, OnPlayerDamagedEventArgs e)
        {
            Debug.Log(e.previousHealth);
        }

        // public void Player_OnPlayerDamaged()
        public void Player_OnPlayerDamaged(int n)
        {
            Debug.Log("Player_OnPlayerDamaged!");
        }
    }

    private class PlayerManaBar
    {
        public PlayerManaBar(Player player)
        {
            // player.OnPlayerDamaged = null;
            player.OnPlayerDamaged += Player_OnPlayerDamaged1;
        }

        private void Player_OnPlayerDamaged1(object sender, OnPlayerDamagedEventArgs e)
        {
            Debug.Log(e.previousHealth);
        }

        // public void Player_OnPlayerDamaged()
        public void Player_OnPlayerDamaged(int n)
        {
            Debug.Log("Mana Bar Player_OnPlayerDamaged!");
        }
    }
}
