namespace C_Part2.Inheritance;

public class Buyer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ItemsBought> Items { get; set; } = new List<ItemsBought>();
    public Buyer()
    {
    }

    public void Promote()
    {
        int itemsList = this.Items.Count;
        Console.WriteLine(
            CalculateBuyerRating(itemsList) ? "Buyer {0} promoted to VIP with parking." : "Buyer {0} is normal buyer.",
            this.Name);
    }

    private bool CalculateBuyerRating(int itemsList)
    {
        if (itemsList > 10)
        {
            return true;
        }
        return false;
    }
}