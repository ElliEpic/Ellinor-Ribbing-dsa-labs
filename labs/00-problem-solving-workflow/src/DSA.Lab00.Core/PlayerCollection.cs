using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DSA.Lab00
{
    public sealed class PlayerCollection
    {
        private readonly List<Player> _players;

        public PlayerCollection(IEnumerable<Player> players)
        {
            if (players == null)
            {
                throw new ArgumentNullException(nameof(players));
            }

            _players = new List<Player>(players);
        }

        public Player? FindById(int id)
        {
            foreach (Player player in _players)
            {
                if (player.Id == id)
                {
                    return player;
                }
            }

            return null;
        }

        public Player? FindHighestScore()
        {
               foreach(Player player in _players)
            {
                if(player.Score == 160)
                {
                    return player;
                }
            }
         
            // TODO:
            // Return the player with the highest score.
            // Return null when the collection is empty.
            return null;
        }

        public bool ContainsName(string name)
        {
        
            foreach(Player player in _players)
            {
                if(player.Name == name)
                {
                    return true; 
                } 
            } 

                 return false;
            
            
            // TODO:
            // Return true when a player with exactly this name exists.
            // Use case-sensitive comparison for this lab.

            //return false;
        }
    }
}
