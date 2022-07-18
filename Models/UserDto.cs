namespace Kolaczyn.Models;

public class UserDto
{
  public UserDto(string name, int id, string sex, int age)
  {
    this.Name = name;
    this.Id = id;
    this.Sex = sex;
    this.Age = age;
  }
  public string Name { set; get; }
  public int Id { set; get; }
  public string Sex { set; get; }
  public int Age { set; get; }
}