using System.Collections;
using System.Collections.Generic;

public class SpaceShip
{
  //default res = 4, pisci = 4;
  private int pisciological, metabolism, dnaCount;
  float radiationRes, resistence, resistenceMax;


  public SpaceShip(int pisciological, float resistenceMax)
  {
    this.pisciological = pisciological;
    this.resistenceMax = resistenceMax;
    this.resistence = resistenceMax;
    this.dnaCount = 0;
    this.radiationRes = 0.0f;
  }


    

  public void addDna(int dna)
  {
    this.dnaCount += dna;
  }

  public int DnaCount { get => dnaCount; }
    public float ResistenceMax { get => resistenceMax; set => resistenceMax = value; }

    public void addPisciological(int pisci)
  {
    this.pisciological += pisci;
  }
  public void addResistence(float res)
  {
    this.resistence += res;
  }

  public int getPisciological()
  {
    return this.pisciological;
  }

  public float getResistence()
  {
    return this.resistence;
  }

  public void removeLife(float life)
  {
    this.resistence -= life;
  }
}
