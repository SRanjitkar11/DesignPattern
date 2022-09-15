using InshareDesignPattern;
using System.Data.SqlClient;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DesignPattern;Integrated Security=True;MultipleActiveResultSets=True";
        SqlConnection connection = new SqlConnection(ConnectionString);
        connection.Open();

        Category category1 = new Category(1, "Test Category");
        Element element1 = new Element(1, "Test Element");
        Attributes attributes1 = new Attributes(1, "Name", "sTrinG", "Suneer");
        Attributes attributes2 = new Attributes(2, "Date", "DaTe", "10/26/2006 5:10 pM");
        Attributes attributes3 = new Attributes(3, "Price", "deciMAL", "50.8");
        Attributes attributes4 = new Attributes(3, "count", "integer", "10");
        Attributes attributes5 = new Attributes(5, "bool", "boolean", "True");
        category1.Add(element1);
        element1.Add(attributes1);
        //var id = attributes1.GetId();
        //attributes1.Add(new AttributesValue(id, "Suneer"));
        element1.Add(attributes2);
        //id = attributes2.GetId();
        //attributes2.Add(new AttributesValue(id, "10/26/2006 5:10 pM"));
        element1.Add(attributes3);
        category1.Add(new Element(2, "Element 2"));
        element1.Add(attributes4);
        element1.Add(attributes5);
        category1.Dsiplay(0);

        //StringBuilder strBuilder = new StringBuilder();
        //strBuilder.Append("INSERT INTO dbo.Category (Id, Name) VALUES ");
        //strBuilder.Append("(1, N'Test'), ");
        //string SqlQuerry = strBuilder.ToString();
        //using (SqlCommand command = new SqlCommand(SqlQuerry, connection))
        //{
        //    command.ExecuteNonQuery();
        //}

        Console.WriteLine();

        Category category2 = new Category(2, "Ball");
        category2.Add(new Element(1, "Radius"));
        category2.Add(new Element(2, "Weight"));
        category2.Dsiplay(0);

        Console.ReadKey();
    }
}
