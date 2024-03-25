using System;
using System.Collections;
using System.Numerics;

namespace BowlingGame.Game_Play
{
    internal enum Status
    {
        Normal = 0,
        Spare = 1,
        Strike = 2
    }
    internal class BowlingGame
    {
        private const int Frames = 10;
        private const int StrikeLastChance = 16;
        private const int GeneralGameDone = 19;
        private int _finalScore = 0;
        private int _rollsCounter = 0;
        private Status _status = Status.Normal;
        private int _localScore = 0;
        private bool _doExtraRoll = false;

        public void Roll(int pins)
        {
            if (pins < 0 || pins > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(pins));
            }

            if (_rollsCounter % 2 == 0)
            {
                _localScore = 0;
                if (_status == Status.Spare || _status == Status.Strike)
                {
                    _finalScore += pins;
                }

                if (pins == 10)
                {
                    if (_status == Status.Strike)
                    {
                        _finalScore += pins;
                    }
                    _status = Status.Strike;
                    if (_rollsCounter == StrikeLastChance)
                    {
                        _doExtraRoll = true;
                    }
                    else if (_rollsCounter > StrikeLastChance)
                    {
                        _status = Status.Normal;
                    }

                    if (_rollsCounter <= StrikeLastChance)
                    {
                        _rollsCounter++;
                    }
                }
                _localScore += pins;
                _rollsCounter++;
            }
            else
            {
                if (_status == Status.Strike || _rollsCounter > GeneralGameDone)
                {
                    _finalScore += pins;
                }

                if (pins != 0)
                {
                    _localScore += pins;
                    if (_localScore == 10)
                    {
                        if (_doExtraRoll)
                        {
                            _status = Status.Normal;
                        }
                        else
                        {
                            _status = Status.Spare;
                        }
                    }
                    else
                    {
                        _status = Status.Normal;
                    }
                }
                _rollsCounter++;
            }
            _finalScore += pins;
        }

        public void Roll(int[] pins)
        {
            foreach (var pin in pins)
            {
                this.Roll(pin);
            }
        }

        public int Score()
        {
            return _finalScore;
        }

        public void DoFullGame()
        {
            // Add your game logic here
            //this.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 0 });        //131
            //this.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 9, 1, 10 });    //143
            //this.Roll(new int[] { 1, 3, 7, 3, 10, 1, 7, 5, 2, 5, 3, 8, 2, 8, 2, 10, 10, 10, 10 });  //163
        }

        public void ScoreBoard()
        {
            _finalScore = 0;
            _rollsCounter = 0;
        }
    }
}
