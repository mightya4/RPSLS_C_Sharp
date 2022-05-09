namespace RPSLS_C_Sharp
{
    public abstract class Game
    {
        public abstract void SelectGameMode();

        public abstract void UpdateGameMode();

        public abstract void PlayerTurn();

        public abstract void PlayerTurnOff();
    }
}