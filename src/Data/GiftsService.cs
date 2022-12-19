namespace giftsformeditation.Data;

using System.Linq;

public class GiftsService
{
    private static readonly string[] Gifts = new[]
    {
        "Reality",
        "Sanity",
        "Perspective",
        "Commitment",
        "Acceptance",
        "Action",
        "Happiness",
        "Courage",
        "Boundaries",
        "Relationships",
        "Forgiveness",
        "Choice",
        "Service",
        "Maturity",
        "Honesty",
        "Joy",
        "Courtesy",
        "Self-esteem",
        "Freedom",
        "Powerlessness",
        "Patience",
        "Compassion",
        "Gratitude",
        "Humor",
        "Awareness",
        "Serenity",
        "Self-knowledge",
        "Detachment",
        "Silence",
        "Faith",
        "Change",
        "Humility",
        "Balance",
        "Wonder",
        "Fellowship",
        "Tolerance",
        "Focus",
        "Responsibility",
        "Belonging",
        "Mercy",
        "Silence",
        "Hope",
        "Willingness",
        "Community",
        "Clarity",
        "Accountability",
    };

    private Random rand;

    public GiftsService() {
        rand = new Random();
    }

    public Task<string[]> GetGiftsAsync(int num) {
        return Task.Run(() => {
            var result = new List<string>(num);
            for (int i = 0; i < num; i++) {
                var gift = Gifts[rand.Next(Gifts.Length)];
                while (result.Contains(gift)) {
                    gift = Gifts[rand.Next(Gifts.Length)];
                }
                result.Add(gift);
            }
            return result.ToArray();
        });
    }
}
