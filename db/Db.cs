using System.Collections.Generic;
using DogApi.Models;

namespace DogApi.db {
  public static class Db {
    public static List<Dog> Dogs { get; set; } = new List<Dog>(){
      new Dog("Ralph", 7, "Corgi", "Orange and White", "M", true, 100, 1),
      new Dog("Roxy", 1, "Pitbull", "Gray and White", "F", false, 75, 2),
      new Dog("Gandalf", 14, "Unkown", "Gray", "M", true, 45, 3),
      new Dog("Susan", 11, "Chihuahua", "Brown", "F", false, 10, 4),
      new Dog("Jack", 3, "Jack Russell Terrier", "Brown and White", "M", true, 125, 5)
    };
  }
}