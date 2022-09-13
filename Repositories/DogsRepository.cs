using System;
using System.Collections.Generic;
using DogApi.db;
using DogApi.Models;

namespace DogApi.Repositories {
  public class DogsRepository {
    internal List<Dog> GetDogs() {
      return Db.Dogs;
    }
    internal Dog CreateDog(Dog body) {
      body.Id = Db.Dogs.Count + 1;
      Db.Dogs.Add(body);
      return body;
    }
    internal Dog GetDogById(int id) {
      Dog dog = Db.Dogs.Find(d => d.Id == id);
      if (dog != null) {
        return dog;
      }
      throw new Exception("No dog found with that id");
    }
    internal Dog UpdateDog(Dog update) {
      Dog original = GetDogById(update.Id);
      original.Name = update.Name != null ? update.Name : original.Name;
      original.AdoptionFee = update.AdoptionFee ?? original.AdoptionFee;
      original.HouseTrained = update.HouseTrained ?? original.HouseTrained;
      return original;
    }
    internal string DeleteDog(int id) {
      Dog dog = Db.Dogs.Find(d => d.Id == id);
      if (!Db.Dogs.Remove(dog)) {
        throw new Exception("No dog found with that id");
      }
      return $"{dog.Name} was deleted";
    }
  }
}