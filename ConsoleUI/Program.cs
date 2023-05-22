using Models;
namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var players1 = new List<FootballPlayer>{
            new Goalkeeper(
                "Craig Stokes",
                20,
                28,
                179
            ),
            new Striker(
                "Garrett Hartman",
                39,
                26,
                168
            ),
            new Striker(
                "Heather Dominguez",
                44,
                28,
                160
            ),
            new Striker(
                "Christine Arnold",
                53,
                63,
                157
            ),
            new Defender(
                "Aileen Wall",
                19,
                82,
                159
            ),
            new Defender(
                "Jared Mcgee",
                31,
                51,
                207
            ),
            new Defender(
                "Brendan Ray",
                47,
                39,
                195
            ),
            new Midfield(
                "Iola Gross",
                50,
                5,
                198
            ),
            new Midfield(
                "April Pittman",
                26,
                52,
                176
            ),
            new Midfield(
                "Aristotle Deleon",
                21,
                68,
                 209
            ),
            new Midfield(
                "Basil Douglas",
                51,
                51,
                186
            )
        };
                    var players2 = new List<FootballPlayer>{
            new Goalkeeper(
                "Drew Nolan",
                20,
                28,
                179
            ),
            new Striker(
                "Harry Wheels",
                39,
                26,
                168
            ),
            new Striker(
                "Devon Laratt",
                44,
                28,
                160
            ),
            new Striker(
                "Nico Rosberg",
                53,
                63,
                157
            ),
            new Defender(
                "Lewis Hamilton",
                19,
                82,
                159
            ),
            new Defender(
                "Michael Schumacher",
                31,
                51,
                207
            ),
            new Defender(
                "Lando Norris",
                47,
                39,
                195
            ),
            new Midfield(
                "Charles Leclerc",
                50,
                5,
                198
            ),
            new Midfield(
                "Max Verstappen",
                26,
                52,
                176
            ),
            new Midfield(
                "Donald Trump",
                21,
                68,
                 209
            ),
            new Midfield(
                "Vladimir Putin",
                51,
                51,
                186
            )
        };
            Team team1 = new Team("CSKA", new Coach("Tosho", 59), players1);
            Team team2 = new Team("Levski", new Coach("Roshko", 69), players2);
            Game game = new Game(team2, team1, new Referee("Sacho", 29), (new Referee("Dimitar", 20), new Referee("Oktavian", 18)));
            game.Play();
            Console.WriteLine(game.ToString());
            game.Play();
            Console.WriteLine(game.ToString());
            game.Play();
            Console.WriteLine(game.ToString());
            game.Play();
            Console.WriteLine(game.ToString());
        }
    }
}