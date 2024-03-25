// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Bowling World!");
{
    //RunFullGame();
    //RollMany(20, 1);          //Test All Ones
    //RollMany(20, 0);          //Gutter Game 
    //TestOneSpare();           //Test One Spare
    //TestOneStrike();          //Test One Strike
    //TestPerfectGame();        //Test Perfect Game
}

void RollMany(int rolls, int pins)
{
    var game = new BowlingGame.Game_Play.BowlingGame();
    for (int i = 0; i < rolls; i++)
    {
        game.Roll(pins);
    }
    Console.WriteLine("Bowler Scored: " + game.Score());
}
void RunFullGame()
{
    var game = new BowlingGame.Game_Play.BowlingGame();
    game.DoFullGame();
    Console.WriteLine("Bowler Scored: " + game.Score());
}

void TestOneSpare()
{
    var game = new BowlingGame.Game_Play.BowlingGame();
    RollSpare(game);
    game.Roll(4);
    RollMany(17, 0);
    Console.WriteLine("Bowler Scored: " + game.Score());
}

void RollSpare(BowlingGame.Game_Play.BowlingGame g)
{
    g.Roll(6);
    g.Roll(4);
}
void TestOneStrike()
{
    var game = new BowlingGame.Game_Play.BowlingGame();
    game.Roll(10);
    game.Roll(4);
    game.Roll(5);
    RollMany(17, 0);
    Console.WriteLine("Bowler Scored: " + game.Score());
}
void TestPerfectGame()
{
    var game = new BowlingGame.Game_Play.BowlingGame();
    RollMany(12, 10);
    //Console.WriteLine("Bowler Scored: " + game.Score());
}