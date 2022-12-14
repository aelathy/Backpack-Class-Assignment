// Backpack-Class Assignment
#nullable disable
Console.Clear();


// Task 2
Backpack bag1 = new Backpack("Blue", "Small");
Backpack bag2 = new Backpack("Red", "Medium");
Backpack bag3 = new Backpack("Green", "Large");

//3
bag1.openBag();
bag1.putIn("Lunch");
bag1.putIn("Jacket");
bag1.closeBag();
bag1.openBag();
bag1.takeOut("Jacket");
bag1.closeBag();

class Backpack
{
    public string Color { get; set; }
    public string Size { get; set; }
    public List<string> Item { get; set; }
    public bool Open { get; set; }

    public Backpack(string color, string size)
    {
        this.Color = color;
        this.Size = size;
        this.Item = new List<string>();
        Open = false;
    }
    public void openBag()
    {
        this.Open = true;
        Console.WriteLine("Bag Opened");
    }

    public void closeBag()
    {
        this.Open = false;
        Console.WriteLine("Bag Closed");
    }

    public string putIn(string item)
    {
        if (Open)
        {
            Item.Add(item);
            Console.WriteLine(item + " Added to Backpack");
            return "Added";
        }
        else
        {
            Console.WriteLine($"Cannot put in {item} because backpack is closed.");
            return "Not Added";
        }
    }

    public string takeOut(string item)
    {
        if (Open)
        {
            Item.Remove(item);
            Console.WriteLine(item + " Removed from Backpack");
            return "Removed";
        }
        else
        {
            Console.WriteLine($"Cannot remove {item} because backpack is closed.");
            return "Not Removed";
        }
    }
}
