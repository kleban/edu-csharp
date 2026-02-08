
using FootballApp_Many_To_Many.Context;
using Microsoft.EntityFrameworkCore;

var ctx = new FootballContext();

foreach(var g in ctx.Games.Include(x=> x.HomeTeam).ThenInclude(x=> x.HomeGames).Include(x=> x.AwayTeam).ThenInclude(x=> x.AwayGames))
{
    Console.WriteLine($" --- {g.Id}: {g.HomeTeam.Name} (home) - {g.AwayTeam.Name} (away)");
    Console.WriteLine($"home: {string.Join(", ", g.HomeTeam.HomeGames.Select(x=> x.Id))}");
    Console.WriteLine($"away: {string.Join(", ", g.AwayTeam.AwayGames.Select(x => x.Id))}\n");
}