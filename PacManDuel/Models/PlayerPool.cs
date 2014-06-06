using System;
using System.Collections.Generic;

namespace PacManDuel.Models
{
    class PlayerPool
    {
        private readonly List<Player> _players;
        private int _currentPlayerIndex;
        private int _playerMovedFirstIndex;

        public PlayerPool(Player playerA, Player playerB)
        {
            _players = new List<Player> {playerA, playerB};
            var r = new Random();
            _currentPlayerIndex = r.Next(0, _players.Count);
            _playerMovedFirstIndex = 1 - _currentPlayerIndex;
        }

        public Player GetNextPlayer()
        {
            _currentPlayerIndex++;
            if (_currentPlayerIndex > _players.Count - 1) 
                _currentPlayerIndex = 0;
            return _players[_currentPlayerIndex];
        }

        public Player GetPlayerMovedFirst()
        {
            return _players[_playerMovedFirstIndex];
        }

        public List<Player> GetPlayers()
        {
            return _players;
        }

    }
}
