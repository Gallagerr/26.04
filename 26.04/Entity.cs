using System;

namespace _26._04
{
  public class Entity
  {
    public Guid Id { get; set; }
    public Entity()
    {
      Id = Guid.NewGuid();
    }
  }
}