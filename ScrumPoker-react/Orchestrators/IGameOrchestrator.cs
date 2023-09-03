using ScrumPoker_react.Models;

namespace ScrumPoker_react.Orchestrators;

public interface IGameOrchestrator
{
    public List<int> ValidateVotingSystem(NewGameModel votingSystem);
    public GameModel AssembleGameModel(IList<int> votingSystem, PlayerModel player, string groupId);
    public PlayerModel CreatePlayer(string playerName, string clientId, string playerMode);
    public string CreateGroup(string clientId);
    public GameModel UpdatePlayerVote(GameModel gameModel, int cardValue, string playerId);
    public GameModel UpdatePlayerId(GameModel gameModel, string oldPlayerId, string newPlayerId);
    public GameModel ResetPlayerVotes(GameModel gameModel);
    public GameModel ShowScores(GameModel gameModel);
    public GameModel AddPlayerToGame(GameModel game, PlayerModel player, string groupId);
    public GameModel RemovePlayerFromGame(GameModel game, PlayerModel player);
}