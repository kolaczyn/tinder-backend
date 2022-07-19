namespace Kolaczyn.Legacy.Models;


[Obsolete("Move to clean arch")]
public class User
{
  public User(string name, Sex sex, int age)
  {
    this.Name = name;
    // TODO don't make id just a random number
    this.Id = new Random().Next(1, 20_000);
    this.Sex = sex;
    this.Age = age;
  }
  public string Name { set; get; }
  public int Id { set; get; }
  public Sex Sex { set; get; }
  public int Age { set; get; }
}