
using Microsoft.AspNetCore.Mvc;

namespace exercise.wwwapi.Endpoints
{
    public static class BattleshipsEndpoint
    {
        public static void ConfigureBattleshipsEndpoints(this WebApplication app)
        {
            var battleships = app.MapGroup("battleships");

            battleships.MapGet("/players", GetPlayers);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetPlayers()
        {
            return TypedResults.Ok("ok");
        }
    }
}
