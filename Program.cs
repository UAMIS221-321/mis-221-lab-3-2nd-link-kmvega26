// See https://aka.ms/new-console-template for more information
class CollegeFootballRecommendations {

static void Main() {

string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendations(enjoymentLevel);
string game = GetGameRecommendations(stadium);
DisplayStadiumDetails(stadium, game);

}

static string GetEnjoymentLevel() {

Console.WriteLine("Please select your preferred level of enjoyment from the following options (Boring, Average, Fun, Epic): ");
return Console.ReadLine();

}

static string GetStadiumRecommendations(string enjoymentLevel) {

    switch (enjoymentLevel)
        {
            case "Boring":
                return "Neyland Stadium";
            case "Average":
                return "Jordan-Hare Stadium";
            case "Fun":
                return "Tiger Stadium";
            case "Epic":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return "No recommendation";
        }
    

}

static string GetGameRecommendations (string stadium) {

    switch (stadium)
        {
            case "Neyland Stadium":
                return "Kent State";
            case "Jordan-Hare Stadium":
                return "Kentucky";
            case "Tiger Stadium":
                return "Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "Auburn";
            default:
                return "No recommendation";
        }
    

}
static void DisplayStadiumDetails(string stadium, string game) {

    Console.WriteLine("Your Stadium is " + stadium);
    Console.WriteLine("vs. " + game);

}

}