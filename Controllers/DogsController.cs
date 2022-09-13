using System;
using System.Collections.Generic;
using DogApi.Models;
using DogApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogApi.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class DogsController : ControllerBase {
    private readonly DogsService _dogService;
    public DogsController(DogsService dogService) {
      _dogService = dogService;
    }
    [HttpGet]
    public ActionResult<List<Dog>> GetDogs() {
      try 
      {
        List<Dog> dogs = _dogService.GetDogs();
        return Ok(dogs);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Dog> GetDogById(int id) {
      try
      {
        Dog dog = _dogService.GetDogById(id);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    public ActionResult<Dog> CreateDog([FromBody] Dog body) {
      try
      {
        Dog dog = _dogService.CreateDog(body);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")]
    public ActionResult<Dog> UpdateDog([FromBody] Dog body, int id) {
      try
      {
        body.Id = id;
        Dog dog = _dogService.UpdateDog(body);
        return Ok(dog);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")]
    public ActionResult<string> DeleteDog(int id) {
      try
      {
        string message = _dogService.DeleteDog(id);
        return Ok(message);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}