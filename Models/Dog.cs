using System.ComponentModel.DataAnnotations;

namespace DogApi.Models {
  public class Dog {
    public Dog(string name, int age, string breed, string color, string gender, bool houseTrained, int adoptionFee, int id) {
      Name = name;
      Age = age;
      Breed = breed;
      Color = color;
      Gender = gender;
      HouseTrained = houseTrained;
      AdoptionFee = adoptionFee;
      Id = id;
    }
    public Dog() {

    }
    [Required]
    [MaxLength(25)]
    public string Name { get; set; }
    public int Age { get; private set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public string Gender { get; set; }
    public bool? HouseTrained { get; set; }
    public int? AdoptionFee { get; set; }
    public int Id { get; set; }

  }
}